// *******************************************************
// 018 - Наследование | Lesson 018
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;
/*
 *  Модификатор "protected" имеет доступ только во всех классах наследника
 */

namespace L018_Inheritance
{

    // ********************
    //       CLASSES
    // ********************
    // БАЗОВЫЙ КЛАСС (общие характеристии-данне)
    class Animal 
    { 
        public string Name { get; set; }                    // авто-аксессор
        
        public Animal (string name)                         // конструктор ("public" обязательно)
        { 
            Name = name;
        }

        public void Print ()                                // метод
        {
            Console.WriteLine(" Class Animal: " + Name);
        }


    }

    // НАСЛЕДНИК (доп. характеристии-данне)
    class Dog : Animal 
    { 
        private float speed;                                // новое поле (свойство)

        public Dog (float speed, string name) : base(name)  // конструктор ("public" обязательно) - передает "name" в базовый класс "Animal"
        {
            this.speed = speed;                             // доп. поле наследника 
            Console.WriteLine(" Speed: " + speed);

        }
            
    }


	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main (string[] args)
        {
            Dog tom  = new Dog (12.23f, "Tom");
            //tom.Name = "Tom";
            Console.WriteLine(" Main Name: " + tom.Name);

            Dog jerry = new Dog(23.2f, "Jerry");
            Console.WriteLine(" Main Name: " + jerry.Name);
            Console.WriteLine("---------------------");
            jerry.Print();

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
