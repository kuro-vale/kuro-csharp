// https://www.codewars.com/kata/5bb904724c47249b10000131/csharp

static int TotalPoints(IEnumerable<string> games)
{
    return games.Select(s => s[0] > s[2] ? 3 : s[0] == s[2] ? 1 : 0).Sum();
}

Console.WriteLine(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }));
