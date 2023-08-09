using CletusReyes.Models.DTO.Auth.Login;
using CletusReyes.Models.DTO.Auth.Register;
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
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            try
            {
                var identityUser = new IdentityUser
                {
                    UserName = registerRequestDto.Username,
                    Email = registerRequestDto.Email,
                };
                var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

                if(identityResult.Succeeded)
                {
                    if(registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                    {
                        identityResult = await userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

                        if (identityResult.Succeeded)
                        {
                            return Ok("User was register :D");
                        }
                    }
                }

                return BadRequest("Something went wrong :c");
            }
            catch(Exception ex)
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

                if(user != null)
                {
                    var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);

                    if (checkPasswordResult)
                    {
                        var roles = await userManager.GetRolesAsync(user);

                        if(roles != null && roles.Any())
                        {
                            var jwt = tokenRepository.CreateJwt(user, roles.ToList());
                            var response = new LoginResponseDto
                            {
                                UserId = user.Id,
                                UserName = user.UserName,
                                JwtToken = jwt,
                                Roles = roles,
                            };

                            return Ok(response);
                        }
                    }

                    return BadRequest("Password are incorrect :c");
                }

                return BadRequest("User not founded :c");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
