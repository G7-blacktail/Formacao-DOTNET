
using operadoresaritmeticos.Moldels;

Calculadora calc = new();

calc.Somar(10, 30);
calc.Subtrair(10, 5);
calc.Multiplicar(2, 5);
calc.Dividir(50, 2);
calc.Potencia(3, 3);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

int numero = 10;
    Console.WriteLine(numero);
    Console.WriteLine("Incrementando o 10");
numero++;
    Console.WriteLine(numero);
    Console.WriteLine("Decrementando o 10");
numero--;
    Console.WriteLine(numero);

calc.RaizQuadrada(9);