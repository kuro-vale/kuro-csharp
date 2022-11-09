// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e/csharp

static int ExpressionsMatter(int a, int b, int c)
{
    return new[] { a * b * c, a + b + c, (a + b) * c, a * (b + c) }.Max();
}

Console.WriteLine(ExpressionsMatter(5, 4, 3));
