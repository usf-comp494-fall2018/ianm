using System;
using Mycalculator;
using System.IO;


namespace Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            //Open file, read into an array
            StreamReader read = File.OpenText("CalcInput.txt");
            double[] number = new double[File.ReadAllLines("CalcInput.txt").Length];

            // read all the numbers on the text until there is no more
            while (!read.EndOfStream)
            {
                number[count] = double.Parse(read.ReadLine());
                count++;
            }
            //Initialize calculator, call Mean and Median functions
            Calculations calc = new Calculations();
            double mean = calc.Mean(number);
            double median = calc.Median(number);

            //cout in the console 
            Console.WriteLine("==================");
            Console.WriteLine("Mean value is: " + mean);
            Console.WriteLine("==================");
            Console.WriteLine("Median value is:  " + median);
            Console.WriteLine("===================");

            //Cout in the file 
            StreamWriter writeOut = new StreamWriter("CalcOutput.txt");
            writeOut.WriteLine("==================");
            writeOut.WriteLine("The mean of the values is: " + mean);
            writeOut.WriteLine("==================");
            writeOut.WriteLine("The median of the values is: " + median);
            writeOut.Close();
        }
    }
}
