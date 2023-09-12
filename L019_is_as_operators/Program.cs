// **********************************************************
// 019 - Операторы is и as. Массив указателей | Lesson 019
// ----------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// ----------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **********************************************************

using System;
using System.Collections.Generic;    // for List 

/*
 *  Модификатор "protected" имеет доступ только во всех классах наследника
 */

namespace L019_is_as_operators
{

    // ********************
    //       CLASSES
    // ********************
    // БАЗОВЫЙ КЛАСС (общие характеристии-данне)
    class Animal
    {
        public string Name { get; set; }                    // авто-аксессор

        public Animal(string name)                         // конструктор ("public" обязательно)
        {
            Name = name;
        }

        public void Print()                                // метод
        {
            Console.WriteLine(" Class Animal: " + Name);
        }


    }

    // НАСЛЕДНИКИ (доп. характеристии-данне)
    class Dog : Animal
    {
        private float speed;                                    // новое поле (свойство)

        public Dog (float speed, string name) : base(name)      // конструктор ("public" обязательно) - передает "name" в базовый класс "Animal"
        {
            this.speed = speed;                                 // доп. поле наследника 
        }
    }

    class Cat : Animal
    {
        private float speed;                                

        public Cat (float speed, string name) : base(name)   
        {
            this.speed = speed;                             
        }
    }


	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // --- СПИСОК ---
            
            List<Animal> animals = new List<Animal>();              // новый список от базового класса "Animal" 

            // Довабить новый элемент
            animals.Add(new Dog(12.23f, "Alex"));                   // создать объект "Dog" и добавить в список "animals"         
            animals.Add(new Dog(11.12f, "Tom"));
            animals.Add(new Cat(10.11f, "Meow"));

            // ВЫВОД
            Console.WriteLine("--- FOREACH AS-IN ---");
            foreach (var animal in animals)                         // перебор всех элементов списка 
            {
                //Console.WriteLine("NAME (LIST): " + animal.Name);
                //Console.WriteLine(animal is Dog);                 // принадлежит ли элемент списка "animal" классу-наследнику "Dog"
                //Console.WriteLine(animal is Animal);              // принадлежит ли элемент списка "animal" базому классу "Animal"
                //if (animal is Cat)
                //    Console.WriteLine(animal.Name);
                if (animal is Animal)
                    Console.WriteLine(animal.Name);

                if (animal is Cat)
                    (animal as Cat).Print();                        // возвращает найденный объект в списке 

            }
            Console.WriteLine("---------------------");


            /*************************************************
            Dog tom = new Dog(12.23f, "Tom");
            Console.WriteLine(" Main Name: " + tom.Name);

            Dog jerry = new Dog(23.2f, "Jerry");
            Console.WriteLine(" Main Name: " + jerry.Name);
            Console.WriteLine("---------------------");
            jerry.Print();
            *************************************************/


            // Не закрывать консоль (pause)
            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadLine();
        }
    }
}

/***************************************************************
 * МАКРОСЫ (VS): tab click
 * -------------------------
 * cw   - Console.WriteLine()
 * try  - tray-catch
 * sw   - switch
 * if   - if 
 * wh   - while
 * do   - do-while 
 * for  - for loop
 * fore - foreach in
 **************************************************************/
