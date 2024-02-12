using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimKamp.Entities;

namespace YazilimKamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1=new Course();
            course1.Id = 1;
            course1.Name = "Test";
            course1.Description = ".Net 8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Phyton";
            course2.Description = "3.12";
            course2.Price = 0;
            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Java";
            course3.Description = "Java17";
            course3.Price = 10;
            Course[] courses = new Course[] {};
            for (int i = 0; i < courses.Length; i++) {
                Console.WriteLine(courses[i].Name+" / " + courses[i].Price);
            }
        }
    }
}
