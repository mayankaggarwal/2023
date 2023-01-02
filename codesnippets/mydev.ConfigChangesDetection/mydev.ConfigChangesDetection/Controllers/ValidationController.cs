using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mydev.ConfigChangesDetection.Services;

namespace mydev.ConfigChangesDetection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly IValidationEngine _validationEngine;
        public ValidationController(IValidationEngine validationEngine)
        {
            _validationEngine= validationEngine;
        }
        [HttpGet]
        public IActionResult GetValidationResult()
        {
            return Ok(_validationEngine.Validate());
        }
    }
}
