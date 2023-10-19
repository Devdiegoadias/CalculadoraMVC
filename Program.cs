using CalculadoraMVC.Controller;

class Program
{
    static void Main(string[] args)
    {
        var controlador = new CalculadoraController();
        controlador.Executar();
    }
}