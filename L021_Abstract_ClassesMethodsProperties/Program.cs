// ***********************************************************
// 021 - Абстрактные классы, методы и свойства | Lesson 021
// -----------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -----------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// ***********************************************************

using System;
using System.Collections.Generic;    // for List 

namespace L021_Abstract_ClassesMethodsProperties
{

    // ********************
    //       CLASSES
    // ********************
    
    // AБСТРАКТНЫЙ КЛАСС
    abstract class Animal
    {
        public abstract string Name { get; set; }               // абстрактные свойства (реализовываются в наследниках)
        public Animal(string name)                              // конструктор ("public" обязательно)
        {
            Name = name;
        }

        public abstract void Print();                           // aбстрактный метод - не реализовывается в главном классе 
    }

    // ------------------------------------------
    // НАСЛЕДНИКИ (доп. характеристии-данне)
    // ------------------------------------------

    // --- DOG ---
    class Dog : Animal
    {
        // преоределить абстрактные свойства
        public override string Name {
            get {
                return Name;
            } 
            set {

            } 
        }        
        
        private float speed;                                    // новое поле (свойство)
        public Dog(float speed, string name) : base(name)       // конструктор ("public" обязательно) - передает "name" в базовый класс "Animal"
        {
            this.speed = speed;                                 // доп. поле наследника 
        }

        public override void Print()                            // преопределить(создать) абстрактный метод Print (в наследнике Dog)
        {
            Console.WriteLine("Dog Speed: " + speed);
        }
    }

    // --- CAT ---
    class Cat : Animal
    {
        // преоределить абстрактные свойства
        public override string Name
        {
            get
            {
                return Name;
            }
            set
            {

            }
        }

        private float speed;
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
        }

        public override void Print()                            // преопределить(создать) абстрактный метод Print (в наследнике Cat)
        {
            Console.WriteLine("Cat Speed: " + speed);
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

            List<Animal> animals = new List<Animal>();          // новый список от базового класса "Animal" 

            // Довабить новый элемент
            animals.Add(new Dog(12.23f, "Alex"));               // создать объект "Dog" и добавить в список "animals"         
            animals.Add(new Dog(11.12f, "Tom"));
            animals.Add(new Cat(10.11f, "Meow"));

            // ВЫВОД
            Console.WriteLine("--- FOREACH AS-IN ---");
            foreach (var animal in animals)                     // перебор всех элементов списка 
            {
                if (animal is Animal)
                    animal.Print();
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
