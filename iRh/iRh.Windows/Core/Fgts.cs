using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class Fgts
    {
        public static double Calcula(double salario)
        {
            var beneficioFgts = 0.08 * salario;
            return beneficioFgts;
        }
    }
}
