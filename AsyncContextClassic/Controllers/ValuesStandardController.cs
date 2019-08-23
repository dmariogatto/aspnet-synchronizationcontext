
using AsyncContextNetFull;
using AsyncContextNetStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AsyncContextClassic.Controllers
{
    public class ValuesStandardController : ApiController
    {
        private readonly AsyncServiceNetStandard _asyncService = new AsyncServiceNetStandard();

        // GET api/values
        [ActionName("index")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [ActionName("async")]
        public async Task<IEnumerable<string>> GetAsync()
        {
            await _asyncService.AsyncMethod();
            return new string[] { "value1", "value2" };
        }

        [ActionName("sync")]
        public IEnumerable<string> GetSync(bool configAwait)
        {
            _asyncService.AsyncMethod(configAwait).Wait();
            return new string[] { "value1", "value2" };
        }
    }
}
