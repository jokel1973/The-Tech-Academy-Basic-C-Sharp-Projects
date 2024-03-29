using System;

namespace TrySchool
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "George" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}

