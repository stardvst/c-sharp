using System;

public class GradeBook {

    private int[ , ] grades;

    public string CourseName { get; set; }

    public GradeBook(string name, int[ , ] gradesArray) {
        CourseName = name;
        grades = gradesArray;
    }

    public void DisplayMessage() {
        Console.WriteLine("Welcome to the grade book " +
            " for {0}\n", CourseName);
    }

    public void ProcessGrades() {

		OutputGrades();

		Console.WriteLine("Lowest grade: {0}\nHighest grade: {1}\n",
			GetMinimum(), GetMaximum());

		OutputBarChart();

	}

    public int GetMinimum() {
		int lowest = grades[0, 0];
		
		foreach (int grade in grades) {
			if (grade < lowest) {
				lowest = grade;
			}
		}

		return lowest;
    }

    public int GetMaximum() {

		int highest = grades[0, 0];

		foreach (int grade in grades) {
			if (grade > highest) {
				highest = grade;
			}
		}

		return highest;
    }

    public double GetAverage(int student) {
		int amount = grades.GetLength(1);
		int total = 0;
		for (int exam = 0; exam < amount; exam++) {
			total += grades[student, exam];
		}
		return (double)total / amount;
    }

    public void OutputBarChart() {
		Console.WriteLine("Grade distribution:");

		int[] frequency = new int[11];

		foreach (int grade in grades) {
			++frequency[grade / 10];
		}

		for (int count=0; count<frequency.Length; count++) {
			if (count==10) {
				Console.Write("  100: ");
			} else {
				Console.Write("{0:D2}-{1:D2}: ",
					count * 10, count * 10 + 9);
			}

			for (int stars=0; stars < frequency[count]; stars++) {
				Console.Write("*");
			}

			Console.WriteLine();
		}

	}

    public void OutputGrades() {

        Console.WriteLine("The grades are:\n");
        Console.Write("              ");

        for (int test = 0; test < grades.GetLength(1); test++) {
            Console.Write("Test {0}  ", test + 1);
        }
        Console.WriteLine("Average");
        for (int student = 0; student < grades.GetLength(0); student++) {
            Console.Write("Student {0,2}", student + 1);
            for (int grade = 0; grade < grades.GetLength(1); grade++) {
                Console.Write("{0,8}", grades[student, grade]);
            }
            Console.WriteLine("{0,9:F}", GetAverage(student));
        }
    }
}