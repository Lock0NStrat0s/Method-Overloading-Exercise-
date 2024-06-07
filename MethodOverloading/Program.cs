namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3.3m, 5.5m));
            Console.WriteLine(Add(1, 0, true));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool flag)
        {
            string dollars = a + b == 1 ? " dollar" : " dollars";
            return flag ? $"{a + b}{dollars}" : $"{a + b}";
        }
    }
}
