using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMVC.View
{
    internal class CalculadoraView
    {
        public void ExibirResultado(double resultado)
        {
            Console.WriteLine($"Resultado: {resultado}\n");
        }

        public double LerNumero(string mensagem)
        {
            Console.Write(mensagem);
            return double.Parse(Console.ReadLine());
        }

        public char LerOperacao()
        {
            Console.WriteLine("Escolha uma operação (+, -, *, /): ");
            return Console.ReadLine()[0];
        }

    }
}
