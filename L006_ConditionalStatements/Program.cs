// **************************************************************************************
// 006 - Условные операторы (Lesson 006)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

// <, >, >=, <=, ==. !=     : операторы сравненмя  
// ||, &&, |, &, !          : логические операторы 

using System;
using System.Globalization;

namespace L_006_ConditionalStatements
{
    //*************************************
    //             === MAIN === 
    //*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num;

            // Глобализация формата данных (для float & double) - для разделителя "точка" - переопределение 
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            /***************************************************************************************************
            double f = Convert.ToDouble(str, numberFormatInfo);
            Console.WriteLine("Convert to DOUBLE: " + f + "\n");
            ****************************************************************************************************/

            Console.WriteLine("How old are you?");
            num = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            // УСЛОВНЫЙ ОПЕРАТОР 
            if(num > 18.23d && num < 50)    // в конце "d" для указания типа double         
                Console.WriteLine("You are older than 18.23"); 
            else if(num < 10)
                Console.WriteLine("Under 10");
            else
                Console.WriteLine("Else");

            // ТЕРНАРНЫЙ ОПЕРАТОР 
            string name = num == 15 ? "First" : "Second";
            Console.WriteLine(name);


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
