# Grade Calculator

A small C# console application that converts a score between 0 and 60 into a numerical grade and a grade with a suffix.

## Project Overview

The application asks the user to enter a score, calculates a grade using the rules implemented in the program, and displays both the numerical grade and a formatted grade. It then prints a table showing the calculated result for every score from 0 to 60.

## Project Background

This project was independently developed during my 20-week internship at Buss-IT-Labs. It was created as a practical exercise in C# programming and implementing calculation logic in a console application.

## Features

- Reads a score from the console
- Calculates a grade based on a 0–60 point scale
- Displays the numerical grade with one decimal place
- Formats the grade with a `+` or `–` suffix according to the implemented thresholds
- Prints a result table for all scores from 0 through 60

## Grade Calculation

The current implementation uses these rules:

- Scores of 20 points or fewer result in grade `5.0`.
- For scores above 20, the grade is calculated as `1.0 + (60 - points) * 0.1`.
- The suffix formatter adds `+` when the decimal part is at least `0.66`, and `–` when it is at least `0.33`.
- Otherwise, no suffix is added.

These are the rules implemented in this project; they should not be assumed to represent an official grading scale.

## Technologies

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio
- **Application type:** Console application

## How to Run

1. Install the .NET 8 SDK.
2. Clone or download this repository.
3. Open `GradeCalculator.sln` in Visual Studio.
4. Build and run the project.

Alternatively, run it from a terminal:

```bash
dotnet run --project GradeCalculator/GradeCalculator.csproj
```

Enter a whole-number score when prompted.

## Learning Objectives

This project provided practical experience with:

- Reading console input and displaying output
- Implementing calculation logic with methods
- Using conditional statements
- Formatting numeric values and strings
- Iterating over a range of values with a `for` loop

## Known Limitations

- The program uses `int.Parse`, so non-numeric input causes an exception.
- The entered score is not restricted to the documented 0–60 range. Values outside that range can produce results that do not make sense for the intended scale.
- The suffix thresholds are applied to a `double`, so floating-point precision can affect values close to a threshold.

## Possible Future Improvements

- Validate input with `int.TryParse`.
- Reject scores outside the 0–60 range.
- Use a more robust representation for grade steps and suffix thresholds.
- Separate input handling, calculation, and output into dedicated methods or classes.

---

*This repository preserves the original internship project. The source code has not been refactored as part of this upload.*
