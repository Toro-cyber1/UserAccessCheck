using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!;

        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;

        Console.Write("Enter user ID: ");
        uint userId = uint.Parse(Console.ReadLine()!);

        bool userIsAdmin   = userId > 65536;
        bool usernameValid = username.Length >= 3;

        bool containsSpecial = password.Contains('$') || password.Contains('|') || password.Contains('@');
        bool rightLength     = (userIsAdmin && password.Length >= 20) || (!userIsAdmin && password.Length >= 16);
        bool passwordValid   = containsSpecial && rightLength;

        if (usernameValid && passwordValid)
        {
            Console.WriteLine("Access granted.");
        }
        else
        {
            Console.WriteLine("Access denied.");
            if (!usernameValid)  Console.WriteLine("Username must be at least 3 characters.");
            if (!passwordValid)
            {
                Console.WriteLine("Password must contain $, | or @.");
                Console.WriteLine(userIsAdmin
                    ? "Password must be at least 20 characters for an admin."
                    : "Password must be at least 16 characters for a non-admin.");
            }
        }
    }
}