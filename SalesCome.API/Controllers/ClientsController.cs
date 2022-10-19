using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesCome.API.Models.Client;
using SalesCome.API.Models.Mapper;
using SalesCome.Application.Services.Clients;
using SalesCome.Application.Services.Clients.Model;
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
    public class ClientsController : BaseController
    {
        private readonly IClientServices _clientServices;

        public ClientsController(IMapper mapper, IClientServices clientServices) : base(mapper)
        {
            _clientServices = clientServices;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("client/Save")]
        public async Task<IActionResult> SaveClient([FromBody] RequestClientModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.SaveClientAsync(new ClientMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("client/Update")]
        public async Task<IActionResult> UpdateClient([FromBody] RequestClientModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.UpdateClientAsync(new ClientMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("client/Delete")]
        public async Task<IActionResult> DeleteClient([FromBody] RequestClientModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.DeleteClientAsync(new ClientMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("client/getAllClients")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                List<ResponseClientModel> result = await _clientServices.GetClientsasync();

                return Ok(new ClientMapperAPI().MapListResp(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("client/SaveContact")]
        public async Task<IActionResult> SaveClientContact([FromBody] RequestContactInfoModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.SaveConctacInfoAsync(new ClientMapperAPI().MapContactInfoReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("client/UpdateContact")]
        public async Task<IActionResult> UpdateClientContact([FromBody] RequestContactInfoModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.UpdateConctacInfoAsync(new ClientMapperAPI().MapContactInfoReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("client/DeleteContact")]
        public async Task<IActionResult> DeleteClientContact([FromBody] RequestContactInfoModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _clientServices.DeleteConctacInfoAsync(new ClientMapperAPI().MapContactInfoReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("client/getContactInfo")]
        public async Task<IActionResult> GetContact(int clientId)
        {
            try
            {
                List<ResponseContactInfoModel> result = await _clientServices.GetConctacInfoasync(clientId);

                return Ok(new ClientMapperAPI().MapListRespContactInfo(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
