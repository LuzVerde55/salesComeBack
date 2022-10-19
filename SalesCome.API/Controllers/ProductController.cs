using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesCome.API.Models.Mapper;
using SalesCome.API.Models.Products;
using SalesCome.Application.Services.Products;
using SalesCome.Application.Services.Products.Model;
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
    public class ProductController : BaseController
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices, IMapper mapper) : base(mapper)
        {
            _productServices = productServices;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("product/Save")]
        public async Task<IActionResult> SaveClient([FromBody] RequestProductModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.SaveProductAsync(new ProductMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("product/Update")]
        public async Task<IActionResult> UpdateClient([FromBody] RequestProductModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.UpdateProductAsync(new ProductMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("product/Delete")]
        public async Task<IActionResult> DeleteClient([FromBody] RequestProductModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.DelteProductAsync(new ProductMapperAPI().MapReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("product/getAllProducts")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                List<ResponseProductModel> result = await _productServices.GetProductAsync();

                return Ok(new ProductMapperAPI().MapListResp(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("product/SaveQuantity")]
        public async Task<IActionResult> SaveClientContact([FromBody] RequestQuantityModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.SaveQuantityAsync(new ProductMapperAPI().MapQuantityReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpPut]
        [AllowAnonymous]
        [Route("product/UpdateQuantity")]
        public async Task<IActionResult> UpdateClientContact([FromBody] RequestQuantityModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.UpdateQuantityAsync(new ProductMapperAPI().MapQuantityReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("product/DeleteQuantity")]
        public async Task<IActionResult> DeleteClientContact([FromBody] RequestQuantityModelAPI modelAPI)
        {
            if (!ModelState.IsValid) return GetBadRequest();
            try
            {
                bool result = await _productServices.DeleteQuantityAsync(new ProductMapperAPI().MapQuantityReq(modelAPI));

                return new Result.CreateResult(result);
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("product/getQuantity")]
        public async Task<IActionResult> GetContact(int productId)
        {
            try
            {
                List<ResponseQuantityModel> result = await _productServices.GetQuantityAsync(productId);

                return Ok(new ProductMapperAPI().MapListRespQuantity(result));
            }
            catch (Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
