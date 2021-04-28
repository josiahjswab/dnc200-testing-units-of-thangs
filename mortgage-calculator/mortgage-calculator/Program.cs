using System;
using System.Text.RegularExpressions;

namespace mortgage_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage;
            double principle, interestRate;
            int term, period;
            // Use .WriteLine to greet the user
            Console.WriteLine("Hello User");
            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)
            Console.WriteLine("What is your loan amount?");
            string loan, rate, terM, paymentFrequency;
            loan = Console.ReadLine();
            string parsedLoan = Regex.Replace(loan, "[^0-9]", "");
            principle = Convert.ToDouble(parsedLoan);
            // Console.Clear();

            Console.WriteLine($"LOAN AMOUNT: {parsedLoan}");
            Console.WriteLine("What is your intrest rate?");
            rate = Console.ReadLine();
            string parsedRate = Regex.Replace(rate, "[^0-9 + . + ,]", "");
            interestRate = Convert.ToDouble(parsedRate);
            Console.WriteLine($"DEV: INTREST RATE: {interestRate}");
            // Console.Clear();

            Console.WriteLine($"LOAN AMOUNT: {parsedLoan} \r\nINTREST RATE : {parsedRate} ");
            Console.WriteLine("How many years is your mortgage?");
            terM = Console.ReadLine();
            string parsedTerm = Regex.Replace(terM, "[^0-9 + . + ,]", "");
            term = Convert.ToInt32(parsedTerm);
            // Console.Clear();

            Console.WriteLine($"LOAN AMOUNT: {parsedLoan} \r\nINTREST RATE : {parsedRate} \r\nMORTGAGE TERM: {parsedTerm}");
            Console.WriteLine("How many payments per year would you like to make?");
            paymentFrequency = Console.ReadLine();
            string parsedPaymentFrequency = Regex.Replace(terM, "[^0-9 + . + ,]", "");
            period = Convert.ToInt32(parsedPaymentFrequency);
            // Console.Clear();
            // Create a new Mortgage with the given attributes;
            mortgage = new Mortgage(principle, interestRate, term, period);
            Console.WriteLine($"{mortgage.Calculate()}");
            
        }
    }
}
