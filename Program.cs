using System;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string specials = "!@#$%^&*()_+-=[]{}|;':\",./<>?";

        //Console.WriteLine("Github testing");

        // 1 st stage: random 12 number sequence
        StringBuilder password = new StringBuilder();
        Random random = new Random();
        char[] numbs = numbers.ToCharArray();

        //Stage 1
        //int length;
        System.Console.WriteLine("=== Secure Password Generator ===\n");
        System.Console.Write("Enter password length: ");

        try
        {
            int length = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                // pick a random index within the char array and append the char
                password.Append(numbs[random.Next(numbs.Length)]);
            }
            System.Console.WriteLine(password);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: you must write int numbers!\n");
        }
        catch (OverflowException)
        {
            System.Console.WriteLine("Error: number is too big!\n");
        }
        finally
        {
            System.Console.WriteLine("=================================");
        }
        
    }
}