using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Read points ---
        Console.Write("Please enter the score (0–60): ");
        int points = int.Parse(Console.ReadLine());

        // --- Calculate the grade ---
        double grade = CalculateGrade(points);

        // --- Generate grade with suffix ---
        string gradeWithSuffix = FormatGradeWithSuffix(grade);

        Console.WriteLine("Normal Grade: " + grade.ToString("0.0"));
        Console.WriteLine("Grade with +/–: " + gradeWithSuffix);

        Console.WriteLine();
        Console.WriteLine("Score Table (0 to 60):");
        Console.WriteLine("-------------------------------------","hhh");

        // --- Print table for all scores ---
        for (int i = 0; i <= 60; i++)
        {
            double g = CalculateGrade(i);
            string gSuffix = FormatGradeWithSuffix(g);
            Console.WriteLine(i + " points -> " + gSuffix);
        }
    }

    // --- Grade calculation ---
    static double CalculateGrade(int points)
    {
        if (points <= 20)
            return 5.0;

        double grade = 1.0 + (60 - points) * 0.1;

        if (grade > 5.0)
            grade = 5.0;

        return grade;
    }

    // --- Format grade with + or – ---
    static string FormatGradeWithSuffix(double grade)
    {
        int whole = (int)grade;                  // whole part (e.g., 2)
        double decimalPart = grade - whole;      // decimal part (e.g., 0.7)

        string suffix = "";

        // Apply rules:
        // .66 or higher → "+"
        // .33 or higher → "–"
        if (decimalPart >= 0.66)
            suffix = "+";
        else if (decimalPart >= 0.33)
            suffix = "–";

        // Return result like: 2+ or 3– or 1
        return whole.ToString() + suffix;
    }
}
