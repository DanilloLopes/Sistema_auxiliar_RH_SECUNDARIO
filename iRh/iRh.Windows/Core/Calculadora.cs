namespace iRh.Windows.Core
{
    public static class Calculadora
    {
        //FUNCAO   RETORNO  NOME ()
        public static double Inss(double salario)
        {
            const double Faixa01 = 1302.0;
            const double Faixa02 = 2571.29;
            const double Faixa03 = 3856.94;
            const double Faixa04 = 7507.49;

            double valorInss = 0;

            if(salario <= Faixa01)
            {
                valorInss = (0.075 * salario);

            }else if(salario <= Faixa02)
            {

            }


            return 0;
        }
    }
}
