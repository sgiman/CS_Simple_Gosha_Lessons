// **************************************************************************************
// 004 - Переменные. Типы переменных (Lesson 004)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;

namespace L004_Variables
{
    //*************************************
    //             === MAIN === 
    //*************************************
   class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            /*************************************************************************
            //var num = 10;                         // не рекомендуется 
            
            int num;                                // ЦЕЛОЕ    
            num = 10; 
            
            uint num_2 = 10;                        // int > 0
            
            float f = 1.23f;                        // c плавающей точкой (в конце "f" обязятельно) - дробные 

            bool boolean = false;                   // БУЛЕАН

            string name = "Ivan";                   // СТРОКА

            char n = 'G';                           // СИМВОЛ
            **************************************************************************/

            int num, num_1;

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter second num: ");
            num_1 = Convert.ToInt32(Console.ReadLine());;

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
