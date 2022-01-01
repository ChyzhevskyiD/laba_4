using System;
using System.Collections.Generic;
using System.Text;

namespace laba_4444_2_
{
    class IntArray : TArray
    {
        private int[] array;
        public IntArray(int[] array)
        {
            this.array = array;
        }
        public IntArray()
        {
            this.array = new int[5];
        }
        public override float Average()
        {
            float size = GetSize();
            float sum = 0;
            for(int i=0; i<size;i++)
            {
                sum += array[i];
            }
            return sum / size;
        }

        public override int GetSize()
        {
            return array.GetLength(0);
        }

        public override void Input()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public override void Output()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }

        public override void TotalDecrement()
        {
            int size = GetSize();
            for (int i = 0; i < size; i++)
            {
                array[i]--;
            }
            return;
        }

        public override void TotalIncrement()
        {
            int size = GetSize();
            for (int i = 0; i < size; i++)
            {
                array[i]++;
            }
            return;
        }
    }
}
