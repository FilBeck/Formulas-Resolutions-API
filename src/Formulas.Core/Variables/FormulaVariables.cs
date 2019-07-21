using System;
using System.Collections.Generic;
using System.Reflection;

namespace Formulas.Core.Variables
{
    public abstract class FormulaVariables
    {
        public string FindIncognite()
        {            
            PropertyInfo[] propertyInfos = GetVariables();

            foreach (var property in propertyInfos)
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
            PropertyInfo[] propertyInfos = GetVariables();

            string[] variablesNames = new string[propertyInfos.Length];

            for (int i = 0; i < propertyInfos.Length; i++)
            {
                variablesNames[i] = propertyInfos[i].Name;
            }

            return variablesNames;
        }

        public List<double?> GetVariablesValues()
        {
            var properties = GetVariables();

            List<double?> values = new List<double?>();

            foreach(var prop in properties)
            {
                double? value = (double?)prop.GetValue(this, null);
                values.Add(value);
            }

            return values;
        }

        public PropertyInfo[] GetVariables()
        {
            Type formulaType = GetType();
            return formulaType.GetProperties();
        }
    }
}
