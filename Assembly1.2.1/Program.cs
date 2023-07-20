namespace Assembly1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva quatro números");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3 && number1 >= number4)
            {
                Console.WriteLine($"O número maior é o {number1}");
            }
            else if (number2 >= number1 && number2 >= number3 && number2 >= number4)
            {
                Console.WriteLine($"O número maior é o {number2}");

            }
            else if (number3 >= number1 && number3 >= number2 && number3 >= number4)
            {
                Console.WriteLine($"O número maior é o: {number3}");

            }
            else
            {
                Console.WriteLine($"O número ´maior é o: {number4}");
            }

        }
    }
}