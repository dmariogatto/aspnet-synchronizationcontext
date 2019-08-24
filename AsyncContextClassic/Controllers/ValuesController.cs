using AsyncContextNetFramework;
using AsyncContextNetStandard;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace AsyncContextClassic.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly AsyncServiceNetFramework _asyncFrameworkService = new AsyncServiceNetFramework();
        private readonly AsyncServiceNetStandard _asyncStandardService = new AsyncServiceNetStandard();

        [HttpGet]
        [Route("api/values")]
        public IEnumerable<string> Get()
        {
            // Trust me it's not null - {System.Web.AspNetSynchronizationContext}
            var context = SynchronizationContext.Current;

            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/values/framework/async")]
        public async Task<IEnumerable<string>> AsyncFramework()
        {
            await _asyncFrameworkService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/values/framework/sync")]
        public IEnumerable<string> SyncFramework(bool configAwait)
        {
            _asyncFrameworkService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/values/standard/async")]
        public async Task<IEnumerable<string>> AsyncStandard()
        {
            await _asyncStandardService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/values/standard/sync")]
        public IEnumerable<string> SyncStandard(bool configAwait)
        {
            _asyncStandardService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }
    }
}
