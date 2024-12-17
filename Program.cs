namespace PassWord_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Password Checker Kiddo!\n...\t...\t...\t..\t..\t..\t..");
            while (true)
            {
                Console.Write("Enter Password: ");
                String password = Console.ReadLine();
                if (String.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Please Insert Your Password.\n");
                    continue;
                }

                Console.Write("Confirm Password: ");
                string password_check = Console.ReadLine();
                if (String.IsNullOrEmpty(password_check))
                {
                    Console.WriteLine("Confirm Password Section Cannot Be Empty.\n");
                    continue;
                }

                if (!password.Equals(password_check))
                {
                    Console.WriteLine("Passwords don't match. Try again.\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("Passwords matched! You may proceed...\n");
                    break;
                }
            }
            Console.WriteLine("Thank you for using Password Checker!\n");
            Console.ReadLine();
        }
    }
}
