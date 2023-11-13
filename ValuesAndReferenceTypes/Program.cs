namespace ValuesAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number1 = 1;
            int number2 = 2;

            number1= number2;
            number2 = 65;
            //number1 = 2
        }
    }
}