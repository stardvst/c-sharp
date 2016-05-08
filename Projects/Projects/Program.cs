using System;

public class GradeBook {
 
    // is the same as the commented out one
    public string CourseName { get; set; }

    /* public string CourseName {
        get {
            return courseName;
        }
        set {
            courseName = value;
        }
    } */

    public GradeBook(string name) {
        CourseName = name; // the property CourseName is used here
    }

    public void DisplayMessage() {
        Console.WriteLine("Welcome to the Grade Book for {0}!", CourseName);
    }
}