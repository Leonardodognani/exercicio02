namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string lastName;
            Console.Write("Por favor, insira seu nome: ");
            Name = Console.ReadLine();

            Console.Write("Agora insira seu sobrenome: ");
            lastName = Console.ReadLine();

            Console.WriteLine(string.Format("Olá, meu nome é {0} {1}.", Name, lastName));


        }
    }
}
