// See https://aka.ms/new-console-template for more information
using MyFirstConsoleIBMproject;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome To C#.Net Programing Fundamentals.");

Employee employee = new Employee();
Console.WriteLine("Please enter your ID:");
employee.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Employee ID:");
employee.EmployeeId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Name:");
employee.Name = Console.ReadLine();
Console.WriteLine("Please enter your City:");   
employee.City = Console.ReadLine();
Console.WriteLine("Please enter your Age:");
employee.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your Role:");
employee.Role = Console.ReadLine();
Console.WriteLine("Please enter your Email:");
employee.Email = Console.ReadLine();    
Console.WriteLine("Please enter your Salary:");
employee.Salary = Convert.ToDouble(Console.ReadLine()); 
employee.DisplayPersonDetails();
Console.WriteLine($"Personal Info: {employee.GetPersonInfo()}");  
Console.WriteLine($"Employee Info: {employee.EmployeeId}, Role: {employee.Role}, Email: {employee.Email}, Salary: {employee.Salary:C}"); // :C formats as currency    

//Product myproduct = new Product();

//WorkingwithProperties(myproduct);

//VariableDeclarationdemo();

//PersonDetails();

//iresult = CalculationDemo();
//Console.WriteLine( $"The result is: {CalculationDemo()}");

//LoopsDemo();
//StudentGradingDemo();

//TwoDimensionArraydemo();

//JaggedArrayDemo();

// value types data ranges

//DataTypeRanges();

//ProductDetailsDemo();
//WorkingwithProperties(new Product("Laptop", 150000.00, 20));

//PersonDetailsDemo();


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

static void TwoDimensionArraydemo()
{
    // 2 dimensional arrays
    Console.WriteLine("2 Dimensional Array Example:");
    int[,] twoDimensionalArray = new int[3, 3]
    {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
    };

    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            Console.Write(twoDimensionalArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static void JaggedArrayDemo()
{
    // jgged arrays

    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5, 6, 7 };

    jaggedArray[2] = new int[] { 8, 9 };
    Console.WriteLine("Jagged Array Example:");
    foreach (var array in jaggedArray)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

static void DataTypeRanges()
{

    Console.WriteLine(int.MinValue + " " + int.MaxValue);
    Console.WriteLine(long.MinValue + " " + long.MaxValue);
    Console.WriteLine(short.MinValue + " " + short.MaxValue);
    Console.WriteLine(byte.MinValue + " " + byte.MaxValue);
    Console.WriteLine(float.MinValue + " " + float.MaxValue);
    Console.WriteLine(double.MinValue + " " + double.MaxValue);
    Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);
    Console.WriteLine(char.MinValue + " " + char.MaxValue);
    Console.WriteLine(bool.FalseString + " " + bool.TrueString);
}

static void ProductDetailsDemo()
{
    Product product = new Product("Laptop", 150000.00, 20);
    product.DisplayProductDetails();
    Console.WriteLine($"Total Price: {product.CalculateTotalPrice():C}"); // :C formats as currency 
    Console.WriteLine($"Price after 10% discount: {product.ApplyDiscount(10):C}"); // :C formats as currency
    Console.WriteLine($" How many items of Product you want to  restock:");
    int restockQuantity = Convert.ToInt32(Console.ReadLine());
    product.Restock(restockQuantity);
    Console.WriteLine($"How many items of Product you want to sell:");
    int sellQuantity = Convert.ToInt32(Console.ReadLine());
    product.Sell(sellQuantity);
    Console.WriteLine($"Is the product in stock? {product.IsInStock()}");
    Console.WriteLine($"Updating product price to new Price");
    double newPrice = Convert.ToDouble(Console.ReadLine());

    product.UpdatePrice(newPrice);

    Console.WriteLine("Press any key to exit...");
}

static void WorkingwithProperties(Product myproduct)
{
    // Setting product details with set accessors in properties
    myproduct.ProductName = "Mobile";
    myproduct.ProductPrice = 150000.00;
    myproduct.ProductQuantity = 10;
    // Displaying product details with get accessors in properties
    Console.WriteLine($"Product Name: {myproduct.ProductName}, Product Price: {myproduct.ProductPrice:C}, Product Quantity: {myproduct.ProductQuantity}");
}

static void PersonDetailsDemo()
{
    Person person = new Person(1, "John Doe", "New York", 30);
    person.DisplayPersonDetails();
    Console.WriteLine($"Person info:{person.GetPersonInfo()}");
    // Updating person details
    person.UpdatePersonDetails("Munna", "Bangalore", 28);
    person.DisplayPersonDetails();


    Person person1 = new Person();
    person1.Id = 2;
    person1.Name = "Jane Smith";
    person1.City = "Chennai";

    person1.Age = 25;
    person1.DisplayPersonDetails();
    // Using auto-implemented properties
    Console.WriteLine($"Person info:{person1.GetPersonInfo()}");
    Console.WriteLine($"Person 1 details: {person1.ToString()}"); // Using ToString() method       

}