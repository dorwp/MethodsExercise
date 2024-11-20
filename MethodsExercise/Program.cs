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

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Sum(params int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        
        
        static void Main(string[] args)
        {
            //Exercise 1
            InfoGather();
            
            //Exercise 2
            Console.WriteLine(Add(99,1));
            Console.WriteLine(Subtract(10,9));
            Console.WriteLine(Multiply(10,10));
            Console.WriteLine(Divide(99,11));
            
            //Params
            Console.WriteLine(Sum(100,10,23,43,3,6,87,1,34,567));
            
        }
    }
}
