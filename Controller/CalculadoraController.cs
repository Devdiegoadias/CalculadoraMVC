using CalculadoraMVC.Model;
using CalculadoraMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                double a = view.PegarNumero("Digite o primeiro número: ");
                double b = view.PegarNumero("Digite o segundo número: ");
                char operacao = view.PegarOperacao();

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
