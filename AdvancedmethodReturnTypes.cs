using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberDotnetSeries;

public class AdvancedmethodReturnTypes
{
    
  /// <summary>
  /// 
  /// 
  /// </summary>
  /// <returns></returns>
    public dynamic GetPerson()
    {
        return new Person("John", "Duran");
    }

    public  WageResponse ReturnEarnedWage()

    {
        try
        {
            int Day =
    DateTime.Now.Day
    ;

            string Active = "Active";

            string Terminated = "Terminated";

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your employee number:");
            string empNumber = Console.ReadLine();

            Console.WriteLine("Enter your NetPay:");
            decimal netPay = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is your status? (Active/Terminated)");
            string status = Console.ReadLine();

            decimal EarnedWages = (netPay / 30) * Day;
            var message = string.Empty;

            if (status == Active)
            {
                message = $"Hello {name} with employee number {empNumber}, your earned wage is Ksh {EarnedWages}";

            }
            else if (status == Terminated)
            {
                message = $" {name} with employee number {empNumber}, has been terminated. Please contact HR for more information";

            }
            return (new (message, EarnedWages));
        }
        catch (Exception error)
        {
            return (new (error.Message,0m)) ;
            //throw;
        }

    }

    public MyWageResponse ReturnEarnedWage1()

    {
        try
        {
            int Day =
    DateTime.Now.Day
    ;

            string Active = "Active";

            string Terminated = "Terminated";

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your employee number:");
            string empNumber = Console.ReadLine();

            Console.WriteLine("Enter your NetPay:");
            decimal netPay = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is your status? (Active/Terminated)");
            string status = Console.ReadLine();

            decimal EarnedWages = (netPay / 30) * Day;
            var message = string.Empty;

            if (status == Active)
            {
                message = $"Hello {name} with employee number {empNumber}, your earned wage is Ksh {EarnedWages}";

            }
            else if (status == Terminated)
            {
                message = $" {name} with employee number {empNumber}, has been terminated. Please contact HR for more information";

            }
            return (new MyWageResponse(message, EarnedWages));
        }
        catch (Exception error)
        {
            return (new MyWageResponse(error.Message, 0m));
            //throw;
        }

    }

    public MyWageResponse ReturnEarnedWage3(WageRequest wageRequest)

    {
        try
        {
            int Day =
    DateTime.Now.Day
    ;

            string Active = "Active";

            string Terminated = "Terminated";

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your employee number:");
            string empNumber = Console.ReadLine();

            Console.WriteLine("Enter your NetPay:");
            decimal netPay = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What is your status? (Active/Terminated)");
            string status = Console.ReadLine();

            decimal EarnedWages = (netPay / 30) * Day;
            var message = string.Empty;

            if (status == Active)
            {
                message = $"Hello {name} with employee number {empNumber}, your earned wage is Ksh {EarnedWages}";

            }
            else if (status == Terminated)
            {
                message = $" {name} with employee number {empNumber}, has been terminated. Please contact HR for more information";

            }
            return (new MyWageResponse(message, EarnedWages));
        }
        catch (Exception error)
        {
            return (new MyWageResponse(error.Message, 0m));
            //throw;
        }

    }

    //public MyEarnedWageResponse ReturnEarnedWage4()

    //{
    //    try
    //    {
    //        int Day =
    //DateTime.Now.Day
    //;

    //        string Active = "Active";

    //        string Terminated = "Terminated";

    //        Console.WriteLine("Enter your name:");
    //        string name = Console.ReadLine();

    //        Console.WriteLine("Enter your employee number:");
    //        string empNumber = Console.ReadLine();

    //        Console.WriteLine("Enter your NetPay:");
    //        decimal netPay = Convert.ToDecimal(Console.ReadLine());

    //        Console.WriteLine("What is your status? (Active/Terminated)");
    //        string status = Console.ReadLine();

    //        decimal EarnedWages = (netPay / 30) * Day;
    //        var message = string.Empty;

    //        if (status == Active)
    //        {
    //            message = $"Hello {name} with employee number {empNumber}, your earned wage is Ksh {EarnedWages}";

    //        }
    //        else if (status == Terminated)
    //        {
    //            message = $" {name} with employee number {empNumber}, has been terminated. Please contact HR for more information";

    //        }
    //       return (new MyEarnedWageResponse(message, EarnedWages));
    //    }
    //    catch (Exception error)
    //    {
    //        return (new MyEarnedWageResponse(error.Message, 0m));
    //        //throw;
    //    }

    //}
}

public record Person(string FirstName, string LastName);

public record WageResponse(string Message, decimal EarnedWages);
public record WageRequest(string firstName,string lastName, string employmentStatus,decimal netPay);
public record struct MyWageResponse(string Message, decimal EarnedWages);

//public class MyEarnedWageResponse
//{
//    public string Message { get; set; }
//    public decimal EarnedWages { get; set; }
//    public MyEarnedWageResponse(string message, decimal earnedWages)
//    {
//        Message = message;
//        EarnedWages = earnedWages;
//    }
//}







