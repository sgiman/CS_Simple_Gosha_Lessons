// **************************************************************************************
// 008 - Циклы, а также операторы Break и Continue (Lesson 008)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;

namespace L008_Loop
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ОПЕРАТОР ЦИКЛА - FOR (CONTINUE, BREAK)
            //for (int i = 0; i <= 5; i++) 
            Console.WriteLine("***** FOR - CONTINUE *****\n");
            for (int i = 10; i >= 5; i--) { 
                if (i == 8) continue;
                Console.WriteLine(" i = " + i + "\n");
            }

            Console.WriteLine("***** FOR - BREAK *****\n");
            for (int i = 10; i >= 5; i--)
            {
                if (i < 8) break;
                Console.WriteLine(" i = " + i + "\n");
            }

            // ОПЕРАТОР ЦИКЛА - WHILE
            Console.WriteLine("***** WHILE *****\n");
            int j = 0;
            while (j <= 5)
            { 
                j++;
                Console.WriteLine(" j = " + j + "\n");
            }

            // ОПЕРАТОР ЦИКЛА - DO WHILE
            Console.WriteLine("***** DO WHILE *****\n");
            int number = 0;
            do { 
                Console.WriteLine("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());              
            } while(number != 5);


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
