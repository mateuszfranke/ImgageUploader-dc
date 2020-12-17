using Microsoft.AspNetCore.Mvc;

namespace ImageUploader.Controllers
{
    [ApiController]
    [Route("api/upload")]
    public class UploadController:ControllerBase
    {

        [HttpGet]
        public IActionResult test()
        {
            return new OkObjectResult("ok");
        }
    }
}