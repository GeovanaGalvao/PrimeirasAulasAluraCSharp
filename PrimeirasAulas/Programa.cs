namespace PrimeirasAulas{
    public class Programa{
        public static void Main(string[] args){

            int duracaoInvestimento = 5;
            double investimento = 10000.00;

            OlaMundo();
            Console.WriteLine("Eu sou " + (VerificaIdade(CriandoVariavelInteira()) ? "maior" : "menor") 
                + " de idade.\nEu tenho " + CriandoVariavelInteira() + " anos.");
            Console.WriteLine("Quando eu trabalhava, meu salário era de R$: "
                + CriandoVariaveisDePontoFlutuante() + " reais.");
            Console.WriteLine("Eu investi " + investimento + " reais e a poupança rendeu "
                + CalculaRendimentoDaPoupanca(investimento, duracaoInvestimento)
                + " reais depois de " + duracaoInvestimento + " meses");
            Console.WriteLine("Caso eu investisse por um ano, esse mesmo valor de "
                + investimento + " reais, o rendimento total seria de "
                + CalculaRendimentoDaPoupanca(investimento) + " reais.");
            Console.WriteLine(ConcatenandoTexto());
            Console.Write("Aperte qualquer tecla para continuar... ");

            char tecla = ObtendoTeclas();
            Console.WriteLine("\nA tecla pressionada foi: " + tecla);
            //No caso de algumas teclas, não é possível visualizar o resultado.
        }

        private static double CalculaRendimentoDaPoupanca(double investimento){
            double rendimento = investimento;

            for (int duracao = 1; duracao <= 12; duracao++)
                rendimento *= 1.005;

            return Math.Round(rendimento - investimento, 2);
        }

        private static double CalculaRendimentoDaPoupanca(double investimento, int duracao){
            double rendimento = investimento;

            while (duracao > 0){
                rendimento *= 1.005;
                duracao--;
            }

            return Math.Round(rendimento - investimento, 2);
        }

        private static string ConcatenandoTexto(){
            string texto = "Hoje é dia: 04 de julho";
            return texto + " de 2022.";
        }

        private static double CriandoVariaveisDePontoFlutuante(){
            double meuSalario = 3000.00;
            return meuSalario/2;
        }

        private static int CriandoVariavelInteira(){
            int minhaIdade = 28;
            return minhaIdade;
        }

        private static char ObtendoTeclas(){
            return Console.ReadKey().KeyChar;
        }

        private static void OlaMundo(){
            Console.WriteLine("Olá, mundo!");
        }

        private static bool VerificaIdade(int idade){
            return idade >= 18;
        }
    }
}
