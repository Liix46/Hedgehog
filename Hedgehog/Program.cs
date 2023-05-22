using Hedgehog;



int result = Hedgehog.Hedgehog.Solve(new[] { 8, 1, 9 }, 2);
if (result == -1)
{
    Console.WriteLine("hedgehogs will not be able to reach their goal");
}
else
{
    Console.WriteLine($"hedgehogs will be able to reach their goal in so many encounters: {result}");
}


result = Hedgehog.Hedgehog.Solve(new[] { 9, 0, 9 }, 2);
if (result == -1)
{
    Console.WriteLine("hedgehogs will not be able to reach their goal");
}
else
{
    Console.WriteLine($"hedgehogs will be able to reach their goal in so many encounters: {result}");
}


result = Hedgehog.Hedgehog.Solve(new[] { 1, 1, 1 }, 0);
if (result == -1)
{
    Console.WriteLine("hedgehogs will not be able to reach their goal");
}
else
{
    Console.WriteLine($"hedgehogs will be able to reach their goal in so many encounters: {result}");
}