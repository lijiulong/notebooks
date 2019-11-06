using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace learning_dotnet_core_web_api.Filters
{
    public class ResourceFilter : IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }
    }

    public class AsyncResourceFilter : IAsyncResourceFilter
    {
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();

            await next();
        }
    }
}
