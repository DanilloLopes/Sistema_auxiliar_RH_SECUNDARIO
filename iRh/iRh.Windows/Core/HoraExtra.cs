using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class HoraExtra
    {
        public static double Calcula(double salario, double horasExtrasTrabalhadas, double horasTrabalhas)
        {
            double valorDaHoraTrabalhada = salario / horasTrabalhas;
            double valorDaHoraExtraTrabalhada = valorDaHoraTrabalhada * 2;
            double valorAdicionalHoraExtra = valorDaHoraExtraTrabalhada * horasExtrasTrabalhadas;

            return valorAdicionalHoraExtra;
        }
    }
}
