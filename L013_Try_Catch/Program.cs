// **************************************************************************************
// 013 - Оператор try-catch(Lesson 013)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.IO;

namespace L013_Try_Catch
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // --- Format Exception ---
            Console.Write("\n Enter number: ");
            try                                                         // try code
            { 
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Number is: " + num);
            }
            // ИСКЛЮЧЕНИЯ:
            // Exception,
            // DivideByZeroException,
            // FileNotFoundException,
            // IndexOutOfRangeException
            // etc.
            catch (FormatException)                                     // error 1
            {
                Console.WriteLine(" Format Exception");
            }
            catch (IndexOutOfRangeException)                            // error 2
            {
                Console.WriteLine(" Index Out Of Range Exception");
            }
            finally                                                     // always 
            {
                Console.WriteLine("***** FINALLY *****");
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
