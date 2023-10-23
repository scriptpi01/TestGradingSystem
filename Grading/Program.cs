using TestGrading;

var grading = new Grading();

Console.Write("Enter percentage : ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = Grading.GradeCalculator(percentage);
Console.WriteLine($"Student Grade : {grade}");

