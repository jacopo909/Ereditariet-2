using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eredietarietà
{
    class Triangolo : FiguraGeormetrica
    {
        private double lato_t_1;
        private double lato_t_2;
        private double lato_t_3;

        public double Lato_T_1 { get; set; }
        public double Lato_T_2 { get; set; }
        public double Lato_T_3 { get; set; }

        Triangolo(double lato1, double lato2, double lato3)
        {
            Lato_T_1 = lato1;
            Lato_T_2 = lato2;
            Lato_T_3 = lato3;
        }
        public override double CalcolaPerimetro()
        {
            Perimetro = Lato_T_1 + Lato_T_2 + Lato_T_3;
            return base.CalcolaPerimetro();
        }
    }
}
