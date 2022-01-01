using System;
namespace laba_4444_2_
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть одновимiрних масивiв для цiлих i дiйсних чисел: ");
            int size = Convert.ToInt32(Console.ReadLine());
            float maxaverage = 0;
            for (int i = 0; i < size; i++)
            {
                IntArray intarray = new IntArray();
                intarray.GetSize();
                Console.WriteLine("Введiть масив цiлих чисел");
                intarray.Input();
                intarray.Output();
                Console.Write("Для збiльшеня кожного елемента на 1 введiть << + >>, для зменьшення << - >> : ");
                string znak = Console.ReadLine();
                switch (znak)
                {
                    case "+":
                        intarray.TotalIncrement();
                        intarray.Output();
                        break;
                    case "-":
                        intarray.TotalDecrement();
                        intarray.Output();
                        break;
                }
                Console.Write("Середне арифметичне: "+ intarray.Average());
                Console.WriteLine();
                if (maxaverage < intarray.Average())
                {
                    maxaverage = intarray.Average();
                }
            }
            Console.WriteLine("Найбiльше середне арифметичне серед цiлих масивiв : "+ maxaverage);
            maxaverage = 0;

            for (int i = 0; i < size; i++)
            {
                FloatArray floatarray = new FloatArray();
                floatarray.GetSize();
                Console.WriteLine("Введiть масив дiйсних чисел");
                floatarray.Input();
                floatarray.Output();
                Console.Write("Для збiльшеня кожного елемента на 1 введiть << + >>, для зменьшення << - >> : ");
                string znak2 = Console.ReadLine();
                switch (znak2)
                {
                    case "+":
                        floatarray.TotalIncrement();
                        floatarray.Output();
                        break;
                    case "-":
                        floatarray.TotalDecrement();
                        floatarray.Output();
                        break;
                }
                Console.WriteLine("Середне арифметичне: " + floatarray.Average());
                if (maxaverage < floatarray.Average())
                {
                    maxaverage = floatarray.Average();
                }
            }
            Console.Write("Найбiльше середне арифметичне серед цiлих масивiв : " + maxaverage);
        } 
    }
}