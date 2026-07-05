Console.WriteLine("Student Grade Calculator");

Console.WriteLine("Enter the student's name:");
string studentName = Console.ReadLine();

Console.WriteLine("Enter the mathMarks):");
//string studentGradeInput = Console.ReadLine();
int mathMarks  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the scienceMarks):");
//string studentGradeInput = Console.ReadLine();
int scienceMarks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the englishMarks):");
//string studentGradeInput = Console.ReadLine();
int englishMarks = Convert.ToInt32(Console.ReadLine());

int totalMarks = mathMarks + scienceMarks + englishMarks;
double averageMarks = totalMarks / 3.0;


string grade;

if (averageMarks >= 90)
{
    grade = "A";
}
else if (averageMarks >= 80)
{
    grade = "B";
}
else if (averageMarks >= 70)
{
    grade = "C";
}
else if (averageMarks >= 60)
{
    grade = "D";
}
else
{
    grade = "Fail";
}

Console.WriteLine();
Console.WriteLine("***********************************");
Console.WriteLine("Results");
Console.WriteLine("***********************************");
Console.WriteLine("Student Name: " + studentName);
Console.WriteLine("***********************************");
Console.WriteLine("Math Marks: " + mathMarks);
Console.WriteLine("Science Marks: " + scienceMarks);
Console.WriteLine("English Marks: " + englishMarks);
Console.WriteLine("***********************************");
Console.WriteLine("Total Marks: " + totalMarks);
Console.WriteLine("***********************************");
Console.WriteLine("Marks: " + averageMarks);
Console.WriteLine("***********************************");
Console.WriteLine("Grade: " + grade);
Console.WriteLine("***********************************");




