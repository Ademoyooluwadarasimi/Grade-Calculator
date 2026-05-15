using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter your name: ");
            string Studentname = Console.ReadLine();

            string[] subject = new string[5];
            int[] grade = new int[5];
            
            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write($"Enter name of subject{i + 1}: ");
                subject[i] = Console.ReadLine();

                Console.Write($"Enter grade for {subject[i]}: ");
                grade[i] = int.Parse(Console.ReadLine());



                string lettergrade;

                if (grade[i] >= 70)
                    lettergrade = "A";
                else if (grade[i] >= 60)
                    lettergrade = "B";
                else if (grade[i] >= 50)
                    lettergrade = "C";
                else if (grade[i] >= 45)
                    lettergrade = "D";
                else lettergrade = "F";

                Console.WriteLine($"{subject[i]} : {lettergrade}");





            }
            // calculating total and average
            int total = 0;

            for (int i = 0; i < grade.Length; i++)
            {

                total = total + grade[i];

            }
            double average = total / grade.Length;

            Console.WriteLine($"Total: {total} ");
            Console.WriteLine($"Average: {average}"); 
        }

    
        
        

    }
} 
