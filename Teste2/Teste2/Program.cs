using System.Globalization;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um int, char e double, respectivamente:");
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(d.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite um nome, sexo (m ou f), idade e altura, respectivamente na mesma linha separados por ',':");
            string[] vet = Console.ReadLine().Split(',');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);   

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}