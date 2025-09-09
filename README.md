# SeptemberDotnetSeries

Involves use of Objects, Classes, data structures…

Main aim will be to create efficient, flexible, reusable, customizable, practical applications

Benefits



4 Pillars of OOP

Encapsulation

-The principle seeks to hide implementation details of objects from the outside world. All important information is contained in the object; only the selected data is available externally. The importance of this ; it enhances program security and also control over state changes, reduce risk of exceptions/errors

Inheritance

-This allows devs to create new classes(derived/child) based on existing parent classes (base classes). There is an option to to override - (Prevents code duplication)

Polymorphism

-Compliments inheritance by allowing objects of different classes to perform actions with the same name using a different code. Enhance flexibility and would make our code more modular

Abstraction

-Think of this as an expansion of encapsulation above. Through this principal, each object only reveals a specific mechanism for usage, therefore the inside code becomes independent of other objects.



IDE (Integrated Development Environment)

--Visual studio 2022 (Professional/Enterprise version)

--SQL 

--Oracle

--Postgres

--Mongo



C#  → 'C sharp'

C# 1 ---built in 2002 

2024 November - C#13

Framework  → .Net (In 2024, we have .Net 9) – Sts

Long term support (.Net 8 and C sharp 12)..Normally runs for 3 years



Key improvements per release version;



Key words

Debug – Moving through your lines of code step by step

Break point – You have to enable points where your code breaks/stops for you to be able to step through/debug

Step through – move line by line as you examine the individual lines of code (Function key (F10)..Then if you need to step further inside you do an F11)

Peek – 

Intellisence – Visual studio’s capability to auto-complete codes/ enhanced visibility

Exceptions  – An error within our execution program (Needs to be logged)

Logs (Can log on files, Log on other third-party apps (Grafana, Kibana))



Syntax

--Rules of usage of any language

using System;     ----------------------> means we can use classes from the system namespace

namespace DotnetSeries   -------------> contains our classes and other objects, we do use it to organise our code

{  ------------------------------------> marks beginning our code block

  class Order {   -------------------------> class will now contain our properties, methods etc

static void Main (string [] arg)    -----------------> Main is our method in the order class

{

Console.WriteLine(“Hey Tuesday!!“);

}

}

} ------------------------------------> marks end our code block



Always use ;  to end your statements

C sharp is case sensitive, Order and order have different meanings 





string FirstName = “Mercy“





Comments;

//  for single line comments 

Bulk comments /*your lines of code in between*/



Variables;

int  --- > stores whole numbers

double – decimals, floating point numbers

char --single character 

string --stores text

bool – true/false



syntax for variables

type variablename = value;

example; string FirstName=”James”

bool IsWantam=false;

double BankBalance = 635444.125



Constants

Prevents overwriting of values;

const double Pie = 3.142

const int divider = 30



multiple variable definitions;

int x=55,y=6,z=3;





C# Type Casting

This helps to assign values of one datatype to the other;

Implicit Tc → converting smaller type to a larger one (automatic) …Char-->int-->long--float-->double

Explicit Tc → viceversa to the above (Is manual) 



Arithmetic Operators;

+ , - ,* , /, ++, --



Logical Operators

Used for comparisons

&& --Logical And --(for most string and other object operations)

|| --Logical Or 

! – Logical Not





String Concatenation ; ..For joining two or more strings

string.Concat (values a, valueb,value c, etc)

String Interpolation



String Access



What's to be built;



Create a basic calculator that allows users to input a customer’s full names; product names, and accepts their product prices. It should then return the total cost due for payment and also Thank the customer ;



User journey;

ENTER your firstname

Enter your last name

Enter FirstProduct: 

Enter Price:

Enter SecondProduct:

Enter Price:



It should Console Print: Thank you {customer’s full names} for purchasing with us. Your total cost for the 2 products is: …..



Methods .......06092025



Methods

--Enhances re-usability across our programs/codes.

--Method parameters -- The inputs
--Return Type -- could be of various data types (String,decimal,integer,doubles,floats,bool) or ,object,Void

--Access modifier of a method : public ,static 

--Syntax

