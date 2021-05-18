using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Student();
            sarah.Firstname = "Sarah";
            sarah.Lastname = "George";
            sarah.SetHireDate(2017, 6, 26);

            var charlie = new Student();
            charlie.Firstname = "Charlie";
            charlie.Lastname = "Traylor";

            var mattea = new Student();
            mattea.Firstname = "Mattea";
            mattea.Lastname = "Swain";


            sarah.Print();
            charlie.Print();
            mattea.Print();


            //int years = 7;
            //var company = "TQL";
            //var student = "Matt";
            //Console.WriteLine($"hello {student} from {company}");
            //Console.WriteLine($"my name is {student} and i've been at {company} for {years} years");

        }
    }
}
