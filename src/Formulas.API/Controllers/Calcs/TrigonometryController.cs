using Formulas.Core.Entities.Formulas.Trigonometry;
using Formulas.Core.Variables.Trigonometry;
using Microsoft.AspNetCore.Mvc;

namespace Formulas.API.Controllers
{
    [Route("api/trigonometry")]
    [ApiController]
    public class TrigonometryController : ControllerBase
    {        
        [HttpPost("pythagoras")]
        public IActionResult Pythagoras(PythagorasVariables variables)
        {
            var formula = new Pythagoras(variables);
            return Ok(formula.Execute());
        }
    }
}
