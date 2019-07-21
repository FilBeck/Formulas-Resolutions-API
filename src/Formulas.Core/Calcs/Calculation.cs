using Formulas.Core.Entities;
using Formulas.Core.Resolutions;
using System.Collections.Generic;

namespace Formulas.Core.Calcs
{
    public abstract class Calculation<T>
    {
        public Result Result { get; set; }
        public string Incognite { get; set; }
        public List<Resolution> Steps { get; set; }

        public abstract void Calculate();

        public void GenerateSteps(Resolution resolution)
        {                        
            Result.Resolutions.Add(resolution);
        }

        public abstract void HandleIncognites(T variables);
    }
}
