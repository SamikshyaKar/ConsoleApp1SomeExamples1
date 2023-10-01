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
