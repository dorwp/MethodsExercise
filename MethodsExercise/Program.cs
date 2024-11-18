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
        
        static void Main(string[] args)
        {
            InfoGather();
            
            
            
        }
    }
}
