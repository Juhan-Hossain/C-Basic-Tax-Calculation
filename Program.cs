using System;

namespace TaxCalculation
{

    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            Console.WriteLine("What is your yearly income? ");

            // Store income from user
            double grossIncome = Double.Parse(Console.ReadLine());
            Console.WriteLine("What is your TaxPayer Type? ");
            Console.WriteLine("Choose Between Freedom_Fighter,Disabled,Old,Woman:");
            string taxPayerType = Console.ReadLine();
            Console.WriteLine("Write down your yearly bonus amount: ");
            double bonus = Double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");


            double taxFreeAmount = TaxFreeAmount(taxPayerType);
            double taxAbleAmount = TaxableAmount.taxAmount(grossIncome);
            taxAbleAmount += bonus;
            double roughTax = TaxPayer.taxCalculation(taxFreeAmount, taxAbleAmount);
            double allowableInvestment = taxAbleAmount * 0.25;
            double taxcredit = TaxPayer.taxCredit(allowableInvestment);


            double finalTax = roughTax - taxcredit;
            if (finalTax <= 0) finalTax = 5000;

            Console.WriteLine("Your Total Taxable: " + taxAbleAmount);
            Console.WriteLine("Yearly Tax has to be paid: " + finalTax);


            Console.WriteLine("your Allowable Investment like Insurance or sharemarket: " + allowableInvestment);



            Console.WriteLine("Yearly Tax Credit from Allowable Investment: " + taxcredit);
            Console.WriteLine("------------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You take home: " + (grossIncome - finalTax + bonus));
            Console.ResetColor();

            // Wait for user to end program
            Console.ReadKey();

        }


        public static double TaxFreeAmount(string type)
        {
            switch (type)
            {
                case ("Freedom_Fighter"):
                    return 450000;
                case ("Disabled"):
                    return 400000;
                case ("Old"):
                    return 350000;
                case ("Woman"):
                default:
                    return 300000;
            }
        }


        static void PrintWelcomeMessage()
        {
            // String interpolation
            string version = "0.0.1";
            string author = "JUHAN";
            string email = "Juhan.Hossain@Brainstation-23.com";

            Console.ForegroundColor = ConsoleColor.Blue;
            // Intro text
            Console.WriteLine("Welcome to my BD tax calculator");
            Console.WriteLine($"author: {author}, version: {version}, email: {email} \n");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }

    }

}
