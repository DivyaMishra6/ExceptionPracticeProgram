namespace ExceptionPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            PersonAge personage = new PersonAge();
            personage.GetCategory(age);
        }
    }
}