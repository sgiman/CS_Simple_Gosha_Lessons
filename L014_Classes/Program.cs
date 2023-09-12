// *******************************************************
// 014 - Создание классов (Classes) | Lesson 014
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
 */

namespace L014_Classes
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        // ***** CLASS ANIMAL *****
        class Animal
        {
            public string name = "Spotty";     
            public int age = 7;
            public float happyness = 0.6f;

            public void print () 
            {
                Console.WriteLine(" NAME: " + name);
                Console.WriteLine(" AGE: " + age);
                Console.WriteLine(" HAPPYNESS: " + happyness);
            }
        }

        // ***** CLASS MAIN ***** 
        public static void Main(string[] args)
        {
            Animal cat = new Animal();              // создать объект "cat" класса "Animal"

            Console.WriteLine("\n****** CLASSES ******");
            
            cat.print();

            cat.name = "Tom";
            Console.WriteLine("\n NAME: " + cat.name);


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
