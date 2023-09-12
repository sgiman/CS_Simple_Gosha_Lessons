// *******************************************************
// 025 - Структуры | Lesson 025
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;

/*
 * Структуры - это упрощенный аналог класса 
 * Структуры необходимы для оптимизации в простых случаях 
 */
namespace L025_Structures
{
    struct Book
    { 
        public string title;
        public string name;
        public string author;
    }



    //*************************************
    //             === MAIN === 
    //*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            Book b;                                                         // объявленме структуры
            b.author = "King";
            
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
