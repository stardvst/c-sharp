using System;

public class GradeBook {

    private string courseName;

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

    public void DisplayMessage() {
        Console.WriteLine("Welcome to the Grade Book for {0}!", CourseName);
    }
}