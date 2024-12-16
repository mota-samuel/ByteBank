Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaArray();
void TestaArray()
{
    int[] idade = { 30, 40, 17, 21, 18 };
    Console.WriteLine($"O tamanho do array de idade é: {idade.Length}");
    
    int total =0;
    for (int i = 0; i < idade.Length; i++)
    {
        total += idade[i];
    }
    double media = total / idade.Length;
    Console.WriteLine($"A média das idades é: {media}");
}
BuscaPalavras();
void BuscaPalavras()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite a palavra da posicao: {i+1}");
        arrayDePalavras[i] = Console.ReadLine()!;
    }

    Console.WriteLine("Agora vamos encontrar uma palavra");
    Console.Write("Digite a palavra que deseja encontrar:");
    string palavra = Console.ReadLine()!;

    for (int i = 0; i < arrayDePalavras.Length; i++) 
    {
        if(arrayDePalavras[i].Equals(palavra))
        {
            Console.WriteLine($"A palavra está na posicao: {i+1}");
        };
    }
}