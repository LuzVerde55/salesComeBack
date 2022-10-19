using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesCome.API.Models.Mapper;
using SalesCome.Application.Services.Sales;
using SalesCome.Application.Services.Sales.Model;
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
    public class SalesController : BaseController
    {
        private readonly ISalesServices _salesServices;

        public SalesController(ISalesServices salesServices, IMapper mapper): base(mapper)
        {
            _salesServices = salesServices;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("sales/getHistory")]
        public async Task<IActionResult> GetSales()
        {
            try
            {
                List<ResponseSalesModel> result = await _salesServices.GetSalesASync();

                return Ok(new SalesMapperAPI().MapListResp(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
