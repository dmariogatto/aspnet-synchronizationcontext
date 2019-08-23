using System;
using System.Threading.Tasks;

namespace AsyncContextNetFull
{
    public class AsyncServiceNetFull
    {
        public async Task AsyncMethod(bool configAwait = true)
        {
            await Task.Delay(1000).ConfigureAwait(configAwait);
        }
    }
}
