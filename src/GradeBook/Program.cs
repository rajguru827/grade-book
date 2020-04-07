using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Raj's new Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(20.1);
            book.AddGrade(10.1);
            book.AddGrade(50.1);
            book.ShowStatistics();
        }
    }
}
