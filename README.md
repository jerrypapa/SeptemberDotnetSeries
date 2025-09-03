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









