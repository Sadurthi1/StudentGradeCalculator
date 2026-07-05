Console.WriteLine("Student Grade Calculator");

Console.WriteLine("Enter the student's name:");
string studentName = Console.ReadLine();

Console.WriteLine("Enter the student's grade (0-100):");
string studentGradeInput = Console.ReadLine();
int Marks  = Convert.ToInt32(Console.ReadLine());

string grade;

if (Marks >= 90)
{
    grade = "A";
}
else if (Marks >= 80)
{
    grade = "B";
}
else if (Marks >= 70)
{
    grade = "C";
}
else if (Marks >= 60)
{
    grade = "D";
}
else
{
    grade = "Fail";
}

Console.WriteLine();
Console.WriteLine("Results");
Console.WriteLine("Student Name: " + studentName);
Console.WriteLine("Marks: " + Marks);
Console.WriteLine("Grade: " + grade);

