var students = new (string Name, int[] Scores)[]
{
    ("Sophia", [95, 98, 96, 92]),
    ("Andrew", [85, 90, 82, 88]),
    ("Emma", [92, 94, 89, 95]),
    ("Logan", [78, 82, 75, 80])
};

Console.WriteLine($"Student\t\tExam Score\tOverall Grade\tExtra Credit");
foreach (var student in students)
{
    int sum = 0;
    char grade;

    foreach (var score in student.Scores)
    {
        sum += score;
    }

    decimal examScore = (decimal)sum / student.Scores.Length;

    int scoreInt = (int)examScore;

    decimal creditScore = scoreInt >= 90 ? 5 : (scoreInt >= 80 ? 3 : (scoreInt >= 70 ? 2 : (scoreInt >= 60 ? 1 : 0)));

    grade = examScore >= 90 ? 'A' : (examScore >= 80 ? 'B' : (examScore >= 70 ? 'C' : (examScore >= 60 ? 'D' : 'F')));

    decimal overall = examScore + creditScore;

    Console.WriteLine($"{student.Name}\t\t{examScore}\t\t{overall}\t{grade}\t{scoreInt} ({creditScore})");
}

