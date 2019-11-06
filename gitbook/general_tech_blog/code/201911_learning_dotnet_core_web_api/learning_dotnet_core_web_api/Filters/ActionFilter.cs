using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace learning_dotnet_core_web_api.Filters
{
    public class ActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }
    }

    public class AsyncActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();

            await next();
        }
    }
}
