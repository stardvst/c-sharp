using System;

public class GradeBook {

    private string courseName;

    // is the same as the commented out one
    public string CourseName {
        get {
            return courseName;
        }
        set {
            courseName = value;
        }
    }

    public string CourseAuthor { get; set; }

    public GradeBook(string name, string author) {
        CourseName = name;
        CourseAuthor = author;
    }

    public void DisplayMessage() {
        Console.WriteLine(
            "Welcome to the Grade Book for {0} presented by {1}!",
            CourseName, CourseAuthor);
    }
}