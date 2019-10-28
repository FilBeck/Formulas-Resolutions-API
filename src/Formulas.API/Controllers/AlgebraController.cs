using Formulas.Core.Entities.Formulas.Algebra;
using Formulas.Core.Entities.Formulas.Trigonometry;
using Formulas.Core.Variables.Algebra;
using Formulas.Core.Variables.Trigonometry;
using Microsoft.AspNetCore.Mvc;

namespace Formulas.API.Controllers
{
    [Route("api/algebra")]
    [ApiController]
    public class AlgebraController : ControllerBase
    {        
        [HttpGet("bhaskara")]
        public IActionResult Bhaskara(BhaskaraVariables variables)
        {
            Bhaskara formula = new Bhaskara(variables);
            return Ok(formula.Execute());
        }

        [HttpGet("quadratic-equation")]
        public IActionResult QuadraticEquation(BhaskaraVariables variables)
        {
            Bhaskara formula = new Bhaskara(variables);
            return Ok(formula.Execute());
        }
    }
}
