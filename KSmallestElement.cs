using System;
using System.Collections.Generic;

namespace KSmallestElement
{
    class Program
    {

        private static int[] _arr = { 34, 22, 55, 64, 12, 41, 90, 23, 10, 37 };
        //                            10, 12, 22, 23, 34, 37, 41, 55, 64, 90
        private static int _k = 7;

        private static int[] left;
        private static int[] right;

        static void Main(string[] args)
        {
            //TODO First task
            Array.Sort(_arr);
            PrintFirstKElements();

            //TODO Second task
            //var x = FindKElement();
            //Console.WriteLine("The {0} element in ascending order is {1}", _k, x);

            //ArraySplit(x);
            //PrintArray(left);
            //PrintArray(right);

            //TODO Third task
            //Pyramid();
        }

        private static void PrintFirstKElements()
        {
            for (var i = 0; i < _k; i++)
            {
                Console.Write(_arr[i] + " ");
            }

            Console.WriteLine();
        }

        private static int FindKElement()
        {
            var lastMin = int.MinValue;

            for (var i = 0; i < _k; i++)
            {
                lastMin = FindMin(lastMin);
            }

            return lastMin;
        }

        private static int FindMin(int lastMin)
        {
            var min = int.MaxValue;

            foreach (var t in _arr)
            {
                if (t < min && t > lastMin)
                {
                    min = t;
                }
            }

            return min;
        }

        private static void ArraySplit(int x)
        {
            var leftList = new List<int>();
            var rightList = new List<int>();

            var isLeft = true;

            foreach (var t in _arr)
            {
                if (t == x)
                {
                    isLeft = false;
                    continue;
                }

                if (isLeft)
                {
                    leftList.Add(t);
                }
                else
                {
                    rightList.Add(t);
                }
            }

            CreateLeftArray(leftList);
            CreateRightArray(rightList);
        }

        private static void CreateLeftArray(List<int> leftList)
        {
            left = new int[leftList.Count];

            for (var i = 0; i < leftList.Count; i++)
            {
                left[i] = leftList[i];
            }

            Array.Sort(left);
        }

        private static void CreateRightArray(List<int> rightList)
        {
            right = new int[rightList.Count];

            for (var i = 0; i < rightList.Count; i++)
            {
                right[i] = rightList[i];
            }
        }

        private static void Pyramid()
        {
            Console.WriteLine("Pyramid");

            for (var i = 0; i < _arr.Length; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    Console.Write(_arr[j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
        }

        private static void PrintArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("This is empty!");
                return;
            }

            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
