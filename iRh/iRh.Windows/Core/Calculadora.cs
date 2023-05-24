namespace iRh.Windows.Core
{
    public static class Calculadora
    {
        const double Faixa01 = 1302.0;
        const double Faixa02 = 2571.29;
        const double Faixa03 = 3856.94;
        const double Faixa04 = 7507.49;
        public static double Inss(double salario)
        {

            double valorInss = 0;

            if(salario <= Faixa01)
            {
                valorInss = Calculadora.CalculaFaixa1(salario);

            }else if(salario <= Faixa02)
            {
                valorInss = 0.09 * ((salario - Faixa01) + Calculadora.CalculaFaixa1(salario));
            }else if(salario <= Faixa03)
            {
                valorInss = 0.12 * ((salario - Faixa02) + Calculadora.CalculaFaixa1(salario) + Calculadora.CalculaFaixa2(salario));
            }else if(salario <= Faixa04)
            {
                valorInss = 0.14 * ((salario - Faixa03) + Calculadora.CalculaFaixa1(salario) + Calculadora.CalculaFaixa2(salario) + Calculadora.CalculaFaixa3(salario));
            }else
            {
                valorInss = Calculadora.CalculaFaixa1(salario) + Calculadora.CalculaFaixa2(salario) + Calculadora.CalculaFaixa3(salario) + Calculadora.CalculaFaixa4(salario);
            }
            return valorInss;
        }
        private static double CalculaFaixa1(double salario)
        {
            return(0.075 * salario);
        }
        private static double CalculaFaixa2(double salario)
        {
            return(0.09 * (Faixa02 - Faixa01));
        }
        private static double CalculaFaixa3(double salario)
        {
            return(0.12 * (Faixa03 - Faixa02));
        }
        private static double CalculaFaixa4(double salario)
        {
            return(0.14 * (Faixa04 - Faixa03));
        }
    }
}
