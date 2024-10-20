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
            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                
                case 1:
                    Console.Write("Условие задачи: Написать программу, которая вычисляет значение функции у \nРешение: Введите значение x: ");
                    int x = int.Parse(Console.ReadLine());
                    double y;

                    if (x >= 0 && x <= 2)
                    {
                        y = x / 5 + 3 * x - Math.Exp(-2 * x);
                        Console.Write($"y={y:f2}");
                    }
                    else if (x < 0)
                    {
                        y = Math.Pow(x, 4);
                        Console.Write($"y={-y:f2}");
                    }
                    else 

                    {
                        Console.Write("Введите другое число!");                   
                    }
                    ; break;


               case 2:
                    Console.Write("Условие задачи: Существует ли треугольник с длинами сторон a, b, c.\nРешение: Введите длину стороны a= "); 
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Введите длину стороны b= ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Введите длину стороны c= ");
                    double c = double.Parse(Console.ReadLine());

                    if(a + b > c && a + c > b && b + c > a)
                    {
                        Console.Write("Да, такой треугольник может существовать!");
                    }
                    else
                    {
                        Console.Write("Такой треугольник не может существовать");
                    }
                    break;





               case 3:
                    Console.WriteLine("Условие задачи: Дана точка на плоскости с координатами(х, у).Составить программу, которая выдает одно из сообщений: Да, Нет, На границе\nРешение задачи: ");

                    Console.Write("Введите координату x:");
                    double х = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите координату y:");
                    double у = Convert.ToDouble(Console.ReadLine());


                    if (х > -15 && х < 0 && у > -15 && у < 0)
                    {
                        Console.Write("Да");
                    }
                    else if (х < -15 || х > 0 || у < -15 || у > 0)
                    {
                        Console.Write("Нет");
                    }
                    else
                    {
                        Console.Write("На границе");
                    }
                    break;
             
                default: Console.WriteLine("Введите правильный номер задачи!"); break;
            }
            Console.ReadKey();  
        }
    }
}