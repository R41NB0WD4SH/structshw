
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace GroupStudents
{
    class Programm
    {
        static void Main(string[] args)
        {


            Student student1 = new Student()
            {
                recordBookNumber = 00005,
                firstName = "Egor",
                lastName = "Hmelnikov"
            };

            Student student2 = new Student()
            {
                recordBookNumber = 00006,
                firstName = "Daniil",
                lastName = "Barik"
            };


            Group group = new Group()
            {
                Students = new Student[]
                {
                    student1,
                    student2
                }
            };






            Console.WriteLine("***** WELCOME TO THE STUDENTS MANAGER *****");
            Console.WriteLine("===========================================");


            int choice = 0;



            while (choice != 9)
            {


                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Show All Students");
                Console.WriteLine("2 - Add New Student");
                Console.WriteLine("9 - Exit");






                string choiceStr = Console.ReadLine();
                bool number_a = Int32.TryParse(choiceStr, out choice);


                //string recordBookNumberStr;
                //int recordBookNumber;
                //bool number_recordBook = Int32.TryParse(recordBookNumberStr, out
                //    recordBookNumber);
                

                //Group students = new Group();
//                {
//                    Students = new Student[]
//{

                //}
                //                };


                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        UI.Show(group);

                        Console.WriteLine();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Press any key to return...");
                        Console.ReadKey();
                        break;


                    case 2:



                        BL.AddStudentToGroup(ref group, new Student()
                        {
                            recordBookNumber = 00001,
                            firstName = "Denis",
                            lastName = "Klimovets"
                        });

                        BL.AddStudentToGroup(ref group, new Student()
                        {
                            recordBookNumber = 00002,
                            firstName = "Mariia",
                            lastName = "Volkoboieva"
                        });

                        BL.AddStudentToGroup(ref group, new Student()
                        {
                            recordBookNumber = 00003,
                            firstName = "Dmytro",
                            lastName = "Slavkov"
                        });

                        BL.AddStudentToGroup(ref group, new Student()
                        {
                            recordBookNumber = 00004,
                            firstName = "Alexandr",
                            lastName = "Samoilenko"
                        });

                        //BL.GetStudents();
                        //BL.AddStudentToGroup(ref group, newStudent: BL.GetStudents());

                        //BL.GetStudents();

                        
                        break;

                }




                //Group students = new Group()
                //{
                //    Students = new Student[]
                //    {
                //        BL.GetStudents()
                //    }
                //};


                //BL.GetStudents();


                //BL.AddStudentToGroup(ref students, new Student());






            }
            


                //Console.ReadKey();

        }







    }

}
