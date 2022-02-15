using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_correcto
{
    class Program
    {
        static void Main(string[] args)
        {
            Comida comida = new Pizza();
            comida.PonerIngredientes(new string[] { "jamon", "cebolla", "cantimpalo" });
            comida.Cocinar();
            Console.ReadKey();
        }
    }
}
