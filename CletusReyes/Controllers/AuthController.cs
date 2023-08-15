using AutoMapper;
using CletusReyes.Models.Domain_Model.Auth;
using CletusReyes.Models.DTO.Auth.Login;
using CletusReyes.Models.DTO.Auth.Register;
using CletusReyes.Models.DTO.User;
using CletusReyes.Repositories.Auth;
using CletusReyes.Repositories.Token;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IMapper mapper;

        public AuthController(UserManager<TblUser> userManager, IAuthRepository authRepository, ITokenRepository tokenRepository, IMapper mapper)
        {
            this.userManager = userManager;
            this.authRepository = authRepository;
            this.tokenRepository = tokenRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            try
            {
                var identityUser = new TblUser
                {
                    Email = registerRequestDto.Email
                };

                var emailExists = await userManager.FindByEmailAsync(identityUser.Email);

                if (emailExists != null)
                {
                    var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

                    if (identityResult.Succeeded)
                    {
                        if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                        {
                            var result = await authRepository.AddUserToRoles(identityUser.Id, registerRequestDto.Roles);

                            if (result)
                            {
                                var jwt = tokenRepository.CreateJwt(identityUser, registerRequestDto.Roles);

                                var response = new LoginResponseDto
                                {
                                    UserId = identityUser.Id,
                                    Rol = registerRequestDto.Roles[0],
                                    JwtToken = jwt
                                };
                                return Ok(response);
                            }
                        }
                    }
                    else if (identityResult.Errors != null)
                    {
                        var errors = string.Join(',', identityResult.Errors);
                        return BadRequest(errors);
                    }
                }
                else
                {
                    return BadRequest("El correo ya se encuentra registrado");
                }

                return BadRequest("Algo se hizo mal, intentelo de nuevo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Update/{id}")]
        [Authorize(Roles = "Admin, Customer")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateUserRequestDomainModel updateUserRequestDomainModel)
        {
            try
            {
                var personDomainModel = await authRepository.Update(id, updateUserRequestDomainModel);
                var roles = await authRepository.GetRoles(personDomainModel.User.Id);
                var personResponseDto = mapper.Map<PersonResponseDto>(personDomainModel);
                personResponseDto.Rol = roles[0];

                return personDomainModel == null ? NotFound() : Ok(personResponseDto);
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
                            var personLogin = await authRepository.GetById(user.Id);
                            var jwt = tokenRepository.CreateJwt(user, roles);

                            if (personLogin != null)
                            {
                                var responsePerson = mapper.Map<PersonResponseDto>(personLogin);
                                responsePerson.Rol = roles[0];
                                responsePerson.Token = jwt;

                                return Ok(responsePerson);
                            }
                            
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

                    return BadRequest("Contraseña incorrecta :c");
                }

                return BadRequest("Correo incorrecto :c");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
