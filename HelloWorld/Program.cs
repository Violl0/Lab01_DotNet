string firstName = "Максим";
string lastName = "Каторжин";
string group = "ИСП-241";
int birthYear = 2008;
double gpa = 4.5;
bool hasScholarship = false;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine();
Console.WriteLine($"Отлично! {firstName} любит {subject}.");