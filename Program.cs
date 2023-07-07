using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        int lenght = 12;
        Console.WriteLine(randPassword(lenght));
    }
    static char[] randPassword(int lenght)
    {
        Console.WriteLine("Generating password using random");
        Console.Write("Your new password will be: ");
        string CapitalChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string SmallChars = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";
        string symbols = "!?*+-";
        string values = CapitalChars + SmallChars + numbers + symbols;
        Random rand = new Random();
        char[] password = new char[lenght];
        for (int i =0; i  < lenght; i++)
        {
            password[i] = values[(rand.Next(values.Length))];
        }
        return password;
    }
}