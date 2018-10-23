using System;
using Xunit;
using Mycalculator;

namespace CalculTest
{
    public class UnitTest1
    {

        [Fact]
        public void Median1()
        {
            double[] array = new double[] { 2, 4, 6, 8 };
            var Calculo = new Mycalculator.Calculations();
            double median = Calculo.Median(array);
            double truevalue = 5;
            Assert.Equal(truevalue, median);
        }
        [Fact]
        public void Mean1()
        {
            double[] array = new double[] { 2, 4, 6, 8, 10, 15 };
            var Calculo = new Mycalculator.Calculations();
            double mean = Calculo.Mean(array);
            double truevalue = 7.5;
            Assert.Equal(truevalue, mean, 2);
        }
    }
}

