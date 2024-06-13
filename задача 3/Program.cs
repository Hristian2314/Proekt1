namespace задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();

            double grade = 0;

            int count2 = 0;

            int count6 = 0;

            for (int i = 0; i < 14; i++)
            {
                Console.Write($"Vuvedi ocenka na {i + 14}");

                grade = double.Parse(Console.ReadLine());

                list.Add(grade);

                if (grade >= 2 && grade < 3)
                {
                    count2++;
                }
                else if (grade >= 5.50 && grade <= 6) 
                {
                    count6++;
                }
            }
            Console.WriteLine($"ocenkata dvoiki sa {count2}");
            Console.WriteLine($"ocenkite 6-ci sa {count6}");

        }
    }
}