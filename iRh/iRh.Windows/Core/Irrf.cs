namespace iRh.Windows.Core
{
    public static class Irrf
    {
        public static double Calcula(double salario)
        {
            const double Faixa01 = 2112.00;
            const double Faixa02 = 2826.65;
            const double Faixa03 = 3751.05;
            const double Faixa04 = 4664.68;
            const double ParceDeduzidaFaixa01 = 158.40;
            const double ParceDeduzidaFaixa02 = 370.40;
            const double ParceDeduzidaFaixa03 = 651.73;
            const double ParceDeduzidaFaixa04 = 884.96;

            double valorIrrf = 0;
            double inss = Inss.Calcula(salario);
            double salarioComDescontos = salario - inss ;
            if (salarioComDescontos <= Faixa01)
            {
                valorIrrf = 0.0;
            }else if(salarioComDescontos <= Faixa02)
            {
                double valorAliquota = 0.075 * salarioComDescontos;
                valorIrrf = valorAliquota - ParceDeduzidaFaixa01;
            }else if(salarioComDescontos <= Faixa03)
            {
                double valorAliquota = 0.15 * salarioComDescontos;
                valorIrrf = valorAliquota - ParceDeduzidaFaixa02;
            }else if(salarioComDescontos <= Faixa04)
            {
                double valorAliquota = 0.225 * salarioComDescontos;
                valorIrrf = valorAliquota - ParceDeduzidaFaixa03;
            }
            else
            {
                double valorAliquota = 0.275 * salarioComDescontos;
                valorIrrf = valorAliquota - ParceDeduzidaFaixa04;
            }
            return valorIrrf;
        }

    }
}
