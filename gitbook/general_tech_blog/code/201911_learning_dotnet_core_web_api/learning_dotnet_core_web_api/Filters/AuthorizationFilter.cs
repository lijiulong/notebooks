using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace learning_dotnet_core_web_api.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Common.TraceCaller();
            //throw new NotImplementedException();
        }
    }

    public class AsyncAuthorizationFilter : IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
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
