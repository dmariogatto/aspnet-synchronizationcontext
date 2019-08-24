using System;
using System.Threading.Tasks;

namespace AsyncContextNetFramework
{
    public class AsyncServiceNetFramework
    {
        public async Task AsyncMethod(bool configAwait = true)
        {
            await Task.Delay(1000).ConfigureAwait(configAwait);
        }
    }
}
