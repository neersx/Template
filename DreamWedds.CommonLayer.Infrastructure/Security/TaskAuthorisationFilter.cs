using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DreamWedds.CommonLayer.Infrastructure.Security
{
    public class TaskAuthorisationFilter : IAsyncAuthorizationFilter
    {
        readonly ITaskAuthorisation _taskAuthorisation;

        public TaskAuthorisationFilter(ITaskAuthorisation taskAuthorisation)
        {
            _taskAuthorisation = taskAuthorisation ?? throw new ArgumentNullException(nameof(taskAuthorisation));
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext actionContext)
        {
            if (actionContext == null) throw new ArgumentNullException(nameof(actionContext));
            if (actionContext.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                var actionAttributes = controllerActionDescriptor.MethodInfo.GetCustomAttributes(inherit: true);

                //if (!_taskAuthorisation.Authorize(
                //    actionContext.ActionDescriptor.FilterDescriptors
                //        .Where(x => x.Filter.GetType() == typeof(RequiresAccessToAttribute)).ToArray()))
                //{
                //    throw new Exception("User is not authorized. Forbidden request.");
                //}
            }

            //return Task.FromResult(0);
        }
    }
}
