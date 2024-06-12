
class GuessPassword {
    public static void Main (String[]args)
    {

        string password = Console.ReadLine();
        
        
        if (password=="s3cr3t!") {
            Console.WriteLine("Welcome");

        }else {
            Console.WriteLine("Wrong password!");
        }
    }
}