
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace GroupStudents
{
    public struct BL
    {






        public static Student GetStudents()
        {


            Student newStudent;


            Console.WriteLine("Enter the Record Book Number:");

            int recordBookNumber;
            string recordBookNumberStr = Console.ReadLine();
            bool number_a = Int32.TryParse(recordBookNumberStr, out recordBookNumber);

            newStudent.recordBookNumber = recordBookNumber;

            Console.WriteLine("Enter the First Name:");

            newStudent.firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name:");

            newStudent.lastName = Console.ReadLine();


            return newStudent;

        }





        public static void AddStudentToGroup(ref Group group, Student newStudent)
        {
           

            Array.Resize(ref group.Students, group.Students.Length + 1);
            group.Students[group.Students.Length - 1] = newStudent;

            

        }

    }
}

