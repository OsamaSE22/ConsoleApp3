using System;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp3
{
   
    
    internal class Program
    {
        static void Main(string[] args) // this is a comment
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            Console.Write("Please Write the Name of the first student: ");
            string name1 = Console.ReadLine();
            Console.Write("Please Write the grade of the first student: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            studentGrades.Add(name1, grade1);
            //============================================================================
            Console.Write("Please Write the Name of the second student: ");
            string name2 = Console.ReadLine();
            Console.Write("Please Write the grade of the second student: ");
            int grade2 = Convert.ToInt32(Console.ReadLine());
            studentGrades.Add(name2, grade2);
            //============================================================================
            Console.Write("Please Write the Name of the third student: ");
            string name3 = Console.ReadLine();
            Console.Write("Please Write the grade of the third student: ");
            int grade3 = Convert.ToInt32(Console.ReadLine());
            studentGrades.Add(name3, grade3);
            

            //======================================================
            foreach (var ele in studentGrades)
            {
                string status;
                if (ele.Value < 21)
                {
                    status = "FreshMan";
                }
                else if (ele.Value < 41)
                {
                    status = "Sophomore";

                }
                else if (ele.Value < 61)
                {
                    status = "junior";
                }
                else if (ele.Value < 101)
                {
                    status = "Senior";
                }
                else
                {
                    status = "Unknown";
                }
                Console.WriteLine($"Name: {ele.Key}, Grade: {ele.Value}, Status: {status}");
            }




        }
    }
}