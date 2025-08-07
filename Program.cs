// See https://aka.ms/new-console-template for more information
using MyFirstConsoleIBMproject;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome To C#.Net Programing Fundamentals.");

//VariableDeclarationdemo();

//PersonDetails();

//iresult = CalculationDemo();
//Console.WriteLine( $"The result is: {CalculationDemo()}");

//LoopsDemo();
//StudentGradingDemo();

static void VariableDeclarationdemo()
{

    // Variable Declaration
    int number = 10;
    string greeting = "Hello, C#";

    Console.WriteLine($"Number: {number}  and {greeting}");
    // previous type of variable incorporation

    Console.WriteLine("Number :{0}  and {1}", number, greeting);
}

static void PersonDetails()
{
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();
    //Console.WriteLine($"Hello, {name}!");

    Console.WriteLine("Please enter your city:");
    string city = Console.ReadLine();
    //Console.WriteLine($"Hello, {name} from {city}!");

    Console.WriteLine("Please enter your age:");
    //int age = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old!");
}

static string CalculationDemo()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation)
    {
        case "+":
            result = calculator.Add(firstNumber, secondNumber);
            break;
        case "-":
            result = calculator.Subtract(firstNumber, secondNumber);
            break;
        case "*":
            result = calculator.Multiply(firstNumber, secondNumber);
            break;
        case "/":
            try
            {
                result = calculator.Divide(firstNumber, secondNumber);
            }
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine(ex.Message);
                // return ; // Exit the program if division by zero occurs
                return ex.Message;
            }
            break;
        default:
            // Console.WriteLine("Invalid operation.");
            return $"Invalid Operation";  // Exit the program if an invalid operation is entered
    }

    string endresult = $"The result of {firstNumber} {operation} {secondNumber} is: {result}";
    return endresult;

    // Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is: {result}");
}

static void LoopsDemo()
{
    int[] numbers = { 10, 20, 34, 14, 55 };

    foreach (int number in numbers)
    {
        Console.WriteLine($"Number: {number}");
    }

    int i = numbers.Length - 1;

    while (i >= 0)
    {
        Console.WriteLine($"Number: {numbers[i]}");
        i--;
    }

    int ix = numbers.Length - 1;
    do
    {
        Console.WriteLine(numbers[ix]);
        ix--;
    } while (ix >= 0);


    int sum = 0;

    for (int x = 0; x < numbers.Length; x++)
    {
        sum += numbers[x];
    }
    Console.WriteLine($"The sum of the numbers is: {sum}");
}

static void StudentGradingDemo()
{
    Console.WriteLine("Welcome to the Student Grading System!");
    Console.WriteLine("Please enter the student's name:");
    string? studentName = Console.ReadLine();
    Console.WriteLine("Please enter the marks for 5 subjects (separated by spaces):");
    string[] marksInput = Console.ReadLine().Split(' ');
    int[] subjectMarks = new int[5];
    for (int i = 0; i < marksInput.Length && i < subjectMarks.Length; i++)
    {
        subjectMarks[i] = Convert.ToInt32(marksInput[i]);
    }
    StudentGrading student = new StudentGrading(studentName, subjectMarks);
    student.DisplayStudentDetails();
    int totalMarks = student.CalculatetotalMarks();
    double averageMarks = student.CalculateAverageMarks();
    Console.WriteLine($"Total Marks: {totalMarks}");
    Console.WriteLine($"Average Marks: {averageMarks:F2}"); // F2 formats the average to 2 decimal places

    if (averageMarks >= 90)
    {
        Console.WriteLine("Status: A)");
    }
    else if (averageMarks >= 80)
    {
        Console.WriteLine("Status: B");
    }
    else if (averageMarks >= 70)
    {
        Console.WriteLine("Status: C");
    }
    else if (averageMarks >= 60)
    {
        Console.WriteLine("Status: D");
    }
    else if (averageMarks >= 50)
    {
        Console.WriteLine("Status: E");
    }
    else
    {
        Console.WriteLine("Status: Fail");
    }
}