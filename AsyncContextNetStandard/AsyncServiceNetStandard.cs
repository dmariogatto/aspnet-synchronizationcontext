using System;
using System.Threading.Tasks;

namespace AsyncContextNetStandard
{
    public class AsyncServiceNetStandard
    {
        public async Task AsyncMethod(bool configAwait = true)
        {
            await Task.Delay(1000).ConfigureAwait(configAwait);
        }
    }
}
