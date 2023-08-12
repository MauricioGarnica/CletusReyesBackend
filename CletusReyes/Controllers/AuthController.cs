using CletusReyes.Models.Domain_Model.Auth;
using CletusReyes.Models.DTO.Auth.Login;
using CletusReyes.Models.DTO.Auth.Register;
using CletusReyes.Repositories.Auth;
using CletusReyes.Repositories.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CletusReyes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<TblUser> userManager;
        private readonly IAuthRepository authRepository;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<TblUser> userManager, IAuthRepository authRepository, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.authRepository = authRepository;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            try
            {
                var identityUser = new TblUser
                {
                    UserName = registerRequestDto.Username,
                    Email = registerRequestDto.Email
                };
                var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

                if (identityResult.Succeeded)
                {
                    if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                    {
                        var result = await authRepository.AddUserToRoles(identityUser.Id, registerRequestDto.Roles);

                        if (result)
                        {
                            return Ok("User was register :D");
                        }
                    }
                }
                else if (identityResult.Errors != null)
                {
                    var errors = string.Join(',', identityResult.Errors);
                    return BadRequest(errors);
                }

                return BadRequest("Something went wrong :c");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(loginRequestDto.Email);

                if (user != null)
                {
                    var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                    if (checkPasswordResult)
                    {
                        var roles = await authRepository.GetRoles(user.Id);

                        if (roles != null && roles.Any())
                        {
                            var jwt = tokenRepository.CreateJwt(user, roles);
                            var response = new LoginResponseDto
                            {
                                UserId = user.Id,
                                UserName = user.UserName,
                                JwtToken = jwt,
                                Rol = roles[0],
                            };

                            return Ok(response);
                        }
                    }

                    return BadRequest("Password are incorrect :c");
                }

                return BadRequest("User not founded :c");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
