namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            test();
        }
        static void test()
        {
            bool inrange = false;
            Console.WriteLine("enter a number");
            int test = Convert.ToInt32(Console.ReadLine());
            while(inrange==false)
            {
                if (test > 0 && test < 10)
                {
                    Console.WriteLine("within range");
                    inrange = true;
                }
                else
                {
                    Console.WriteLine("not within range");
                    inrange = false;
                    break;
                }
            }
        }
    }
}
