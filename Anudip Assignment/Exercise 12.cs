using System

    namespace Exercise12
{
    internal class program
    {
        static void main(string[] args);
        {
           Console.WriteLine("Enter a number");
            int num = convert.ToInt32(Console.ReadLine());
        If(num< 0 || num> 15)
        {
            Console.WriteLine("wrong number");
        }
        else if(num >=0 && num< 1o)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("Answer is not correct");
        }
    }
}