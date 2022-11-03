// https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e/csharp

static int SumOfDifferences(IReadOnlyCollection<int> arr)
{
    if (arr.Count == 0) return 0;
    return arr.Max() - arr.Min();
}

Console.WriteLine(SumOfDifferences(new[] { 1, 2, 10 }));
