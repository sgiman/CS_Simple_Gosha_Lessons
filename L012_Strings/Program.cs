// **************************************************************************************
// 012 - Работа со строками (Lesson 012)
// --------------------------------------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// --------------------------------------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// **************************************************************************************

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace L012_Strings
{
	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main (string[] args)
        {
            string str = "HellO worLD";
            Console.WriteLine ("str[1]: " + str[1]);                                        // 2-й символ
            Console.WriteLine ("Length: " + str.Length);                                    // длина
            Console.WriteLine ("IsNullOrEmpty: " + String.IsNullOrEmpty(str));              // пустая строка 
            Console.WriteLine ("IsNullOrWhiteSpace: " + String.IsNullOrWhiteSpace(str));    // пустая строка с пробелами и с кодами форматирования 

            Console.WriteLine ("Compare: " + String.Compare("a", "b"));                     // сравнение строк: взврат (-1) т.к. a < b

            Console.WriteLine ("ToLower: " + str.ToLower());                                // нижний регистр
            Console.WriteLine ("ToUpper: " + str.ToUpper());                                // верхний регистр

            Console.WriteLine ("Contains: " + str.Contains("llO"));                         // поиск фрагмента строки 
            Console.WriteLine ("StartsWith: " + str.StartsWith("Hell"));                    // поиск начала строки
            Console.WriteLine ("EndWith: " + str.EndsWith("LD"));                           // поиск конца строки
            Console.WriteLine ("Insert: " + str.Insert(5, "_END"));                         // вставить c позиции
            Console.WriteLine ("Remove: " + str.Remove(5));                                 // удалить всё от позиции
            Console.WriteLine ("Replsce: " + str.Replace("llO", "llo"));                    // заменить

            // --- SPLIT STRING ---
            char[] sym = str.ToCharArray();
            Console.WriteLine("ToCharArray: " + sym[0]);    

            Console.WriteLine("\n****** SPLIT ******");
            string s = "Arsenal, Dynamo, Real";             // срока
            string[] clubs = s.Split(',');                  // разбить строку на элементы массива
            Console.WriteLine(clubs[1]);                    // вывод элемента массива


            // Не закрывать консоль (pause)
            Console.WriteLine ("\nДля выхода нажмите любую клавишу...");
            Console.ReadLine ();
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
