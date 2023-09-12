// *******************************************************
// 017 - Аксессоры get и set | Lesson 017
// -------------------------------------------------------
//  С# | Visual Studio 2022
// .NET Core 3.1
// -------------------------------------------------------
// Gosha Dudar - Уроки C# (C sharp)
// Writing by sgiman @ 2023
// *******************************************************

using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace L017_Get_Set_Accessors
{

    // ********************
    //       CLASSES
    // ********************

    // --- STUDENT ---
    class Student                 
    { 
        private string name;
        private int course;
        private bool scholarship;

        // Cвойства (GET & SET) - гетеры и сеторы (аксессоры)       
        /******************************************************************
        public int Course
        {
            get { 
                return course;
            } 

            set { 
                if (value < 1)          // если 1-й курс (limit)
                    course = 1;
                else if (value > 5)     // если 5-й курс (limit)
                    course = 5;
                else
                    course = value;          
           }
        }
        ******************************************************************/

        // Aвтоматичеcкие аксессоры (set & get)
        public int Course { get; set; }


        // Конструктор по умолчанию
        public Student ()
        {
            // Поля
            name = "Alex";
            course = 2; 
            scholarship = true;

            PrintAll();
        }

        // Конструктор с параметрами 
        public Student (string name, int course, bool scholarship)
        {
            this.name = name;
            this.course = course;
            this.scholarship = scholarship;

            PrintAll();
        }

        public void PrintAll ()
        {
            Console.WriteLine(" Name: " + name);
            Console.WriteLine(" Course: " + course);
            Console.WriteLine(" Scholarship: " + scholarship);
        }

    } // --- END CLASS STUDENT ---


	//*************************************
	//             === MAIN === 
	//*************************************
    class MainClass
    {
        public static void Main (string[] args)
        {

            Student Alex = new Student();                                   // по умолчанию
            Alex.Course = 3;                                                // обращенме к аксесcору (set) 
            Console.WriteLine("\n Course (get): " + Alex.Course);           // cвойство (get)

            //Console.WriteLine();
            //Student Artem = new Student("Artem", 4, false);
            //Console.WriteLine();
            //Student Olexandr = new Student("Olexandr", 1, true);

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
