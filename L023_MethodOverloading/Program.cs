// *******************************************************
// 023 - Перегрузка методов | Lesson 023
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;

/*
 *  Перезагрузка методов
 */

namespace L023_MethodOverloading
{
	//*********************************** 
	// Класс с презагружаемыми методами
	//*********************************** 
    class Some 
    {
        public void Mutiply(int a, int b)                                   // для 2-х параметров
        {
            Console.WriteLine(" Result (for 2 vars) is " + a * b);
        }

        public float Mutiply(float a, float b)                              // для 2-х параметров c другими типами и c возвратом результата
        {
            float res = a * b;
            Console.WriteLine(" Result (for 2 vars) is " + res);
            return res;
        }

        public void Mutiply(int a, int b, int c)                            // для 3-х параметров
        {
            Console.WriteLine(" Result (for 3 vars) is " + a * b * c);
        }

        public void Mutiply(string str)                                     // для 1-го параметра другого типа 
        {
            Console.WriteLine(" Result (string) is:" + str);
        }

    }


	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {

            Some test = new Some();                                         // новый объект
            test.Mutiply (2, 23);                                           // вызов метода (2 vars)           
            test.Mutiply(2, 23, 4);                                         // вызов метода (3 vars)           
            test.Mutiply(" some test...");                                  // вызов метода (1 var - string)
            
            float result = test.Mutiply(10.5f, 20.7f);                      // вызов метода (2 vars)           
            Console.WriteLine(" Result: " + result);


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
