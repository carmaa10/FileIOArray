using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Students.txt";

            string[] students = new string[3];
            students[0] = "Sue|Mcwaters|46";
            students[1] = "Phil|McGaw|68";
            students[2] = "Charlie|Velis|22";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayAllStudents(students);
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] students = File.ReadAllLines(dataPath);

            return students;
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine("\nStudent Info\n");

            // display header
            Console.WriteLine(
                "First Name".PadRight(15) +
                "Last Name".PadRight(15) +
                "Age".PadRight(15) +
                "\n----------------------------------"
                );

            foreach (string student in students)
            {
                string[] studentInfo = student.Split('|'); // if you want a CHAR, use single quotes

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];

                // display table
                Console.WriteLine(
                    firstName.PadRight(15) +
                    lastName.PadRight(15) +
                    age.PadRight(15)
                    );
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
