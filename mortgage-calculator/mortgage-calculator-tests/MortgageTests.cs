using System;
using Xunit;
using mortgage_calculator;

namespace MyFirstUnitTests
{
    public class MortgageTests
    {
        static double p = 1000;
        static double i = 1;
        static int t = 12;
        static int pe = 10;

        Mortgage mortgage = new Mortgage(p, i, t, pe);

        [Fact]
        public void CalculateTest()
        {
            double result = 8.84;

            Assert.Equal(result, mortgage.Calculate());
        }

        [Fact]
        public void MonthlyInterestRateTest()
        {
            double result = .0001;
            Assert.Equal(result, mortgage.MonthlyInterestRate(i, pe));
        }

        [Fact]
        public void NumberOfPaymentsTest()
        {
            double result = 120;
            Assert.Equal(result, mortgage.NumberOfPayments(t, pe));
        }

        [Fact]
        public void CompoundedInterestRateTest()
        {
            double result = 120.01;
            Assert.Equal(result, Math.Round(mortgage.CompoundedInterestRate(.0001, 120), 2));
        }
    }
}
