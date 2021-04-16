using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Zavdan_11_6()
        {
            /*
             * Заполнить массив из двенадцати элементов так, как показано на рис. 11.1.
                    1 2 ... 12
             */

            Console.Write("Массив: ");
            int[] Mass = new int[12];
            var random = new Random();
            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = i + 1;
            }

            Console.WriteLine( String.Join(" ", Mass));
        }

        static void Zavdan_11_30()
        {
            /*
             * Дан массив целых чисел. Выяснить:
                а) верно ли, что сумма элементов массива есть четное число;
                б) верно ли, что сумма квадратов элементов массива есть пятизначное число.
             */

            /*bool a = array.Sum() % 2 == 0,
                b = (int)Math.Log10(array.Select(n => n * n).Sum()) == 4;
            Console.WriteLine("Сумма элементов массива{0} является четным числом", a ? "" : " не");
            Console.WriteLine("Сумма квадратов элементов -{0} пятизначное число", b ? "" : " не");*/

        }

        static void Zavdan_11_54() 
        {
            /*
             * Дан массив. Найти:
                а) сумму элементов массива, значение которых не превышает 20;
                б) сумму элементов массива, больших числа a.
             */


            Console.Write("Задайте размер массива N= ");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[N];

            Console.WriteLine("Ввести элементы массива");
            for (int i = 0; i < N; i++)
                array[i] = double.Parse(Console.ReadLine());

            Console.Write("Введите число a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            // По циклу складываем все элементы массива 
            Console.WriteLine("складываем все элементы массива");
            double suma = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] < 20)
                    suma += array[i];
            }
            Console.WriteLine("А) Сумма элементов массива, которые не превышает 20: " + suma);
            
            double suma_2 = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] > a)
                    suma_2 += array[i];
            }
            Console.WriteLine("Б) Сумма элементов массива, больших числа a: " + suma_2);
            Console.ReadKey();

        }

        static void Zavdan_11_78()
        {
            /*
             * Найти число элементов массива, которые больше своих "соседей", т. е.
                предшествующего и последующего.
             */

            int[] x = new int[10];
            Random rand = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(0, 100);
                Console.WriteLine(x[i]);
            }

            int count = 0;
            for (int i = 1; i < x.Length - 1; i++)
                if ((x[i] > x[i - 1]) && (x[i] > x[i + 1]))
                    count++;
            Console.WriteLine("Число элементов массива, которые больше своих соседей: " + count);
        }

        static void Zavdan_11_102()
        {
            // В одномерном массиве имеются только два одинаковых элемента. Найти их.

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        int b = a[i];
                        a[i] = a[j];
                        a[j] = b;
                    }
            Console.WriteLine("**************");
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("**************");
            int prev = -1;
            for (int i = 0; i < n - 1; i++)
            {

                if (a[i] == a[i + 1] && prev != a[i])
                {
                    prev = a[i];
                    Console.Write(a[i]);

                }
            }
            Console.ReadLine();

        }

        static void Zavdan_11_126()
        {
            /*
             * В массиве хранится информация о росте 25 человек. Определить,
             * на сколько рост самого высокого человека превышает рост самого низкого.
             */

            int n = 25;
            int[] heigth = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                heigth[i] = rnd.Next(150, 220);
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                    if (heigth[j - 1] > heigth[j])
                    {
                        int temp = heigth[j];
                        heigth[j] = heigth[j - 1];
                        heigth[j - 1] = temp;
                    }
            }
            Console.WriteLine("Самый высокий спортсмен: {0} см.", heigth[n - 1]);
            Console.WriteLine("Самый низкий спортсмен: {0} см.", heigth[0]);
            Console.WriteLine("Разница в росте составит: {0} см.", heigth[n - 1] - heigth[0]);

        }

        static void Zavdan_11_150()
        {

            /*
             * В массиве записана информация о стоимости каждого из 20 видов товара,
             * продаваемых фирмой. С 1 января очередного года фирма прекращает про-
                давать товар, стоимость которого записана в n-м элементе массива. Полу-
                чить массив со стоимостью всех оставшихся видов товара.
             */

            int[] currentPrices = new int[20] { 4, 1, 2, 3, 4, 5, 6, 4, 7, 8, 9, 4, 5, 32, 44, 48, 1, 87, 4, 6 };

            int removePrice = 4;

            int newPriceslength = currentPrices.Length;
            for (int i = 0; i < currentPrices.Length; i++)
            {
                if (currentPrices[i] == removePrice) newPriceslength--;
            }

            int[] newPrices = new int[newPriceslength];
            int offset = 0;
            for (int i = 0; i < currentPrices.Length; i++)
            {
                if (currentPrices[i] == removePrice)
                {
                    offset++;
                    continue;
                }
                else
                    newPrices[i - offset] = currentPrices[i];
            }

            currentPrices = newPrices;
            Console.WriteLine(string.Join(", ", currentPrices));
        }

        static void Zavdan_11_202()
        {
            /*Известны оценки по информатике 28 учеников класса. Есть ли среди них
                двойки?*/

            int[] x = new int[28];
            Random rand = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(0, 12);
                Console.WriteLine(x[i]);
            }

            int suma = 0;
            //int n = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 2) 
                    suma ++;
            }
            Console.WriteLine("Сколько 2: " + suma);

        }

        static void Zavdan_11_226()
        {
            /*
             * Известны данные о мощности двигателя (в л. с.) и стоимости 30 легковых
                автомобилей. Определить общую стоимость автомобилей, у которых мощ-
                ность двигателя превышает 100 л. с.
             */

            int n = 30;
            int[,] auto = new int[n, 2];
            Random rnd = new Random();

            //Мощности
            for (int j = 0; j < n; j++)
                auto[j, 0] = rnd.Next(100, 500);

            //Стоимости
            for (int j = 0; j < n; j++)
                auto[j, 1] = rnd.Next(100000, 1000000);

            int sum = 0;
            for (int i = 0; i < n; i++)
                if (auto[i, 0] > 100)
                    sum += auto[i, 1];
            Console.WriteLine("Общая стоимость: " + sum);
        }

    }
}

