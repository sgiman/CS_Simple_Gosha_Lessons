// *******************************************************
// 024 - Перечисления (enum) | Lesson 024
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;

/*
 * Перечисления (enum) 
 */

namespace L024_Enum
{
    enum Breed { Dog, Cat, Bird, Bear, Tiger };                         // перечисление пород

    class Animal
    { 
        public Breed breed;                                             // свойство/поле - порода
        public Animal (Breed breed)                                     // конструктор
        { this.breed = breed; }

        public void Print ()                                            // метод
        {
            Console.WriteLine(" Порода: " + breed);
        }

    }

    //*************************************
    //             === MAIN === 
    //*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal dog = new Animal (Breed.Dog);                        // новый объект - выбор породы из списка перечисления (enum)
            dog.Print();                                                // вызов метода


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
