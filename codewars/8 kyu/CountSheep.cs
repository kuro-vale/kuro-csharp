// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/csharp

static string CountSheep(int n)
{
    var sheep = "";
    for (var i = 1; i <= n; i++)
    {
        sheep += $"{i} sheep...";
    }

    return sheep;
}

Console.WriteLine(CountSheep(2));
