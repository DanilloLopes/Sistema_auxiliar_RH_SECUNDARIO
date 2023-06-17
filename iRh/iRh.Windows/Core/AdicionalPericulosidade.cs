using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class AdicionalPericulosidade
    {
        static double Calcula(double salarioBase)
        {
            double adicionalPericulosidade = 0.3 * salarioBase;
            return adicionalPericulosidade;
        }
    }
}

