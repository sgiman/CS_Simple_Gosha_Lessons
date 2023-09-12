// **************************************************************************************
// 003 - Первая программа на C# (Lesson 003)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;

namespace L003_FirstProgram
{
    //*************************************
    //             === MAIN === 
    //*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n  **************");
            Console.WriteLine("   Hello World!");
            Console.WriteLine("   Hi, everyone!");
            Console.WriteLine("  **************");

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
