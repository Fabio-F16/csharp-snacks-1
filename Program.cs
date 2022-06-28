namespace csharp_snacks_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inizio snack 12
            Console.WriteLine("inserisci un numero");
            int numero = Int32.Parse(Console.ReadLine());

            ePari(numero);

            void ePari(int numeroUtente)
            {
                if (numeroUtente % 2 == 0)
                {
                    Console.WriteLine("il numero " + numeroUtente + " è pari");
                }
                else
                {
                    Console.WriteLine("il numero " + numeroUtente + " è dispari");
                }
            }

            // fine snack 12

            return;
            // inizio snack 11
            string wordPrima;
            string wordSeconda;

            wordPrima = RichiediParola("Inserisci la prima parola:");
            wordSeconda = RichiediParola("Inserisci la seconda parola:");

            if(sonoLungheUguali(wordPrima, wordSeconda))
            {
                Console.WriteLine(wordPrima);
                Console.WriteLine(wordSeconda);
            }
            else
            {
                stampaPiuLunga(wordSeconda, wordPrima);
            }


            // funzioni
            bool sonoLungheUguali(string stringa1, string stringa2)
            {
                if(stringa1.Length == stringa2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            void stampaPiuLunga(string stringa1, string stringa2)
            {
                if (stringa1.Length > stringa2.Length)
                {
                    Console.WriteLine(stringa1);
                }
                if(stringa2.Length > stringa1.Length)
                {
                    Console.WriteLine(stringa2);
                }
            }

            string RichiediParola(string messaggio)
            {
                Console.Write(messaggio);
                string input = Console.ReadLine();
                return input;
            }

            // fine snack 11

            return;

            // inizio quarto esercizio snack10

            Console.Write("Scegli il numero di array: ");
            int N = Int32.Parse(Console.ReadLine());

            Random rnd = new Random();
           

            for (int i = 0; i < N; i++)
            {
                int[] arrayNumeri = new int[10];

                for (int j = 0; j < arrayNumeri.Length; j++)
                {
                    arrayNumeri[j] = rnd.Next(1, 101);

                    Console.Write(arrayNumeri[j] + ",");
                }
                Console.WriteLine();
            }
            // fine quarto esercizio snack10

            return;

            // inizio terzo esercizio snack5

            Console.WriteLine("Inserisci un numero");
            int numeroUtente = Convert.ToInt32(Console.ReadLine());

            if(numeroUtente % 2 == 0)
            {
                Console.WriteLine("il numero dell'utente è: " + numeroUtente);
            }
            else
            {
                numeroUtente++;
                Console.WriteLine("il numero dispari + 1 dell'utente è: " + numeroUtente);
            }


            // fine terzo esercizio snack5

            return;

            // secondo esercizio snack4
            int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            float average;
            for (int i = 0; i < numeri.Length; i++)
            {
                sum += numeri[i];
                
            }
            
            average = sum / numeri.Length;
            Console.WriteLine("la somma dei numeri è " + sum);
            Console.WriteLine("la media dei numeri è " + average);

            // fine secondo esercizio snack4

            return;

            // primo esercizio snack3
            int numeroInserito;
            int somma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                somma += numeroInserito;
            }
            Console.WriteLine("La somma dei numeri inseriti è: " + somma);
            // fine primo esercizio snack3 
        }
    }
}