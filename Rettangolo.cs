using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eredietarietà
{
    class Rettangolo : Quadrilatero
    {
        Rettangolo(double lato1, double lato2, double lato3, double lato4)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
            Lato4 = lato4;
        }
        public override double CalcolaPerimetro()
        {
            Perimetro = Lato1 + Lato2 + Lato3 + Lato4;
            return base.CalcolaPerimetro();
        }

    }
}
