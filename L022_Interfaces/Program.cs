// *******************************************************
// 022 - Интерфейсы | Lesson 022
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;

/*
 *  INTERFACES, МНОЖЕСТВЕННОЕ НАСЛЕДОВАНИЕ 
 *  Позволяют наследовать инфорацию от нескольких базовых классов (как в С++)
 */

namespace L022_Interfaces
{
    /*************************
             СТИЛЬ C++
     ************************/
    interface ISomeInterface                        // в интерфейсах не указываются модификаторы доступа
    {
        int property { get; set; }                  // свойства (только описание и тип)
        void Print ();                              // метод (только описание и тип)
    }

    interface IDraw
    {
        void Draw ();
    }


    class Test_1 : ISomeInterface, IDraw            // множественное наследование (от интерфейса)
    { 
        public int property { get; set; }           // авто-свойство 
        public void Print ()                        // метод
        {
            Console.WriteLine("Some text");
        }

        public void Draw ()
        {
            Console.WriteLine("Draw message");
        }    
    }


    class Test_2 : ISomeInterface
    {
        public int property { get; set; }          // авто-свойство 
        public void Print()                        // метод
        {
            Console.WriteLine("This is text_2");
        }
    }


	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Oбъекты интерфейса 
            Test_1 test_1 = new Test_1();
            Test_2 test_2 = new Test_2();

            // Интерфейс 1
            test_1.property = 12;
            test_1.Print();
            Console.WriteLine(test_1.property);
            test_1.Draw();

            Console.WriteLine();

            // Интерфейс 2
            test_2.property = 15;
            test_2.Print();
            Console.WriteLine(test_2.property);


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
