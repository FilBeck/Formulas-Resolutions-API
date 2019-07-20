using Formulas.Core.Entities.Formulas.Trigonometry;
using Formulas.Core.Variables.Trigonometry;
using Microsoft.AspNetCore.Mvc;

namespace Formulas.API.Controllers
{
    [Route("api/algebra")]
    [ApiController]
    public class AlgebraController : ControllerBase
    {        
        [HttpGet("pythagoras")]
        public IActionResult Pythagoras(PythagorasVariables variables)
        {
            var formula = new Pythagoras(variables);
            return Ok(formula.Execute());
        }
    }
}
