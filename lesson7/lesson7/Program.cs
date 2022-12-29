// See https://aka.ms/new-console-template for more information
using lesson7;

//Console.WriteLine("Hello, World!");
try
{
    int price = 210000;
    Piano piano = new Piano() { Price=price};
    Console.WriteLine("good!");

}
catch(ExspensivePrice e)
{
    Console.WriteLine(e.Message);
}

try
{
    int a = 70;
    Piano p = new Piano() { Age = a };
    Console.WriteLine("The piano is suitable");
}
catch (old e)
{
    Console.WriteLine(e.Message);

}

//Piano p1 = new Piano("white", "Yamha", 30, DateTime.Now, 200000);
List<Piano> pianos = new List<Piano>();
Console.WriteLine(pianos[70]);
Console.WriteLine(pianos[210000]);
//pianos.Add(p1);
//p1.ChangeColor()
pianos.shop.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));