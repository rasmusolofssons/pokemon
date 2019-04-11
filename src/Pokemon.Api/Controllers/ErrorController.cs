﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Api.Core.Exceptions;
using Pokemon.Api.Core.Logging;
using Pokemon.Api.Core.Models;

namespace Pokemon.Api.Web.Controllers
{
    [Route("api/[controller]")]
    public class ErrorController : Controller
    {
        private readonly ILoggingService _loggingService;

        public ErrorController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public GenericApiResponse<string> Error()
        {
            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            var apiException = exception as ApiException;
            int errorNumber = apiException?.ErrorNumber ?? -1;
            _loggingService.Error($"Request failed: {exception.HResult} {exception.Message} | Error Number: {errorNumber} |");

            return new GenericApiResponse<string>(null, exception.Message, errorNumber);
        }
    }
}
