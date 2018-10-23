using System;



namespace Mycalculator
{
    public class Calculations
    {
        // Square function 
        public int Square(int num)
        {
            return num * num;
        }
        // Add two integers and returns the sum
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        // Add two doubles and returns the sum
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        // Multiply two integers and retuns the result
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Subtracts small number from big number
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }

        public double Mean(double[] array)
        {
            double total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];//count to get all the sum of the arrays 
            }
            total = total / array.Length;//the total would be the total numbers divided by the size of the array 

            return total;
        }
        public double Median(double[] array)
        {
            double[] sortedarray = array;//sorts the array in order to find the median 
            Array.Sort(sortedarray);

            //finding the median value 
            int size = sortedarray.Length;
            int mid = size / 2;
            if (size % 2 != 0)// if the middle is perfect, return it 
                return sortedarray[mid];

            double value1 = sortedarray[mid];  //what about if i put int or double 
            double value2 = sortedarray[mid - 1];
            double value3 = sortedarray[mid] + value2 * 0.5;
            return (value3);
        }
    }
}

