using System;
using System.Collections.Generic;

namespace Lab_4_5_Logic_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("19. Перевести число из десятичной системы счисления в систему с основанием N, где N<10, N>1.");
            Console.WriteLine("18. Вычислить количество четных элементов на заданном интервале.");
            Console.WriteLine("11. Найти цифры в десятичной записи двузначного натурального числа.");
            Console.WriteLine("Введите номер задания!");
            int Task = Convert.ToInt32(Console.ReadLine());

            switch (Task)
            {
                case 19:
                    {
                        Console.WriteLine("Введите десятичное число !");
                        int Num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите  новое основание числа!");
                        int N = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Полученное число = " + MockBaseConvertation.DecimalToArbitrarySystem(Num, N) + " " + "с основанием " + N);
                        break;
                    }  
                case 18:
                    {
                        
                        Console.WriteLine("Да. Сделать заданный интервал случайным !");
                        Console.WriteLine("Нет. Вписать интервал самим !");
                        Console.WriteLine("Подтвердите выбор !");
                        string t = Console.ReadLine();
                        switch (t)
                        {
                            case "Да":
                                {
                                    Console.WriteLine("Введите количество элементов  !");
                                    int Num = Convert.ToInt32(Console.ReadLine());
                                    int[] mass = new int[Num];
                                    for (int i = 0; i < mass.Length; i++)
                                    {
                                        mass[i] = new Random().Next(0, 1000);
                                        Console.Write(mass[i]);
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Сумма нечетных чисел случайного интервала = " + Task_18.FillMass(mass));
                                    break;
                                }
                            case "Нет":
                                {
                                    Console.WriteLine("Введите количество элементов  !");
                                    int Num = Convert.ToInt32(Console.ReadLine());
                                    int[] mass = new int[Num];
                                    for (int i = 0; i < mass.Length; i++)
                                    {
                                        Console.WriteLine("Введите число");
                                        int elem = Convert.ToInt32(Console.ReadLine());
                                        mass[i] = elem;
                                    }
                                    Console.WriteLine();
                                    for (int i = 0; i < mass.Length; i++)
                                    {
                                        Console.Write(mass[i]);
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Сумма нечетных чисел заданного интервала = " + Task_18.FillMass(mass));
                                    break;
                               
                                }
                            default:
                                break;
                        } ;
                        
                        break;
                    } 
                case 11:
                    {
                        Console.WriteLine("Введите десятичное число !");
                        string Num = Console.ReadLine();
                        Console.WriteLine("Найденные цифры:");
                        Console.WriteLine(Task_11.Result(Num));
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
