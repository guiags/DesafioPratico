

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
        Console.WriteLine("1- Formato Completo;\n2- Apenas data;\n3- Apenas hora;\n4-Mês por extenso;");
        int timeopc = Int32.Parse(Console.ReadLine());
        DateTime hoje = DateTime.UtcNow;
        switch (timeopc)
        {
            case 1:
                Console.WriteLine(hoje.ToString("dddd dd/MM/yyyy HH:mm:ss"));
                break;
            case 2:
                Console.WriteLine(hoje.ToString("dd/MM/yyyy"));
                break;
            case 3:
                Console.WriteLine(hoje.ToString("HH:mm:ss"));
                break;
            case 4:
                Console.WriteLine(hoje.ToString("d MMMM yyyy")) ;
                break;

        };

        break;
    
};

/*1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  `**Olá, Welisson! Seja muito bem-vindo!**`

*Obs: veja que o método para ler os dados que um usuário digita não foi passado em aula.* 
O que acha de começar com a sua primeira busca? 🔍

Caso não encontre, vou deixar uma dica aqui embaixo! 
    - Dica 👀
        
        <aside>
        💡 O método para ler os dados que um usuário digita é o **`Console.ReadLine();`**
        
        </aside>
        
    
    ---
    
2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

    
    ---
    

1. Crie um programa com 2 valores do tipo `**double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.
    
    <aside>
    💡 Você pode ir além e permitir que o usuário insira dois números aleatórios!
    
    </aside>
    
    ---
    
2. Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

- Dica
    
    <aside>
    💡 Você pode fazer uma verificação e incrementar o contador apenas `**se**` for um caractere, ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
    
    </aside>
    

---

1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
    
    ---
    

1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.

*/
