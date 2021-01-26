using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace AdminProject.CommonLayer.Aspects.Models
{
    public class JsonQueryBinder : IModelBinder
    {

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var r = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            if (r == null)
            {
                return Task.CompletedTask;
            }

            //Get Id value from the route  
            var routeIdStringValue = bindingContext.ActionContext.RouteData.Values["Id"] as String;

            //Get command model payload (JSON) from the body  
            String valueFromBody;
            using (var streamReader = new StreamReader(bindingContext.HttpContext.Request.Body))
            {
                valueFromBody = streamReader.ReadToEnd();
            }

            //Deserilaize body content to model instance  
            var modelType = bindingContext.ModelMetadata.UnderlyingOrModelType;
            var modelInstance = JsonConvert.DeserializeObject(valueFromBody, modelType);

            //If Id is available and it is Guid then try to set the model instance property  
            if (!String.IsNullOrWhiteSpace(routeIdStringValue) && Guid.TryParse(routeIdStringValue, out var routeIdValue))
            {
                var idProperty = modelType.GetProperties().FirstOrDefault(p => p.Name.Equals("Id", StringComparison.InvariantCultureIgnoreCase));
                if (idProperty != null)
                {
                    //NOTE: Throws System.ArgumentException  
                    idProperty.SetValue(modelInstance, routeIdValue);
                }
            }

            bindingContext.Result = ModelBindingResult.Success(modelInstance);
            return Task.CompletedTask;
        }
    }
}
