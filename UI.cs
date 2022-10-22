
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace GroupStudents
{
    public struct UI
    {

        public static void Show(Group student)
        {
            for (int i = 0; i < student.Students.Length; i++)
            {
                Console.WriteLine("=========================");
                Console.Write("RecordBook Number: ");
                Console.WriteLine(student.Students[i].recordBookNumber);
                Console.WriteLine();
                //Console.WriteLine("- - - - - - - - - - - - -");
                Console.Write("First Name: ");
                Console.WriteLine(student.Students[i].firstName);
                Console.Write("Last Name: ");
                Console.WriteLine(student.Students[i].lastName);
                //Console.WriteLine("=========================");
                //Console.WriteLine();
            }

            //Console.WriteLine(student.recordBookNumber);
            //Console.WriteLine(student.firstName);
            //Console.WriteLine(student.lastName);
        }


    }
}

