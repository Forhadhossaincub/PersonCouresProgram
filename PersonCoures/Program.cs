using PersonCoures.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCoures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Trainee t = new Trainee();

            Console.Write("ID: ");
            t.ID = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            t.Name = Console.ReadLine();

            Console.Write("Address: ");
            t.Address=Console.ReadLine();

            Console.Write("Date of Birth: ");
            t.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Course:Web=1,Programming=2,Database=3,Networking=4 ");
            t.Course=(Course)int.Parse(Console.ReadLine());

            //Enum.Parse(typeof(Course), Console.ReadLine());
            
            Console.Write("Subject :");
            string input = Console.ReadLine();
            t.AddSubjects(input.Split(','));

            Console.WriteLine();

            Console.WriteLine("======= Output ============");
            Console.WriteLine($" Id : {t.ID} , Name : {t.Name} , Address: {t.Address}, Date of Birth: {t.DateOfBirth:dd-MM-yyyy} ");
            Console.WriteLine($"Course : {t.Course}");
            Console.WriteLine($"Subjects : {t.GetSubjects()}");


            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
