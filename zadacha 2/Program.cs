namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Ne davalite mnogo golemi shisla(Ako iskate)");
            Console.Write("Chislo a; ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Chislo b: ");
            int B = int.Parse(Console.ReadLine());

          
            List<int> oddNumbers = new List<int>();

           
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

           
            for (int i = A; i <= B; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }

           
            Console.WriteLine(string.Join(" ", oddNumbers));


        }
    }
}