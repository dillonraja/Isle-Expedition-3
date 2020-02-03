using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*******************");
        Console.WriteLine("Welcome to the Isle Expeditions Collection Guide!");

        while (true)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Look at loot tables");
            Console.WriteLine("3. Enemies list");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting the bank!");
                    return;
                case "1":
                    Console.Write("Account name: ");
                    var accountName = Console.ReadLine();

                    Console.WriteLine("Email Address: ");
                    var emailAddress = Console.ReadLine();
             

                    Console.Write("Amount to deposit: ");
                    var amount = Convert.ToDecimal(Console.ReadLine());

                   


                    break;
                case "2":

             
                default:
                    Console.WriteLine("Invalid option! Try again!");
                    break;
            }
        }

    }
}
