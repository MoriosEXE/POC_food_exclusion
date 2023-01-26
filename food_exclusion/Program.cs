// See https://aka.ms/new-console-template for more information
using food_exclusion;

Console.WriteLine("Hello, World!");
Connector test_co = new Connector();

var answer = await test_co.Request("3250391781836");
Console.WriteLine(answer);