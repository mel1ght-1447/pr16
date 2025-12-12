//*******************************************
//* Практическая работа №16                 *
//* Выполнил: Быков М.С., группа 2ИСП       *
//* Вариант: 2                              *
//*******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16
{
    internal class Program
    {
        class WaterAnimal
        {
            private string name;
            private string type;
            private double weight;
            private int age;
            private string predator;
            
            public string Name
            {  
                get { return name; } 
                set { name = value; }                
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            public double Weight
            {
                get { return weight; }
                set { weight = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public string Predator
            {
                get { return predator; }
                set { predator = value; }
            }
            public WaterAnimal()
            {
                this.name = "Неизвестно";
                this.type = "Неизвестно";
                this.Weight = 0;
                this.Age = 0;
                this.Predator = "Неизвестно";
            }


            public string GetWeightCategory()
            {
                if (weight <= 1)
                {
                    return "мелкое";
                }
                else if (weight > 1 && Weight <= 10)
                {
                    return "среднее";
                }
                else if (weight > 10 && Weight <= 400)
                {
                    return "крупное";
                }
                else return "Огромное";
                
            }
            public void GetInfo()
            {
                Console.WriteLine("\t ---Информация о животном---");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Вид: {type}");
                Console.WriteLine($"Вес: {weight} кг");
                Console.WriteLine($"Размер: {GetWeightCategory()}");
                Console.WriteLine($"Возраст: {age} лет");
                Console.WriteLine($"Хищник (да/нет): {predator}");
            }
            public void SetInfo()
            {
                try
                {
                    Console.WriteLine("\tВвод данных о животном");
                    Console.Write($"Имя: ");
                    name = Console.ReadLine();              
                    Console.Write($"Вид: ");
                    type = Console.ReadLine();               
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            Console.Write($"Вес: ");
                            weight = Convert.ToDouble(Console.ReadLine());
                            if (weight < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка! Введен не корректный вес");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                i--;
                            }
                            else if (weight == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка! Введен не корректный вес");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                i--;
                            }
                        }
                        catch (FormatException fEx)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: " + fEx.Message);
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            i--;
                        }
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            Console.Write($"Возраст: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка! Введен не корректный возраст");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                i--;
                            }
                            else if (age == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка! Введен не корректный возраст");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                i--;
                            }
                        }
                        catch (FormatException fEx)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: " + fEx.Message);
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            i--;
                        }
                    }
                    for (int i = 0; i < 1; i++)
                    {                       
                            Console.Write($"Хищник?(да/нет): ");
                            string predator1 = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(predator1))
                            {
                                Predator = "Неизвестно";
                            }
                            else if (predator1 == "yes" || predator1 == "1" || predator1 == "+" || predator1 == "да")
                            {
                                Predator = "да";
                            }
                            else if (predator1 == "no" || predator1 == "0" || predator1 == "-" || predator1 == "нет")
                            {
                                Predator = "нет";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка ввода!");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                i--;
                            }                     
                    }
                }
                catch (FormatException fEx)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + fEx.Message);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                Console.Clear();
            }
            static void Main(string[] args)
            {
                bool add = true;
                Console.Clear();
                Console.Title = "Практическая работа №16";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("Здравствуйте!");
                while (add) 
                { 
                    Console.WriteLine("\n\n\t ----Выберите действие----");
                    Console.WriteLine("\t1 - новое животное");
                    Console.WriteLine("\t2 - выход");
                    Console.Write("Выбор: ");
                    string choose = Console.ReadLine();
                    switch (choose) {
                        case "1":
                            Console.Clear();
                            add = true;
                            WaterAnimal obj = new WaterAnimal();
                            obj.SetInfo();
                            obj.GetInfo();
                            break;
                        case "2":
                            add = false;
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: введено неверное значение");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                    }
                }
            }
        }
    }
}
