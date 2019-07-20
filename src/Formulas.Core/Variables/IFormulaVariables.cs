using System;
using System.Reflection;

namespace Formulas.Core.Variables
{
    public abstract class FormulaVariables
    {
        public string FindIncognite()
        {
            Type formulaType = GetType();
            PropertyInfo[] properties = formulaType.GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(this, null) == null)
                {
                    return property.Name;
                }
            }

            return null;
        }

        public string[] GetVariablesNames()
        {
            Type variablesClass = GetType();
            PropertyInfo[] propertyInfos = variablesClass.GetProperties();

            string[] variablesNames = new string[propertyInfos.Length];

            for (int i = 0; i < propertyInfos.Length; i++)
            {
                variablesNames[i] = propertyInfos[i].Name;
            }

            return variablesNames;
        }
    }
}
