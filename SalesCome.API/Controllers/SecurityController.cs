using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesCome.API.Models.Mapper;
using SalesCome.API.Models.Security;
using SalesCome.Application.Services.Security;
using SalesCome.Application.Services.Security.Model;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SalesCome.API.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class SecurityController : BaseController
    {
        ISecurityService _securityService;

        public SecurityController(ISecurityService securityService, IMapper mapper) : base(mapper)
        {
            _securityService = securityService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("security/validUser")]
        public async Task<IActionResult> ValidateUser([FromBody] RequestAutenticaModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _securityService.ValidUserAsync(new AutenticaMapperAPI().Map(modelAPI));

                return new Result.CreateResult(result);
            }
            catch(Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("security/getUniqueUser")]
        public async Task<IActionResult> GetUniqueUser(int userId)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                ResponseUserModel result = await _securityService.GetUniqueUser(userId);

                return Ok(new UserResponseMapAPI().Map(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("security/getAllUsers")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {                
                List<ResponseUserModel> result = await _securityService.GetUsersAsync();

                return Ok(new UserResponseMapAPI().MapList(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
