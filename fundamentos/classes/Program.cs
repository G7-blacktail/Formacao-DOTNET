using Classes.Models;

// Antiga forma de instanciar no dotnet
/*
Pessoa p = new Pessoa();
p.Nome = "nome";
p.Idade = numero;
*/

internal class Program
{
    private static void Main(string[] args)
    {
        // Novo modo de instanciar no dotnet
        Pessoa p = new()
        {
            Nome = "Gustavo",
            Idade = 29
        };

        DateTime dataAutal = DateTime.Now.AddDays(5);

        p.Apresentar();
        Console.Write(dataAutal.ToString("dd/MM/yyyy"));
    }
}