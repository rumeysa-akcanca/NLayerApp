using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //Bu bir endpoint değil swagger endpoint olarak algılamasın
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)//Nocontent
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };

        }
    }
}
