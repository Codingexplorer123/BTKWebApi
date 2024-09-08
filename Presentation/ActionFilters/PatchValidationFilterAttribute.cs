using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ActionFilters
{
    public class PatchValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];

            var patchDocument = context.ActionArguments.Values.FirstOrDefault(v=>v is Microsoft.AspNetCore.JsonPatch.JsonPatchDocument);

            if (patchDocument == null)
            {
                context.Result = new UnprocessableEntityObjectResult($"object is null." + $"Controller: {controller}, Action: {action}");

                return;
            }

          
        }
    }
}
