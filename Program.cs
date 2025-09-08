namespace SeptemberDotnetSeries;
internal class Program
{
    static void Main(string[] args)
    {

        MyDotNetMethods myMethods = new MyDotNetMethods();

        var result= myMethods.IsWantam(20000000, 11000000);

        //The above creates an instance of MyDotNetMethods class


        // type variablename = value;
        int number = 10;

        var FullName = "John Duran";
        var isWorking = true;


        Console.WriteLine("Hello, World!");
    }

    static void ReturnFullNames()
    {
        string firstName, lastName, fullName;
        firstName = "John";
        lastName = "Duran";
        // fullName = firstName + " " + lastName;
        // fullName= String.Concat(firstName, " ", lastName); String concatenation
        fullName = $"{firstName} {lastName}"; // String interpolation

        if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("First Name and Last Name cannot be empty.");
            return;
        }
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("First Name or Last Name cannot be empty.");
            return;
        }

        Console.WriteLine("Full Name: " + fullName); //John Duran
    }
    static void ComputeSum()
    {
        int num1, num2, sum;
        num1 = 10;
        num2 = 20;
        sum = num1 + num2;
        if(sum != 30)
        {
          Console.WriteLine("The sum is incorrect.");
        }
        
        Console.WriteLine("The sum is: " + sum);
    }
    public static void ComputeAverage()
    {
        int num1, num2, num3;
        double average;
        num1 = 10;
        num2 = 20;
        num3 = 30;
        average = (num1 + num2 + num3) / 3.0;
        Console.WriteLine("The average is: " + average);
    }
    public static void AreaOfCircle()
    {
        double radius, area;
        const double pi = 3.14159;
        radius = 5.0;
        area = pi * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);
    }
    static void ImplicitConverter()
    {
        // Implicit Conversion (automatically) - converting a smaller type to a larger type size
        int myInt = 9;
        double myDouble = myInt; // Automatic casting: int to double
        Console.WriteLine(myInt);      // Outputs 9
        Console.WriteLine(myDouble);   // Outputs 9
    }

  static void ExplicitConverter()
    {
        // Explicit Conversion (manually) - converting a larger type to a smaller size type
        double myDouble = 9.78;
        int myInt = (int)myDouble; // Manual casting: double to int
        Console.WriteLine(myDouble);   // Outputs 9.78
        Console.WriteLine(myInt);      // Outputs 9
    }
}



