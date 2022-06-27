namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int numeroInserito;
            int somma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                somma += numeroInserito;
            }
            Console.WriteLine(somma);
        }
    }
}