

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();
Console.Write("Digite um caractere");
char letra = char.Parse(Console.ReadLine());


string nome = palavra.ToLower();
string codigo = " ";

for (int i = 0; i < nome.Length; i++)
{
    if (char.IsLetter(nome[i]))
    {

        switch (nome[i])
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'á':
            case 'é':
            case 'í':
            case 'ó':
            case 'ú':
                codigo += nome[i];
                break;
            default:
                codigo += letra + nome[i];

                break;
        }

    }

}
Console.WriteLine(codigo);

