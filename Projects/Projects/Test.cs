using System;

public class GradeBookTest {
    public static void Main(string[] args) {

        GradeBook gradeBook1 = new GradeBook(/* invokes constructor */ "C#");
        GradeBook gradeBook2 = new GradeBook(/* invokes constructor */ "HTML");

        Console.WriteLine("gradeBook1 course name: {0}", gradeBook1.CourseName);
        Console.WriteLine("gradeBook2 course name: {0}", gradeBook2.CourseName);

    }
}