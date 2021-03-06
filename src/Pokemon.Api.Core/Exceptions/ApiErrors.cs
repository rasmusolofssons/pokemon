﻿using System.ComponentModel;

namespace Pokemon.Api.Core.Exceptions
{
    public enum ApiErrors
    {
        [Description("Deletion failure")]
        DeletionFailure = 0,

        [Description("Not found")]
        NotFound = 1,

        [Description("Bad request")]
        BadRequest = 2,

        [Description("Unknown Error")]
        UnknownError = 3,

        [Description("Validation Failed")]
        ValidationFailed = 4
    }
}