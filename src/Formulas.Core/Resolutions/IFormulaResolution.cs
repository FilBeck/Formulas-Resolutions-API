using System.Collections.Generic;

namespace Formulas.Core.Resolutions
{
    public interface IFormulaResolution
    {        
        List<Resolution> Generate();
    }
}
