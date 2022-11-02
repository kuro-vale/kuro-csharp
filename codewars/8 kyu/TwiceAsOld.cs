// https://www.codewars.com/kata/5b853229cfde412a470000d0/csharp

static int TwiceAsOld(int dadYears, int sonYears)
{
    return Math.Abs(dadYears - sonYears * 2);
}

Console.WriteLine(TwiceAsOld(36, 7));