Access modifier ....> Return Type ...> Name of the method ...>Parameters/Arguments

public void IsWantam(int voterCount,int ganneredVotes,decimal threshHold)

{
    var percentageGained = (ganneredVotes/voterCount)*100


if(percentageGained < 50)
{
  return true;
}
else {
return false;
}




if(percentageGained < 50)
    return true;
return false;

return (percentageGained < 50)?true:false;



    
   
}





....Create solution
...Create Projects (can be ot types : console apps,class libraries, APIS)
...namespaces 
..Classes
..Methods , fields ..datatypes


...........Exercise .............

Build a console app;

1.Takes an employeeName
2.Take an employee Number
3.Take an employee NetPay
4.An employee status (active,terminated)

//assume 30 calendar days

Acceptance criteria

//As an active employee I want to know the earned wage amount I'm eligble for today
//As a terminated employee I want to be denied access to my wages






TUPLE RETURN TYPES;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the user's details

            
//Console.WriteLine
("Enter Your First Name:");
            //string firstName = Console.ReadLine();

            
//Console.WriteLine
("Enter your Last Name:");
            //string lastName = Console.ReadLine();

            ////Get the products and their prices

            
//Console.WriteLine
("Enter First Product ");
            //string firstProduct = Console.ReadLine();

            
//Console.WriteLine
("Enter the price of the product");
            //double firstProductPrice = Convert.ToDouble(Console.ReadLine());


            
//Console.WriteLine
("Enter Second Product");
            //string secondProduct = Console.ReadLine();

            
//Console.WriteLine
("Enter the price of the product");
            //double secondProductPrice = Convert.ToDouble(Console.ReadLine());



            //string fullName = $" {firstName} {lastName} ";

            //double sum = (firstProductPrice + secondProductPrice);



            
//Console.WriteLine
($"Thank you {fullName} for purchasing with us . Your total cost for the 2 products is Ksh {sum}");
            
            var result = ReturnEarnedWage();

            var earnedWage = result.Item2;

            Console.WriteLine(result.Item1);
        }

        public static (string, decimal) ReturnEarnedWage()

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
                return (message, EarnedWages);
            }
            catch (Exception error)
            {
                return ($"An error occurred: {error.Message}", 0);
                //throw;
            }

        }
    }
} 



......................................LESSON 09092025......................................................




Immutable , mutable
Void,
Tuples
Return types (INT,STRING,DECIMAL...ETC)

Objects (classes,records,structs)


Reference Type -- (lives in a heap)
Value Type    ---  (stored in a stack)   ..Immutable


Class is a reference type -- when you return a class/a reference type as a method's return type you will only get its referenece nd not its copy.

A struct is a value type -- when its returned its normally copied and not referenced 


Records -- introduced in c# 9 + 

They are reference types just like classes are but they support immutability  just as value types do. Ideal for DTOS, results

-There are also record structs (value type records)

dto  --> Data transfer object

...........................................

Instantiation of an object (has a wide category..ideally everything in C#)

instantiating means creating a new instance of an object;
example is we wanted to instantiate a class we would use the new key word..

public class Person{}

Person p = new Person{}



string FirstName = "Wafula"

string Greetings = FirstName

FirstName += " Sasa"

Console.WriteLine(FirstName); //Wafula Sasa
Console.WriteLine(Greetings); //Wafula


  public dynamic GetPerson()
  {
      return new Person("John", "Duran");
  }

public object GetPerson()
  {
      return new Person("John", "Duran");
  }


public Person GetPerson()
  {
      return new Person("John", "Duran");
  }





---------------------------TASK 09092025...................



A SIMPLE CAR YARD CONSOLE APP;

Please select your desired Brand;
1.Toyota
2.Nissan

  It will then list minimum two options from the selected brand

If I selected option 1

then my next select list will have ;

1.Vanguard
2.Premio

I then select any of the 2 options then I should be able to get the market price,year of manufacture, units available;

Its should read (The market price for blah blah is .....and blah blah units are in store....all models are of year ...blah blah)


......................................

Acceptance criteria..

Build atleast 4 methods that will return prices for the options available...
Where possible, Leverage records,structs as request/response types









