using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace learning_dotnet_core_web_api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }
    }

    public class AsyncExceptionFilter : IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();

            Task t = new Task(() =>
            {
                Common.TraceCaller();
            });
            t.Start();
            await t;
        }
    }
}
