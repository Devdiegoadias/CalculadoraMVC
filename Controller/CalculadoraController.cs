using CalculadoraMVC.Model;
using CalculadoraMVC.View;

namespace CalculadoraMVC.Controller
{
    internal class CalculadoraController
    {
        private CalculadoraModel model = new CalculadoraModel();
        private CalculadoraView view = new CalculadoraView();

        public void Executar()
        {
            while (true)
            {
                double a = view.LerNumero("Digite o primeiro número: ");
                double b = view.LerNumero("Digite o segundo número: ");
                char operacao = view.LerOperacao();

                double resultado;

                try
                {
                    switch (operacao)
                    {
                        case '+':
                            resultado = model.Adicionar(a, b);
                            break;
                        case '-':
                            resultado = model.Subtrair(a, b);
                            break;
                        case '*':
                            resultado = model.Multiplicar(a, b);
                            break;
                        case '/':
                            resultado = model.Dividir(a, b);
                            break;
                        default:
                            Console.WriteLine("Operação inválida!");
                            continue;
                    }

                    view.ExibirResultado(resultado);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Erro: Divisão por zero!\n");
                }

                Console.WriteLine("Deseja continuar? (s/n)");
                if (Console.ReadLine().ToLower() != "s")
                {
                    break;
                }
            }
        }
    }
}
