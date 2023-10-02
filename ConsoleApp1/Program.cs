// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
  List<StubjectClass> StubjectClassList = new List<StubjectClass>()
        {
            new StubjectClass(){name="A",MathMarks=80},
             new StubjectClass(){name="A",MathMarks=80},
              new StubjectClass(){name="A",MathMarks=80},
               new StubjectClass(){name="B",MathMarks=80},
                new StubjectClass(){name="B",MathMarks=80},
               
        };


var resultA= StubjectClassList.Where(x=>x.name=="A").ToList();
 IEnumerable <StubjectClass> Query = from StubjectClass in StubjectClassList select StubjectClass;
IEnumerable<StubjectClass> Query1 = from StubjectClass in StubjectClassList   select StubjectClass;
Console.WriteLine(resultA.Count + "A");
// Display student details
Console.WriteLine("ID  Name  Department Semester");
Console.WriteLine("+++++++++++++++++++++++++++");
foreach (StubjectClass e in Query)
{

    // Call the to string method
    Console.WriteLine(e.ToString());
}
foreach (StubjectClass e in Query1)
{

    // Call the to string method
    Console.WriteLine(e.ToString());
}
var all = StubjectClassList.OrderBy(x => x.name).ToList().
    GroupBy(x => x.name).
    Select(x => x.Sum(y =>(y.MathMarks)));
foreach (var e in all)
{

    // Call the to string method
    Console.WriteLine(e.ToString());
}

var grouped = StubjectClassList.GroupBy(x => x.name)
                     .Select(g => new
                     {
                         Name = g.Key,
                         Sum = g.Sum(x => int.Parse(x.MathMarks.ToString()))
                     });
foreach (var e in grouped)
{

    // Call the to string method
    Console.WriteLine(e.ToString() + e.Name);
}
var all1 = StubjectClassList.OrderBy(x => x.name).ToList().
    GroupBy(x => x.name).
    Select(x => x.Sum(y => int.Parse(y.MathMarks.ToString())));
foreach (var e in all1)
{

    // Call the to string method
    Console.WriteLine(e.ToString() );
}
Console.WriteLine(   "#####################"       );
int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
IEnumerable<int> result = from numbers in Num
                          where numbers > 3
                          select numbers;
foreach(var x in result)
{ Console.WriteLine(x); }
Console.WriteLine(result.ToList());
Console.WriteLine("&&&&&&&&");
var result1 = Num.Where(x => x > 3);
Console.WriteLine(  result1);
foreach(var x in result1)
{ Console.WriteLine(x); }
Console.WriteLine("&&&&&&&&");

int[] Nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//LINQ Method Syntax to Print Numbers Greater than 3
IEnumerable<int> results = Num.Where(n => n > 3).ToList();
foreach(var x in results)
{ Console.WriteLine(x); }
Console.WriteLine("&&&&&&&&");
List<string> countries = new List<string>();
countries.Add("India");
countries.Add("US");
countries.Add("Australia");
countries.Add("Russia");
IEnumerable<string> resultlist = countries.Select(x => x);
foreach (var item in resultlist)
{
    Console.WriteLine(item);
}
//Console.ReadLine();
int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Below are the even numbers");
Console.WriteLine("");
IEnumerable<int> evennumber = numbers1.Where(x => x % 2 == 0);
foreach (var item in evennumber)
{
    Console.WriteLine(item + " is an even number");
}
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Below are the Odd numbers");
Console.WriteLine("");
IEnumerable<int> oddnumber = numbers1.Where(x => x % 2 != 0);
foreach (var item in oddnumber)
{
    Console.WriteLine(item + " is an odd number");
}
//Console.ReadLine();
Console.WriteLine("--------------------------------------------------");
int[] Num1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int minimumNum = Num1.Min();
Console.WriteLine(minimumNum);
int[] Num3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("The Minimum value in the given array is:");
int minimumNums3 = Num3.Min();
Console.WriteLine("The minimum Number is {0}", minimumNums3);
Console.WriteLine("--------------------------------------------------");
int[] Num4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("The Maximum value in the given array is:");
int maximumNum = Num4.Max();
Console.WriteLine("The maximum Number is {0}", maximumNum);
//Console.ReadLine();
//Console.ReadLine();
Console.WriteLine("--------------------------------------------------");
int[] Numsum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int Sum = Numsum.Sum();

int[] Numn = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Calculating the sum of all the elements of the array :");
int Sumn = Numn.Sum();
Console.WriteLine("The Sum is {0}", Sumn);

int[] Num12 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int Count = Num12.Count();
Console.WriteLine("The count is {0}", Count);


int[] Numavg = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Find the average of the elements:");
double Average = Numavg.Average();
Console.WriteLine("The Average is {0}", Average);

int[] Numavgs = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Find the Product of the elements:");
double Averagenum = Numavgs.Aggregate((a, b) => a * b);
Console.WriteLine("The Product is {0}", Averagenum); //Output 362880 ((((((((1*2)*3)*4)*5)*6)*7)*8)*9)
string[] charlist = { "a", "b", "c", "d" };
var concta = charlist.Aggregate((a, b) => a + ',' + b);
Console.WriteLine("Concatenated String: {0}", concta);

Students.studentMethod();
string[] countries1 = { "India", "Australia", "USA", "Argentina", "Peru", "China" };
IEnumerable<string> resulta = countries1.Where(x => x.StartsWith("A"));
foreach (var country in resulta)
{
    Console.WriteLine(country);
}
string[] countriesp = { "India", "Australia", "USA", "Argentina", "Peru", "China" };
IEnumerable<string> resultp = from x in countriesp
                             where x.StartsWith("A")
                             select x;
IEnumerable<string> resultw = from x in countriesp
                              where x.StartsWith("A")
                             where x.EndsWith("s")
                             select x;
foreach (var country in resultp)
{
    Console.WriteLine(country);
}








