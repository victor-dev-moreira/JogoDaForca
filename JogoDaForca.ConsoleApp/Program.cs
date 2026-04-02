/*
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.

*/


using System.Security.Cryptography;

string[] palavrasCompletas = [
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            ];



bool desejaContinuar = true;

while (desejaContinuar)
{

    int indiceAleatorio = RandomNumberGenerator.GetInt32(palavrasCompletas.Length);
    Console.WriteLine("-----------------");
    Console.WriteLine("Jogo Da Forca");
    Console.WriteLine("-----------------");
    Console.WriteLine();
    Console.WriteLine();


    string palavraAleatoria = palavrasCompletas[indiceAleatorio];
    char[] palavras = new char[palavraAleatoria.Length];
    string cabeca = "|                 ";
    string torso = "|                 ";
    string pernas = "|                 ";
    int tentativasErradas = 0;



    for (int i = 0; i < palavras.Length; i++)
    {
        palavras[i] = '-';

    }

    bool forca = true;
    while (forca)
    {

        Console.Clear();
        Console.WriteLine("|------------------");
        Console.WriteLine("|/                |");
        Console.WriteLine("|                 |");
        Console.WriteLine(cabeca);
        Console.WriteLine(torso);
        Console.WriteLine(pernas);
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.WriteLine("|----------");
        Console.WriteLine($"Você Errou {tentativasErradas} vezes");

        char letra;
        Console.Write("                    " + string.Join("", palavras));
        Console.Write("\nDigite uma letra: ");
        letra = char.Parse(Console.ReadLine().ToUpper());
        Console.Clear();


        bool diferenteDeTodos = false;
        for (int i = 0; i < palavraAleatoria.Length; i++)
        {
            if (palavraAleatoria[i] == letra)
            {
                palavras[i] = palavraAleatoria[i];
                diferenteDeTodos = true;
            }
        }

        string palavraCompleta = string.Join("", palavras);
        if (palavraAleatoria == palavraCompleta)
        {
            Console.Clear();
            Console.WriteLine("|------------------");
            Console.WriteLine("|/                |");
            Console.WriteLine("|                 |");
            Console.WriteLine(cabeca);
            Console.WriteLine(torso);
            Console.WriteLine(pernas);
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|----------");
            Console.WriteLine($"Você Errou {tentativasErradas} vezes");
            Console.WriteLine("                    " + string.Join("", palavras));
            Console.WriteLine("------------------");
            Console.WriteLine("Você ganhou, a palavra é " + string.Join("", palavras));
            forca = false;
            break;
        }

        if (!diferenteDeTodos)
        {
            tentativasErradas++;
            if (tentativasErradas == 1)
            {
                cabeca = "|                 O";
            }
            else if (tentativasErradas == 2)
            {
                torso = "|                /X";
            }
            else if (tentativasErradas == 3)
            {
                torso = @"|                /X\";
            }
            else if (tentativasErradas == 4)
            {
                pernas = "|                /";
            }
            else
            {
                pernas = @"|                / \";
                Console.WriteLine("Você perdeu pressione enter para tentar novamente...");
                Console.ReadLine();
                forca = false;
            }
        }


    }


    Console.WriteLine("-----------------");
    Console.WriteLine("Deseja Continuar? (S/N)");
    string continua = Console.ReadLine().ToUpper();
    if (continua == "S")
    {
        Console.WriteLine("Perfeito, vamos lá!");

    }
    else
    {
        Console.WriteLine("Você parou por aqui!");
        Console.ReadLine();
        desejaContinuar = false;
    }
}