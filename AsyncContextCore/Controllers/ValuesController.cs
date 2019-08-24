using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AsyncContextNetFramework;
using AsyncContextNetStandard;
using Microsoft.AspNetCore.Mvc;

namespace AsyncContextCore.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AsyncServiceNetFramework _asyncFrameworkService = new AsyncServiceNetFramework();
        private readonly AsyncServiceNetStandard _asyncStandardService = new AsyncServiceNetStandard();

        [HttpGet("api/values")]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Trust me it's null
            var context = SynchronizationContext.Current;

            return new string[] { "value1", "value2" };
        }

        [HttpGet("api/values/framework/async")]
        public async Task<ActionResult<IEnumerable<string>>> AsyncFramework()
        {
            await _asyncFrameworkService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("api/values/framework/sync")]
        public ActionResult<IEnumerable<string>> SyncFramework([FromQuery] bool configAwait)
        {
            _asyncFrameworkService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("api/values/standard/async")]
        public async Task<ActionResult<IEnumerable<string>>> AsyncStandard()
        {
            await _asyncStandardService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [HttpGet("api/values/standard/sync")]
        public ActionResult<IEnumerable<string>> SyncStandard([FromQuery] bool configAwait)
        {
            _asyncStandardService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }
    }
}
