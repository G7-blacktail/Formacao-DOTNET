
// int numero = 5;
// for(int i = 0; i <= 10; i++ )
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// // do while

// int soma = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// }while(numero != 0);


// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// Console.WriteLine("\n-------------------------------------------------------\n");

// Menu simples

string opcao;
bool exibir = true;

while(exibir)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente ");
    Console.WriteLine("2 - Buscar cliente    ");
    Console.WriteLine("3 - Apagar Cliente    ");
    Console.WriteLine("4 - Encerrar          ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar registro de cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar programa");
            // Environment.Exit(0);
            exibir = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
    
}