using System;
using System.Text;

namespace GraphColoring
{
    class Program
    {
        /* Максимален брой върхове в графа */
        private const int MaxN = 200;

        /* Брой върхове в графа */
        private const int N = 5;

        /* Матрица на съседство */
        private static readonly int[,] A =
        {
            { 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 1 },
            { 0, 1, 0, 1, 0 },
            { 0, 1, 1, 0, 1 },
            { 1, 1, 0, 1, 0 }
        };

        private static readonly int[] Col = new int[MaxN];

        private static int maxCol, count = 0;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (maxCol = 1; maxCol <= 2; maxCol++)
            {
                //for (var i = 0; i < N; i++)
                //{
                //    Col[i] = 0;
                //}

                NextCol(0);

                if (count > 0)
                {
                    break;
                }
            }

            Console.WriteLine("Общ брой намерени оцветявания с {0} цвята: {1} \n", maxCol, count);
        }

        private static void NextCol(int i)
        {
            if (i == N)
            {
                ShowResult();
                return;
            }

            for (var k = 1; k <= maxCol; k++)
            {
                Col[i] = k;
                var success = 1;
                for (var j = 0; j < N; j++)
                {
                    if (1 == A[i, j] && Col[j] == Col[i])
                    {
                        success = 0;
                        break;
                    }
                }

                if (success == 1)
                {
                    NextCol(i + 1);
                }

                Col[i] = 0;
            }
        }

        private static void ShowResult()
        {
            count++;
            Console.WriteLine("Минимално оцветяване на графа: ");
            for (var i = 0; i < N; i++)
            {
                Console.WriteLine("Връх {0} - с цвят {1} ", i + 1, Col[i]);
            }
        }
    }
}
