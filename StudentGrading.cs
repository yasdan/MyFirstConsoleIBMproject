using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class StudentGrading
    {

        string studentName;
        int[] subjectMarks = new int[5];  // array to hold marks for 5 subjects

        public StudentGrading()
        {
           // studentName = "Default Student";
           // subjectMarks = new int[] { 0, 0, 0, 0, 0 };
        }
        public StudentGrading(string name, int[] marks)
        {
            studentName = name;
            subjectMarks = marks;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine("Subject Marks:");
            for (int i = 0; i < subjectMarks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {subjectMarks[i]}");
            }
        }
        public int CalculatetotalMarks()
        {
            int total = 0;
            for (int i = 0; i < subjectMarks.Length; i++)
            {
                total += subjectMarks[i];
            }
            return total;

             
        }
        public double CalculateAverageMarks()
        {
            int total = CalculatetotalMarks();
            return (double)total / subjectMarks.Length;
        }

    }
}
