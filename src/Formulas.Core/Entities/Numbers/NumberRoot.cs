/// <summary>
/// Classe para o formato numérico com raiz. Ex: '25√3'
/// </summary>
namespace Formulas.Core.Entities.Numbers
{
    public class NumberRoot
    {
        public int Number { get; private set; }
        public int Root { get; private set; }
        public string DisplayValue { get; private set; }

        public NumberRoot(int number, int root)
        {
            Number = number;
            Root = root;
            DefineDisplayValue();
        }

        private void DefineDisplayValue()
        {
            if (Root != 1)
            {
                DisplayValue = $"{Number}√{Root}";
            }
            else
            {
                DisplayValue = $"{Number}";
            }
        }
    }
}
