class Teste
{
    static void Main(string[] args)
    {
        List<char> vogais = new List<char> { 'a','e', 'i', 'o', 'u' };

        string banana = "banana";

        int quantidadeDeVogais = banana.Count(vogais.Contains);

        IEnumerable<char> vogaisUnicas = banana.Distinct().Where(vogais.Contains);

        Console.WriteLine($"A palavra {banana} contém {quantidadeDeVogais} vogais");
        Console.WriteLine("As vogais que contém são:");
        foreach(char vogal in vogaisUnicas)
        {
            Console.WriteLine(vogal);
        }

        string?[] vet = Console.ReadLine().Split(' ');

        string p1 = vet[0];
        string p2 = vet[1];
        string p3 = vet[2];

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
    }
}