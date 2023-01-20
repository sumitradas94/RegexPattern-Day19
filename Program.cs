namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Regestration Program by Regex");
            MethodStoring.ForFirstName();
            
            MethodStoring.ForLatName();

            MethodStoring.Foremail();
            MethodStoring.ForNumber();
        }

    }
}