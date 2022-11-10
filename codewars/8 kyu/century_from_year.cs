// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/csharp

static int CenturyFromYear(int year)
{
    return (int)Math.Ceiling(year / 100.0);
}

Console.WriteLine(CenturyFromYear(2001));
