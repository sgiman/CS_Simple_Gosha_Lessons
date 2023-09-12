// **************************************************************************************
// 009 - Массивы (Lesson 009)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;                                               // система по умолчанию
using System.Collections.Generic;                           // для списков

namespace L009_Array
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ------ ОДНОМЕРНЫЕ MACCИBЫ (ARRAYS) ------ 
            Console.WriteLine("\n***** ARRAY INT *****");
            int[] array = new int[5];                       // Одномерный массив (объявить и создать)
            array[0] = 24;
            array[1] = 4;
            array[2] = 2;
            array[3] = 7;
            array[4] = 56;

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"\n array[{i}] = " + array[i]);

            Console.WriteLine("\n***** ARRAY STRING *****");
            string[] names = new string[3] {
                "Tom",
                "Jonh",
                "Geoge"
            };
            for (int j = 0; j < names.Length; j++)
                Console.WriteLine($"\n names[{j}] = " + names[j]);


            // ------ СПИСКИ (LISTS) ------ 
            // Maccивы более оптимальнее и более рекомендуются 
            Console.WriteLine("\n***** LIST *****");
            List<int> numbers = new List<int>();
            numbers.Add(23);    
            numbers.Add(56);
            //numbers.RemoveAt(0);                      // удалить первый элемент
            numbers.Remove(56);                         // удалить элемент

            for (int k = 0; k < numbers.Count; k++)
                Console.Write(numbers[k] + ", ");       // без перевода строки

            // ------ МНОГОМЕРНЫЕ MACCИBЫ (MULTIDIMENSIONAL ARRAYS) ------
            Console.WriteLine("\n***** MULTIDIMENSIONAL ARRAYS *****");
            int[,] arr2D = new int[5,5];
            arr2D[1, 2] = 23;

            int[,,] arr3D = new int[5,5,5];
            arr3D[1,2,3] = 23;


            // *********************************
            //          EXAMPLE (2D)
            // *********************************
            Console.WriteLine("\n***** EXAMPLE *****");
            int len = 10;
            int[,] arr = new int[len,len];

            for (int a = 0; a < len; a++)
            {
                for (int b = 0; b < len; b++)
                {
                    arr[a, b] = a + b;
                    Console.Write(arr[a,b] + ", ");     // вывод строки массива 
                }
                Console.WriteLine();                    // перевод строки 
            }


            // Не закрывать консоль (pause)
            Console.WriteLine("\n\nДля выхода нажмите любую клавишу...");
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
