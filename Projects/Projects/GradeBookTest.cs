using System;

public class GradeBookTest {
    public static void Main(string[] args) {

        GradeBook myGradeBook = new GradeBook();

        Console.WriteLine("Initial course name is: '{0}'\n", myGradeBook.CourseName);

        Console.Write("Enter a name for course: ");
        myGradeBook.CourseName = Console.ReadLine();
        Console.WriteLine(); // output a blank line          

        myGradeBook.DisplayMessage();

    }
}