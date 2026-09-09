var students = new (string Name, int[] Scores)[]
{
    ("Sophia", [90, 86, 87, 98, 100, 94, 90]),
    ("Andrew", [92, 89, 81, 96, 90, 89]),
    ("Emma", [90, 85, 87, 98, 68, 89, 89, 89]),
    ("Logan", [90, 95, 87, 88, 96, 96 ])
};

int examAssignments = 5;

Console.WriteLine($"Student\t\tExam Score\tOverall Grade\tExtra Credit");
foreach (var student in students)
{
    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    string grade = "";

    foreach (int score in student.Scores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
    currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    grade = currentStudentExamScore >= 90 ? "A" : (currentStudentExamScore >= 80 ? "B" : (currentStudentExamScore >= 70 ? "C" : (currentStudentExamScore >= 60 ? "D" : "F")));

    Console.WriteLine($"{student.Name}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{grade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)})");
}

