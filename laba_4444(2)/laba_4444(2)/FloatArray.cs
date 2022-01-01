using System;
using System.Collections.Generic;
using System.Text;

namespace laba_4444_2_
{
    class FloatArray : TArray
    {
        private float[] array;
        public FloatArray(float[] array)
        {
            this.array = array;
        }
        public FloatArray()
        {
            this.array = new float[5];
        }
        public override float Average()
        {
            float size = GetSize();
            float sum = 0;
            for (int i = 0; i < size; i++)
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
                array[i] = Convert.ToSingle(Console.ReadLine());
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
