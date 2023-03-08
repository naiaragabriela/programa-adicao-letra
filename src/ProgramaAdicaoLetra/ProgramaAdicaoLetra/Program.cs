

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();


string nome = palavra.ToLower();
string codigo = " ";

for (int i = 0; i < nome.Length; i++)
{
    if (char.IsLetter(nome[i]))
    {

        switch (nome[i])
        {
            case 'a': 
                codigo += nome[i];
                
                break;
            case 'e':
                codigo += nome[i];
                break;
            case 'i':
                codigo += nome[i];
                break;
            case 'o':
                codigo += nome[i];
                break;
            case 'u':
                codigo += nome[i];
                break;
            default:
                codigo += ("p"+ (nome[i]));
                
                break;
        }

    }

}
Console.WriteLine(codigo);

