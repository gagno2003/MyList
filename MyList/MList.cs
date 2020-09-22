using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MList<T>
    {
        T[] arr = new T[1];
        int number;
        public void Add(T add)
        {
            if (number == arr.Length)
            {
                Array.Resize<T>(ref arr, arr.Length + 1);
            }
            arr[number++] = add;
        }

        public int Count()
        {
            return arr.Length;
        }

        public T GetElement(int number)
        {
            return arr[number];
        }
        
        public void Clear()
        {
            Array.Resize<T>(ref arr, 0);
            number = 0;
        }

        public bool Contains(T element)
        {
            foreach (var item in arr)
            {
                if (item.Equals(element))
                {
                    return true;
                }

            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index + 1 > arr.Length)
            {
                Console.WriteLine("Error");
                Environment.Exit(0);
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
                
            }

            Array.Resize<T>(ref arr, arr.Length - 1);
        }

        public void RemoveRange(int index, int count)
        {
            int numb = count - index + 1;
            Array.Resize<T>(ref arr, arr.Length + numb);
            for (int i = index; i < count + 1; i++)
            {
                arr[i] = arr[i + numb];
            }
            Array.Resize<T>(ref arr, arr.Length - numb * 2);
        }

        public void Reverse()
        {
            T[] temp = new T[arr.Length];
            int numb = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[numb - i];
            }
            Array.Copy(temp, arr, arr.Length);
            arr = temp;
        }


        public double Sum()
        {
            double[] temp = new double[arr.Length];
            Array.Copy(arr, temp, arr.Length);

            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += temp[i];
            }

            return sum;
        }

        public double Average()
        {

            double average = Sum() / arr.Length;
            return average;

        }

        public double Min()
        {
            double[] temp = new double[arr.Length];
            Array.Copy(arr, temp, arr.Length);
            double min = temp[0];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < min)
                {
                    min = temp[i];
                }
            }

            return min;
        }


        public double Max()
        {
            double[] temp = new double[arr.Length];
            Array.Copy(arr, temp, arr.Length);
            double max = temp[0];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                }
            }

            return max;
        }
    }
}