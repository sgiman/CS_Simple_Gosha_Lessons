// **************************************************************************************
// 010 - Цикл foreach на C# (Lesson 010)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.Globalization;
using System.Net.WebSockets;

namespace L010_foreach
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            float[] fnum = {1.23f, 23.23f, 23.57f};                         // массив 

            foreach (float f in fnum)                                       // вывод    
            {
                Console.WriteLine("f = " + f);
            }

            // Не закрывать консоль (pause)
            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadLine();
        }
    }
}

/**********************************************************************************************************
 
    // STRING to FLOAT
    // str = "1,9";
    str = "1.9";
    
    // Глобализация формата данных (для float & double) - для разделителя "точка" - переопределение 
    NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
    {
        NumberDecimalSeparator = ".",
    };

    double f = Convert.ToDouble(str, numberFormatInfo);
    Console.WriteLine("Convert to DOUBLE: " + f + "\n");

***********************************************************************************************************/

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
