
//A normal delegate
Calculator c = new Calculator(Add);
c(4, 6);
c = new Calculator(Mul);
c(4, 6);

static void Add(int a, int b)
{
    Console.WriteLine(a+b);
}
static void Mul(int a, int b)
{
    Console.WriteLine(a * b);
}

delegate void Calculator(int x, int y);

