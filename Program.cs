namespace reversednumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseNumber(number);
            Console.WriteLine($"The reverse of {number} is {reversedNumber}.");
        }

        static int ReverseNumber(int num)
        {
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10; 
                reversed = reversed * 10 + digit; 
                num /= 10; 
            }

            return reversed;
        }
    }
}
