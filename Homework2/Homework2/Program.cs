using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Looking for Waldo in the array");
            string[] names = { "Tom", "Bob", "Dana", "Julie", "Sarah", "Fred", "Waldo", "Jenny", "Cathy" };
            for(int i=0;i<names.Length;i++)
            {
                if (names[i] == "Waldo")
                    break;
                count++;
            }
            if (count == names.Length)
                Console.WriteLine("Waldo couldn't be found");
            else
                Console.WriteLine("Waldo has been found In position " + count);

        }
    }
}
