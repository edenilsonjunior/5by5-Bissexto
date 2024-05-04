namespace Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p;

            Console.WriteLine("=====Idade em bissextos=====");
            
            Console.Write("Digite o nome: ");
            string? nome = Console.ReadLine();

            bool resultadoTry;
            int idade;
            do
            {
                Console.Write("Digite a idade: ");
                resultadoTry = int.TryParse(Console.ReadLine(), out idade);

                if (!resultadoTry)
                    Console.WriteLine("Voce deve digitar um numero!");
                else if(idade < 0)
                    Console.WriteLine("Voce deve digitar uma idade maior que zero!");
                
            } while (!resultadoTry || idade < 0);
            
            Console.Write("Digite a profissao: ");
            string? profissao = Console.ReadLine();

            p = new Pessoa(nome, idade, profissao);

            Console.WriteLine("=====================");
            Console.WriteLine(p.ToString());
            Console.WriteLine($"Idade em ano bissextos: {p.GetIdadeEmBissexto()}");
        }
    }
}
