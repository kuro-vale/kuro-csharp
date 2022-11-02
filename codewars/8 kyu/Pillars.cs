// https://www.codewars.com/kata/5bb0c58f484fcd170700063d/csharp

static int Pillars(int numPill, int dist, int width)
{
    dist *= 100;
    if (numPill == 1) return 0;
    return dist * (numPill - 1) + width * (numPill - 2);
}

Console.WriteLine(Pillars(2, 20, 10));
