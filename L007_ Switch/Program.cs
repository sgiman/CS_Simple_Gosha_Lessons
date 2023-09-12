// **************************************************************************************
// 007 - Оператор Switch (Lesson 007)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.Globalization;

namespace L006_Switch
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num;

            Random randNum = new Random();
            num = randNum.Next(1, 6);                               // дипазон случайных чисел                      
          
            // ОПЕРАТОР SWITCH
            switch(num)
            { 

                case 1:
                    Console.WriteLine("Num is: " + num);
                    break;

                case 2:
                    Console.WriteLine("Num is equal to: " + num);
                    break;

                default: 
                    Console.WriteLine("Nothing! " + num);
                    break;

            }

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
