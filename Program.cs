

using System.Reflection.PortableExecutable;

int opc;
Console.WriteLine("Insira o codigo do desafio a ser executado:");
opc = Int32.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        Console.WriteLine("Insira um nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira uma mensagem:");
        string msg = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! {msg}!");
        break;

    case 2:
        Console.WriteLine("Insira um nome:");
        string firstname = Console.ReadLine();
        Console.WriteLine("Insira um sobernome:");
        string lastname = Console.ReadLine();
        Console.WriteLine(string.Join(" ", firstname, lastname));
        break;

    case 3:
        Console.WriteLine("Insira um valor:");
        double number1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Insira outro valor:");
        double number2 = Double.Parse(Console.ReadLine()); ;
        double soma = number1 + number2;
        Console.WriteLine($"Soma: {soma}");
        double subt = number1 - number2;
        Console.WriteLine($"Subtração: {subt}");
        double multi = number1 * number2;
        Console.WriteLine($"Multiplicação: {multi}");
        if (number2 != 0)
        {
            double divisao = number1/ number2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        else{
            Console.WriteLine("A divisão não pode ser realizada!");
        }
        double media = (number1 + number2) / 2;
        Console.WriteLine($"Média: {media}");
        break;

    case 4:
        Console.WriteLine("Insira uma ou mais palavras:");
        string palavra = Console.ReadLine();
        int contaChar = 0;
        for (int i = 0; i < palavra.Length; i++)
        {
            if (palavra[i] != ' ')
            {
                contaChar++;
            }
        }
        Console.WriteLine($"A palavra tem {contaChar} caracteres!");
        break;

    case 5:
        Console.WriteLine("Insira uma placa de Veiculo:");
        string placa = Console.ReadLine();
        if (placa.Length==7)
        {
            string letras = placa.Substring(0, 3);
            string numeros = placa.Substring(3);
            if (letras.All(char.IsLetter) && numeros.All(char.IsDigit))
            {
                Console.WriteLine("A placa informada é válida!");
            }
            else
            {
                Console.WriteLine("A placa informada não é válida!");
            }
        }
        else
        {
            Console.WriteLine("A placa informada não é válida!");
        }
        break;

    case 6:

        break;
    
};
