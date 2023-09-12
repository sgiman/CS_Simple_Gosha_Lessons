// **************************************************************************************
// 005 - Арифметические операции (Lesson 005)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.Diagnostics.CodeAnalysis;

namespace L005_ArithmeticOperations
{
    //*************************************
    //             === MAIN === 
    //*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // const float score = 2.35f;   // Константа, которую нельзя изменять 
            // - + * / (арфиметические операции)
            // % (остаток при делении)
            
            int num, num_1;
            
            // num = num + 1;
            // num++
            // num--

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32(Console.ReadLine());
            
			Console.WriteLine("\nEnter second num: ");
            num_1 = Convert.ToInt32(Console.ReadLine()); ;
            
			Console.WriteLine("\nThis result is: " + (num + num_1).ToString());

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
