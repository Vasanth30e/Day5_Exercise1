using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfEmployess;
            int numOfWorkingDay;

            Console.WriteLine("Enter the number of employess");
            numOfEmployess = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of Working Days");
            numOfWorkingDay = int.Parse(Console.ReadLine());

            int[][] employeeSalary = new int[numOfEmployess][];

            for(int i = 0; i < numOfEmployess; i++) 
            {
                employeeSalary[i] = new int[numOfWorkingDay];
                for(int j = 0; j< numOfWorkingDay; j++)
                {
                    Console.WriteLine($"Enter Salary for Day :{j + 1} of Employee {i + 1}: ");
                    employeeSalary[i][j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("\nSalary for the entire week");
            Console.WriteLine("Day1\tDay2\tDay3\tDay4\tDay5\tTotalSalary\n");
            for (int i = 0;i < numOfEmployess; i++)
            {
                int totalSalary = 0;
                for (int j = 0; j < numOfWorkingDay; j++)
                {
                    totalSalary += employeeSalary[i][j];
                    Console.Write(employeeSalary[i][j] + "\t");
                    
                }
                
                Console.Write(totalSalary);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
            
            
        }
    }
}
