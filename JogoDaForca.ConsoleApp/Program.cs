/*
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.

*/


Console.WriteLine("-----------------");
Console.WriteLine("Jogo Da Forca");
Console.WriteLine("-----------------");
Console.WriteLine();
Console.WriteLine();

char[] palavras = new char[7];
string palavraAleatoria = "ABACATE";

for (int i = 0; i < palavras.Length; i++)
{
    palavras[i] = '-';

}

while (true)
{

    Console.WriteLine("|------------------");
    Console.WriteLine("|                |");
    Console.WriteLine("|                |");
    Console.WriteLine("|                |");
    Console.WriteLine("|");
    Console.WriteLine("|");
    Console.WriteLine("|");
    Console.WriteLine("|");
    Console.WriteLine("|----------");

    //         o
    //        /X\
    //        / \
    Console.Write("                    " + string.Join("", palavras));
    Console.Write("\nDigite uma letra: ");
    char letra = char.Parse(Console.ReadLine());
    Console.Clear();

    for (int i = 0; i < palavraAleatoria.Length; i++)
    {
        if (palavraAleatoria[i] == letra)
        {
            palavras[i] = palavraAleatoria[i];
        }

    }


}



