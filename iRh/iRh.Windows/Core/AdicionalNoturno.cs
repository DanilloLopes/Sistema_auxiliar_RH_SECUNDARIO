using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double Calcula(double salario, double horasNoturnasTrabalhadas, double horasTrabalhadas)
        {
            double valorDaHoraTrabalhada = salario / horasTrabalhadas;
            double equivalenteHorasNoturnas = 60 * horasNoturnasTrabalhadas / 52.5;
            double adicionalNoturno = 0.2 * valorDaHoraTrabalhada * equivalenteHorasNoturnas;

            return adicionalNoturno;
        }
    }
}
