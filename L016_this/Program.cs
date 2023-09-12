// *******************************************************
// 016 - Указатель this | Lesson 016
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************


using System;

/*
 * Модификаторы доступа:
 * public       - полный доступ 
 * private      - доступ только внутри класса (* по умолчанию)
 * protected    - доступ только наследникам   
 * 
 * Static доступен только для базового класса
 * Static не доступен для объектов класса
 * 
 * Конструкторы вызываются каждый раз при создании объекта 
 * Консрукторов может быть любое ков-во в классе, но с одним именем класса 
 * 
 * this - указатепь на переменные и методы класса
 */

namespace L016_this
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        // ***** CLASS ANIMAL *****
        class Animal
        {
            public static int count = 0;                // кол-во созданных объектов класса
            public string name;
            public int age;
            public float happyness;

            // --- CONSTRUCTORS ----
            public Animal()
            {
                name = "Spotty";
                age = 7;
                happyness = 0.6f;

                count++;                                // счётчик объектов (в базовом классе Animal)
                print();                                // вывод полей
            }

            // --- THIS ---
            public Animal(string name, int age, float happyness)
            {
                this.name = name;
                this.age = age;
                this.happyness = happyness;

                count++;                                // счётчик объектов (в базовом классе Animal)
                print();                                // вывод полей
            }

            // --- END CONSTRUCTORS ----

            public void print()
            {
                Console.WriteLine(" NAME: " + name);
                Console.WriteLine(" AGE: " + age);
                Console.WriteLine(" HAPPYNESS: " + happyness);
                Console.WriteLine("----------------------------");
            }
        }

        // ***** CLASS MAIN ***** 
        public static void Main(string[] args)
        {
            Console.WriteLine("\n****** CLASSES ******\n");

            // CAT 
            Animal cat = new Animal();                  // создать объект "cat" класса "Animal" по умолчанию (без параметров)
            //cat.name = "PEEK";
            //Console.WriteLine("\n NAME: " + cat.name);

            // DOG 
            Animal dog = new Animal("Tom", 12, 0.99f);  // создать объект "dog" класса "Animal" c параметрами (значениями) конструктора 
            Console.WriteLine("\n Count of animals: " + Animal.count);


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
