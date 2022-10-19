﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace SalesCome.API.Controllers
{
    public class BaseController : Controller
    {
        private readonly IMapper mapper;

        public BaseController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        protected IActionResult GetBadRequest()
        {
            var message = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e).First();

            string error = message.ErrorMessage;

            return new Result.BadRequestResult("00", error);
        }

        protected IActionResult GetErrorresult(Exception ex)
        {
            string error = ex.InnerException == null ? ex.Message: ex.InnerException.ToString();
            return new Result.BadRequestResult("01", error);
        }

        protected IActionResult GetCustomErrorResult(string code, string message)
        {
            return new Result.BadRequestResult(code, message);
        }
    }
}
