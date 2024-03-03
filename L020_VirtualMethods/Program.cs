// *******************************************************
// 020 - Виртуальные методы | Lesson 020
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;
using System.Collections.Generic;    // for List<Object> 

/*
 *  Модификатор "protected" имеет доступ только для всех классов наследника
 */

namespace L020_VirtualMethods
{

    // ********************
    //       CLASSES
    // ********************

    //-------------------------------
    // БАЗОВЫЙ КЛАСС
    // (общие характеристики-данные)
    //-------------------------------
    class Animal
    {
        public string Name { get; set; }                        // авто-аксессор

        public Animal(string name)                              // конструктор ("public" обязательно)
        {
            Name = name;
        }

        public virtual void Print()                            // метод (virtual может быть переопделён)
        {
            Console.WriteLine(" \nBase class \"Animal\" (method print): " + Name);
        }
    }

    //------------------------------
    // НАСЛЕДНИКИ
    // (доп. характеристии-данне)
    //------------------------------

    // --- DOG ---
    class Dog : Animal
    {
        private float speed;    // новое поле (свойство)

        // конструктор ("public" обязательно) - передает "name" в базовый класс "Animal"
        public Dog(float speed, string name) : base(name)       
        {
            this.speed = speed; // доп. поле наследника 
        }

        // Переопределить виртуальный базовый метод Print (в наследнике Dog)
        public override void Print()                            
        { 
            base.Print();
            Console.WriteLine("Dog Speed (override virtual method \"print\"): " + speed);
        }
    }

    // --- CAT ---
    class Cat : Animal
    {
        private float speed;

        // Консрукттор
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
        }

        // Переопределить виртуальный базовый метод Print (в наследнике "Cat")
        public override void Print()                            
        {
            base.Print();
            Console.WriteLine("Cat Speed (override virtual method \"print\"): " + speed);
        }

    }


	//*************************************
	//             === MAIN === 
	//*************************************
    class program   // Main Class
    {
        public static void Main(string[] args)                  // "Main" - точка входа (обязательно!)
        {
            // --- СПИСОК ---

            List<Animal> animals = new List<Animal>();          // новый список от базового класса "Animal" 

            // Добавить новый элемент
            animals.Add(new Dog(12.23f, "Alex"));               // создать объект "Dog" и добавить в список "animals"         
            animals.Add(new Dog(11.12f, "Tom"));
            animals.Add(new Cat(10.11f, "Meow"));

            // ВЫВОД
            Console.WriteLine("--- FOREACH AS-IN ---");
            foreach (var animal in animals)                     // перебор всех элементов списка 
            {
                if (animal is Animal)
                    //Console.WriteLine(animal.Name);
                    animal.Print();

                //if (animal is Cat)
                //    (animal as Cat).Print();                  // возвращает найденный объект в списке 

            }
            Console.WriteLine("---------------------");

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
