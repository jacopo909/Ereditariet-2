using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eredietarietà
{
    public class FiguraGeormetrica
    {
        private double perimetro;
        internal double Perimetro { get; set; }

        public virtual double CalcolaPerimetro()
        {
            return Perimetro;
        }
    }
}
