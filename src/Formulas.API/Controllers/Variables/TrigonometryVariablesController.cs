using Formulas.Core.Variables.Trigonometry;
using Microsoft.AspNetCore.Mvc;

namespace Formulas.API.Controllers.Variables
{
    [Route("api/variables")]
    [ApiController]
    public class TrigonometryVariablesController : ControllerBase
    {
        [HttpGet("pythagoras")]
        public IActionResult PythagorasVariables()
        {
            var variables = new PythagorasVariables().GetVariablesNames();            
            return Ok(variables);
        }

        [HttpGet("triangle-area")]
        public IActionResult TriangleAreaVariables()
        {
            var variables = new TriangleAreaVariables().GetVariablesNames();
            return Ok(variables);
        }
    }
}
