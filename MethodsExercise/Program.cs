namespace MethodsExercise
{
    public class Program
    {

        public static void InfoGather()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();
            
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine("What is your favorite code language?");    
            string favLanguage = Console.ReadLine();
            
            Console.WriteLine($"Hello {name}, Your favorite color is {favColor}, your favorite animal is a {favAnimal}," +
                              $" and your favorite language is {favLanguage}!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int divide(int a, int b)
        {
            return a / b;
        }
        
        
        
        static void Main(string[] args)
        {
            InfoGather();
            
            
            
        }
    }
}
