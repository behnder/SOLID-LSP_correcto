using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_correcto
{
    class Comida
    {

        public virtual void PonerIngredientes(String[] ingredientes) { }
        public virtual void Cocinar() { }
    }

}
