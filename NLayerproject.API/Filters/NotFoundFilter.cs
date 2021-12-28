using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerproject.API.DTOs;
using NLayerproject.Core.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerproject.API.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {

        private readonly IProductService _productService;
        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id =(int)context.ActionArguments.Values.FirstOrDefault();
            
            var product = await _productService.GetByIdAsync(id);

            if(product != null)
            {
               await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id'si {id} olan ürün bulunamadı");
                context.Result = new NotFoundObjectResult(errorDto);

            }
        }

    }
}
