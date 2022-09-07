using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите задачу от 1 до 8");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            switch (number) 
            {
                case 1:
                    FirstTask();

                    break;

                case 3:
                    ThirdTask();
                   
                    break;
                
                case 8:
                    EighthTask();
                    
                    break;
            }      
        }

        static void FirstTask()
        {

            float a, b;
            double d;

            Console.WriteLine("В данной задаче требуются два положительных числа");

            Console.WriteLine("Введите  число a: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите  число b: ");
            b = Convert.ToSingle(Console.ReadLine());

            if (a > 0 || b > 0)
            {
                Console.WriteLine("Требуются положительные значения, повторите ввод");
            }
            else
                d = Math.Log(a,b);

            Console.ReadKey();
        }

        static void ThirdTask()
        {

            Console.WriteLine("Введите  число");
            int f;
            f = Convert.ToInt32(Console.ReadLine());

            int a = 3;
            int b = 4;
            
            int g;
            int h;


            g = f % a;

            h = f % b;

            if (h == g || g == h)
            {
                Console.WriteLine("Остаток при делении совпадает");
            }

            if (h != g || g != h)
            {
                Console.WriteLine("Остаток не совпадает");
            }
            
            Console.ReadKey();
        }


        static void EighthTask()
        {
            float a, b, c;

            Console.WriteLine("В данной задаче требуются три вещественных числа");

            Console.WriteLine("Введите  число a: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите  число b: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите  число c: ");
            c = Convert.ToSingle(Console.ReadLine());


            if (a + b > 0 || a + c > 0 || c + b > 0)
            {
                Console.WriteLine("Сумма всех чисел положительна");

            }

            if (a + b < 0 || a + c < 0 || c + b < 0)
            {
                Console.WriteLine("Одна из сумм чисел является отрицательной");
            }
            Console.ReadKey();
        }

    }


}
