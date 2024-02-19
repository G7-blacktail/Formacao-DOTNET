// convertendo tipos de variavies

// Casting
int a = Convert.ToInt32("5"); // Convertando para int

// Usando o Parse
int b = int.Parse("10");

    Console.WriteLine(a);
    Console.WriteLine(b);

    // Qual a diferença entre os dois: tratamento de valores nulos

int c = Convert.ToInt32(null);
    Console.WriteLine(c);

//int d = int.Parse(null); 
//aqui o nulo acarretará em um erro!
    //Console.WriteLine(d);

// convertentdo para string
string ConvertToString = Convert.ToString(5);
    Console.WriteLine(ConvertToString); // para fazer cast para string não existe Parse

// Usando o ToString()
int NumeroInteiro = 25;
string UsandoToString = NumeroInteiro.ToString();
    Console.WriteLine(UsandoToString);

    // assim como no Java existe o cast Implicito quando a váriavel cabe no tipo que ela esta sendo atribuida
int InteiroCastImplicito = 5;
double Implicito = InteiroCastImplicito;
    Console.WriteLine(Implicito);

int ValorMaximo = int.MaxValue;
long castingImplicito = ValorMaximo;
    Console.WriteLine(castingImplicito);


// Ordem dos operadores
/*
    Parenteses
    Divisão
    Multiplicação
    Adição
    Subtração
*/

// Converção segura

string palavra = "15-";
int valorDefatul;
int.TryParse(palavra, out valorDefatul);

    Console.WriteLine(valorDefatul);
    Console.WriteLine("Conversão realizada com sucesso.");


// Operadores condicionais

int quantidadeEmEstoque = 10;
int QuantidadeCompra = 5;
bool possivelVenda = QuantidadeCompra > 0 && quantidadeEmEstoque >= QuantidadeCompra;

    if(QuantidadeCompra == 0)
    {
        Console.WriteLine("Compra inválida");
    }
    else if(possivelVenda)
    {
        Console.WriteLine("Venda realizada");
        quantidadeEmEstoque -= QuantidadeCompra;
        Console.WriteLine($"Temos agora em estoque: {quantidadeEmEstoque}");
    }
    else
    {
        Console.WriteLine("Nâo temos em estoque");
        Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
    }

    Console.WriteLine("\n-------------------------------------------------");

    Console.WriteLine("Digite uma letra: ");
    string letra = Console.ReadLine();

    switch(letra)
    {
        case "a" :
        case "e" :
        case "i" :
        case "o" :
        case "u": 
            Console.WriteLine($"A letra {letra} é uma vogal");
            break;
            
        default :
            Console.WriteLine($"A letra {letra} não é uma vogal");
            break;
    }

    Console.WriteLine("\n-------------------------------------------------");

// Operadores lógicos

// OR ||
string NomeCliente = "Helena";
int IdadeCliente = 20;
bool autorizacaoCliente = false;

    if(IdadeCliente >= 18 || autorizacaoCliente)
    {
        Console.WriteLine($"O clinete {NomeCliente} poderá ir ao passeio");
    }
    else
    {
        Console.WriteLine($"O cliente {NomeCliente} não poderá ir ao passeio");
    }

    Console.WriteLine("\n-------------------------------------------------");
// And &&

    int presencaAluno = 100;
    string NomeAluno = "Gustavo";
    double NotaAluno = 9.58;

    if (presencaAluno >= 70 && NotaAluno >= 7)
    {
        Console.WriteLine($"Aprovado");
    }
    else
    {
        Console.WriteLine($"O aluno {NomeAluno} foi reprovado");
        if(presencaAluno < 70)
        {
            Console.WriteLine("Foi reprovado por faltas");
        }

        if(NotaAluno < 7)
        {
            Console.WriteLine("Foi reprovado por nota");
        }
    }
        Console.WriteLine("\n-------------------------------------------------");
// NOT !

bool chovendo = false;
bool estaTarde = false;

if(!chovendo && !estaTarde)
{
    Console.WriteLine("Vou Pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}