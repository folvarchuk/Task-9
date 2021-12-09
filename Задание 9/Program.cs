using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции 
             * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. 
             * Используйте обработку исключений для защиты от ввода некорректных данных.*/

            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите первое целое число: X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе целое число: Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                int result;
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("    1 - сложение");
                Console.WriteLine("    2 - вычитание");
                Console.WriteLine("    3 - произведение");
                Console.WriteLine("    4 - деление");


                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("Ваш выбор: 1");
                            result = x + y;
                            Console.WriteLine("Результат равен {0}", result);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Ваш выбор: 2");
                            result = x - y;
                            Console.WriteLine("Результат равен {0}", result);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ваш выбор: 3");
                            result = x * y;
                            Console.WriteLine("Результат равен {0}", result);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Ваш выбор: 4");
                            try
                            {
                                result = x / y;
                                Console.WriteLine("Результат равен {0}", result);
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Ошибка! На ноль делить нельзя!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка! Выберите код из предложенных вариантов");
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        
    }
}
