// Console.WriteLine("Привет от ИСП-241");
// Console.WriteLine("Автор: Каторжин Максим");
// Console.WriteLine("Гот: 2026");


// string firstName = "Максим";
// string lastName = "Каторжин";
// string group = "ИСП-241";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = false;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine();
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");

// int a = 15;
// int b = 4;

// Console.WriteLine("=== Математические операции ===");
// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");

// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");
// Console.WriteLine();

// Console.WriteLine("Математические функции");
// Console.WriteLine($"Math.Abs(-5): {Math.Abs(-5)}");
// Console.WriteLine($"Math.Pow(2, 10): {Math.Pow(2, 10)}");
// Console.WriteLine($"Math.Sqrt(144): {Math.Sqrt(144)}");
// Console.WriteLine($"Math.Max(10, 25): {Math.Max(10, 25)}");
// Console.WriteLine($"Math.Min(10, 25): {Math.Min(10, 25)}");
// Console.WriteLine($"Math.Round(3.567, 2): {Math.Round(3.567, 2)}");
// Console.WriteLine();

// Console.WriteLine("Калькулятор");
// Console.Write("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");

// if (num2 != 0)
//     Console.WriteLine($"Частное: {num1 / num2}");
// else
//     Console.WriteLine("Деление на ноль невозможно!");


Console.WriteLine("Добро пожаловать в анкету!");
Console.WriteLine();

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine();

Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();

Console.Write("Введите ваш год рождения: ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("Введите ваш средний балл (например, 4.5): ");
double gpa = double.Parse(Console.ReadLine());

Console.WriteLine();

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status;
if (isExcellent == true) 
    status = "Отличник";
else 
    status = "Хорошист";

Console.WriteLine("=== Ваша анкета ===");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");

Console.WriteLine();
Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();