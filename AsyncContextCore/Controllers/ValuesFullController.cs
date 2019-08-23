﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncContextNetFull;
using Microsoft.AspNetCore.Mvc;

namespace AsyncContextCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesFullController : ControllerBase
    {
        private readonly AsyncServiceNetFull _asyncService = new AsyncServiceNetFull();
                
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("Async")]
        public async Task<ActionResult<IEnumerable<string>>> Async()
        {
            await _asyncService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("Sync")]
        public ActionResult<IEnumerable<string>> Sync([FromQuery] bool configAwait)
        {
            _asyncService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }
    }
}