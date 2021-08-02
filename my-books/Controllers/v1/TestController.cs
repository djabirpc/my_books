﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiVersion("1.2")]
    [ApiVersion("1.9")]
    [Route("api/[controller]")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("get-test-data")]
        public IActionResult GetV2()
        {
            return Ok("this is test controller V1");
        }

        [HttpGet("get-test-data"), MapToApiVersion("1.2")]
        public IActionResult GetV12()
        {
            return Ok("this is test controller V1.2");
        }

        [HttpGet("get-test-data"),MapToApiVersion("1.9")]
        public IActionResult GetV19()
        {
            return Ok("this is test controller V1.9");
        }
    }
}
