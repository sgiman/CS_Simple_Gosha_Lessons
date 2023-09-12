// **************************************************************************************
// 011 - Методы и функции (Lesson 011)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace L011_Methods_Functions
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass                                                         // Program
    {
        public static void Main (string[] args)                             // Main (всегда)
        {
            // Methods
            Console.WriteLine("******************");
            WriteHello(" HELLO WORLD !!!");                                  
            WriteHello (" HI!");
            Console.WriteLine("******************");
            
            Console.Write(" Input number_1: ");
            int n1 = Convert.ToInt32 (Console.ReadLine());
            
            Console.Write(" Input number_2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = Multiply(n1,n2);
            Console.WriteLine("\n Result (Multiply) is : " + result);


            // Не закрывать консоль (pause)
            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadLine();
        }

        // ****** МЕТОД ******
        public static void WriteHello (string str)
        {
            Console.WriteLine(str);
        }

        public static int Multiply(int num_1, int num_2) 
        {
            return num_1 * num_2;
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
