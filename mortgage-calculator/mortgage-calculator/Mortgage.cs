using System;
using System.Collections.Generic;
using System.Text;

namespace mortgage_calculator
{
    public class Mortgage
    {
        public double principle;
        public double interest;
        public int term;
        public int period;

        public Mortgage(double p, double i, int t, int pe)
        {
            principle = p;
            interest = i;
            term = t;
            period = pe;
        }

        public double Calculate()
        {
            double rate = interest / 100 / 12;
            double loan = principle;
            double terM = Convert.ToDouble(term * 12);
            double multiplyer = Convert.ToDouble(period);

            double periodPayment = loan * (rate * Math.Pow((1 + rate), terM) / (Math.Pow((1 + rate), terM) - 1));
            double result = Math.Round(periodPayment, 2) * 12 / multiplyer;
            //Console.WriteLine($"RATE: {rate}\r\nLOAN: {loan}\r\nRESULT: {result}");
            return Math.Round(result, 2);
        }

        public double MonthlyInterestRate(double interest, int period)
        {
            return interest / 100 / period;
        }

        public int NumberOfPayments(int term, int period)
        {
            return period * term;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
            double result = Math.Pow((1 + monthlyInterestRate), numberOfPayments);
            return result;
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {
            double result = (monthlyInterestRate * numberOfPayments) * (1 - compoundedInterestRate);
            return Math.Abs(result);
        }
    }
}
