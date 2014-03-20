using System;

class PrintCompanyInformation
{
    //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
    //age and a phone number. Write a program that reads the information about a company and its manager and prints it back 
    //on the console.
    static void Main(string[] args)
    {
        Console.WriteLine("Company name:");
        string name = Console.ReadLine();
        Console.WriteLine("Company address:");
        string address = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phone = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string fax = Console.ReadLine();
        Console.WriteLine("Web site:");
        string web = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhone = Console.ReadLine();

        string text = "(no fax)";
        bool isFax = String.IsNullOrEmpty(fax);
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}", name, address, phone, isFax ? text : fax, web);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
        
    }
}

