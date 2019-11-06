using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace learning_dotnet_core_web_api.Filters
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }
    }

    public class AsyncResultFilter : IAsyncResultFilter
    {
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();

            await next();
        }
    }
}
