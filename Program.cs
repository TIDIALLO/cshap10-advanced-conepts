/*Func<double, double> square = Square;
Console.WriteLine($"square : {square(2)}");

Func<double, double> cubic = Cubic;
Console.WriteLine($"cubic : {cubic(2)}");


static double Square(double x) => Math.Pow(x, 2);
static double Cubic(double x) => Math.Pow(x, 3);
static double Two() => 2;
static void Shox() => Console.WriteLine("hello");
*/
Console.WriteLine("=======================================");

StringDelegate sd = ToLowererCase;
sd("TTTTTTTT"); 
sd = ToUpperCase;
sd("bgbirùrg");

static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
static void ToLowererCase(string text) => Console.WriteLine(text.ToLower());

public delegate void StringDelegate(string s);

