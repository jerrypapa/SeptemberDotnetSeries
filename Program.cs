namespace SeptemberDotnetSeries;
internal class Program
{
    static void Main(string[] args)
    {
        MyswitchMethod();


        decimal balance = 1000; 
        string choice = string.Empty;

        while (choice != "exit")
        {
            Console.WriteLine($"Your available Balance is: {balance}");
            Console.WriteLine($"Enter  'withdraw', 'deposit', 'exit' :");
            choice = Console.ReadLine().ToLower(); //ExIT   exit

            if(choice == "withdraw")
            {

                //Conversion of decimals back to int .....

                var testDecimal1 = 655.40m;
                var testDecimal2 = 655.50m;
                var testDecimal3 = 655.55m;
                var testDecimal4 = 655.6m;


                var testInt1 = (int)testDecimal1; //655.5
                var testInt2 = (int)testDecimal2; //655
                var testInt3 = (int)testDecimal3; //655
                var testInt4 = (int)testDecimal4; //655


                Console.WriteLine("Enter the amount to withdraw"); // 655
                var readValue = Console.ReadLine();
                decimal convertedAmount = decimal.Parse(readValue);

                if(convertedAmount > balance)
                    Console.WriteLine("Insufficient funds.");


                balance -= convertedAmount; 


                //   var convertedAmount = decimal.TryParse(Console.ReadLine(), out decimal amount);

            } else if(choice == "deposit")
            {
                Console.WriteLine("Enter the amount to deposit");
                decimal convertedAmount = decimal.Parse(Console.ReadLine());
                if (convertedAmount <=50)
                    Console.WriteLine("Invalid Amount allowed");
                balance += convertedAmount;
            }


        }




        //Operattors;       ++  += --  -=   *=   /=   %=






        //AdvancedmethodReturnTypes advancedmethodReturnTypes = new ();
        //var result= advancedmethodReturnTypes.ReturnEarnedWage();

        // result.

        // Person y = new Person("John", "Duran");

        //MyDotNetMethods myMethods = new MyDotNetMethods();

        //var result= myMethods.IsWantam(20000000, 11000000);

        ////The above creates an instance of MyDotNetMethods class


        //// type variablename = value;
        //int number = 10;

        //var FullName = "John Duran";
        //var isWorking = true;


       // Console.WriteLine("Hello, World!");
    }


    static void MyswitchMethod()
    {
       Console.WriteLine("Enter your letter grade (A,B,C,D,E,F):");
       var grade = Console.ReadLine().ToUpper();

        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent!");
                break;
            case "B":
                Console.WriteLine("Well done");
                break;
            case "C":
                Console.WriteLine("Good");
                break;
            case "D":
                Console.WriteLine("You passed");
                break;
            case "F":
                Console.WriteLine("Better try again");
                break;
            default:
                Console.Write("See University Senate!");
                Console.ReadLine();
                break;
        }
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



