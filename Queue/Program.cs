﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                SortedList<string, string> shop = new SortedList<string, string>();
                shop.Add("1","Milk");
                shop.Add("2","Bread");
                shop.Add("3","Meal");

                SortedList<string, string> people = new SortedList<string, string>();
                people.Add("Egor", "Musiyak");
                people.Add("Kirill","Zyabrev");
                people.Add("Aleksandr","Mrdak");
                
                Console.Clear();
                Console.WriteLine("Методы Коллекции SortedList<> С#");
                Console.WriteLine("1. Задание SortedList");
                Console.WriteLine("2. Длина SortedList");
                Console.WriteLine("3. Очищение SortedList");
                Console.WriteLine("4. Проверка на наличие элемента в SortedList");
                Console.WriteLine("5. Добавление элемента в SortedList");
                Console.WriteLine("6. Обращение к элементам SortedList");
                Console.WriteLine("7. Выход");
                int k = int.Parse(Console.ReadLine());
                Console.Clear();
                if (k == 1)
                {
                    Console.WriteLine("Задание SortedList");
                    Console.WriteLine();
                    Console.WriteLine("Задание SortedList неизвестной длины: SortedList<string, string> numbers = new SortedList<string, string>()");
                    Console.WriteLine("Задание SortedList известной длины: SortedList<string, string> numbers = new SortedList<string, string>(10)");
                    Console.WriteLine();
                    Console.Write("Задайте SortedList типа string с именем class длиной 5: ");
                    string s = Console.ReadLine();
                    while (s != "SortedList<string, string> class = new SortedList<string, string>(5)")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        s = Console.ReadLine();
                    }
                    Console.WriteLine("Правильно!");
                    Console.ReadKey();
                }
                if (k == 2)
                {
                    Console.WriteLine("Возврат длины SortedList");
                    Console.WriteLine();
                    Console.WriteLine("Если у нас есть SortedList <people> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak')");
                    Console.WriteLine("Длину этого SortedList можно узнать командой people.Count");
                    Console.WriteLine();
                    Console.Write("Узнайте длину SortedList shop: ");
                    string s1 = Console.ReadLine();
                    while (s1 != "shop.Count")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        s1 = Console.ReadLine();
                    }
                    Console.WriteLine("Длина SortedList shop = {0}", shop.Count);
                    Console.WriteLine();
                    Console.ReadKey();
                }
                if (k == 3)
                {
                    Console.WriteLine("Очищение SortedList");
                    Console.WriteLine();
                    Console.WriteLine("Пусть у нас есть SortedList <people> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak'}");
                    Console.WriteLine("people.Count --> {0}", people.Count);
                    Console.WriteLine();
                    Console.WriteLine("Командой people.Clear() можно удалить все элементы этого SortedList");
                    Console.WriteLine("people.Clear()");
                    Console.WriteLine("people  --> {}");
                    Console.WriteLine("people.Count  --> {0}", people.Count);
                    Console.WriteLine();
                    shop.Clear();
                    Console.Write("Очистите SortedList shop: ");
                    string s2 = Console.ReadLine();
                    while (s2 != "shop.Clear()")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        s2 = Console.ReadLine();
                    }
                    Console.WriteLine("Длина SortedList shop = {0}", shop.Count);
                    Console.WriteLine();
                    Console.ReadKey();

                }
                if (k == 4)
                {
                    Console.WriteLine("Поверка вхождение значения или ключа в SortedList");
                    Console.WriteLine();
                    people.Add("Viktor", "Polezhaev");
                    Console.WriteLine("Пусть у нас есть SortedList <people> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak'}, {'Viktor', 'Polezhaev'}");
                    Console.WriteLine("Команда people.ContainsKey(string) проверяет входит ли ключ string в SortedList people");
                    Console.WriteLine();
                    Console.WriteLine("Console.WriteLine(people.ContainsKey('Egor'))  --> {0}  , т.e ключ 'Egor' содержится в нашем SortedList", people.ContainsKey("Egor"));
                    Console.WriteLine("Можете попробовать свои ключи, после чего введите строку END для окончания");
                    Console.Write("key: ");
                    string s3 = Console.ReadLine();
                    Console.WriteLine(people.ContainsKey(s3));
                    while (s3 != "END")
                    {
                        Console.Write("Имя: ");
                        s3 = Console.ReadLine();
                        if (s3 == "END")
                        {
                            break;
                        }
                        Console.WriteLine(people.ContainsKey(s3));
                    }
                    Console.WriteLine();
                    Console.WriteLine("Команда people.ContainsValue(string) проверяет входит ли значение string в SortedList people");
                    Console.WriteLine("Console.WriteLine(people.ContainsValue('Misha'))  --> {0}  , т.e значение 'Misha' не содержится в нашей Очереди", people.ContainsValue("Misha"));
                    Console.WriteLine("Можете попробовать свои значения, после чего введите строку END для окончания");
                    Console.Write("Value: ");
                    s3 = Console.ReadLine();
                    Console.WriteLine(people.ContainsValue(s3));
                    while (s3 != "END")
                    {
                        Console.Write("Имя: ");
                        s3 = Console.ReadLine();
                        if (s3 == "END")
                        {
                            break;
                        }
                        Console.WriteLine(people.ContainsValue(s3));
                    }
                    Console.WriteLine();
                    Console.ReadKey();

                }
                if (k == 5)
                {
                    SortedList<string, string> people2 = new SortedList<string, string>();
                    people2.Add("Egor", "Musiyak");
                    people2.Add("Kirill", "Zyabrev");
                    people2.Add("Aleksandr", "Mrdak");
                    Console.WriteLine("Добавление элемента в Очередь");
                    Console.WriteLine();
                    Console.WriteLine("Пусть у нас есть SortedList <people2> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak'}");
                    Console.WriteLine("Команда people2.Add(key, value) добавит в конец SortedList people2 строку элемент с ключом key и значением value");
                    Console.WriteLine();
                    Console.WriteLine("people2.Add('Bob', 'Goody')");
                    people2.Add("Bob","Goody");
                    Console.WriteLine("<people2> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak'}, {'Bob', 'Goody'}");
                    Console.WriteLine("Добавте несколько элементов, после чего напишите END");
                    string s4 = "";
                    while (s4 != "END")
                    {
                        Console.Write("key: ");
                        s4 = Console.ReadLine();
                        Console.Write("value: ");
                        string s44 = Console.ReadLine();
                        if (s4 == "END" || s44=="END")
                        {
                            break;
                        }
                        people2.Add(s4,s44);
                        Console.WriteLine("people2.Add({0}, {1})", s4,s44);
                        Console.WriteLine("Очередь:");
                        foreach (var i in people2)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.ReadKey();
                }
                if (k == 6)
                {
                    SortedList<string, string> people6 = new SortedList<string, string>();
                    people6.Add("Egor", "Musiyak"); 
                    people6.Add("Kirill", "Zyabrev");
                    people6.Add("Aleksandr", "Mrdak");
                    people.Add("Viktor", "Polezhaev");
                    Console.WriteLine("Обращение к элементам SortedList");
                    Console.WriteLine();
                    Console.WriteLine("Метод Name[key] возвращает значение которое соответстует ключу key");
                    Console.WriteLine("Пусть у нас есть SortedList <people6> = {'Egor', 'Musiyak'}, {'Kirill','Zyabrev'}, {'Aleksandr', 'Mrdak'}, {'Viktor', 'Polezhaev'}");
                    Console.Write("Верните значние которое соответвует ключу Kirill: ");
                    string s6 = Console.ReadLine();
                    while (s6 != "people6['Kirill']")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        s6 = Console.ReadLine();
                    }
                    Console.WriteLine("people6['Kirill'] -> {0}", people6["Kirill"]);

                    Console.WriteLine();
                    Console.Write("Теперь верните ключ который соответствует ключу Egor: ");
                    s6 = Console.ReadLine();
                    while (s6 != "people6['Egor']")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        s6 = Console.ReadLine();
                    }
                    Console.WriteLine("people6['Musiyak'] -> {0}", people6["Egor"]);
                    Console.WriteLine();
                    Console.WriteLine("Также можно удалять элемнты SortedList");
                    Console.WriteLine("Метод NameList.Remove(Key) удаляет элемнт с указанным ключом Key");
                    Console.Write("Удалите элемент с ключом Egor из SortedList people6: ");
                    string kl = Console.ReadLine();
                    if (kl!="people6.Remove('Egor')")
                    {
                        Console.Write("Неправильно, попробуйте еще раз: ");
                        kl=Console.ReadLine();
                    }
                    people6.Remove("Egor");
                    Console.WriteLine("people6: ");
                    foreach (var i in people6)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                    Console.ReadKey();

                }
                if (k == 8)
                {
                    Console.WriteLine("Конец...");
                    break;
                }

            }
        }
    }
}
