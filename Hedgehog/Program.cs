using Hedgehog;


//Console.WriteLine(Hedgehog.Hedgehog.Solve(new[] { 3, 6, 9 }, 0)); // 9

//Console.WriteLine(Hedgehog.Hedgehog.Solve(new[] { 8, 1, 9 }, 0)); // -1

//Console.WriteLine(Hedgehog.Hedgehog.Solve(new[] { 1, 1, 1 }, 2)); // -1

//int result = Hedgehog.Hedgehog.Solve(new[] { 3, 6, 9 }, 0);
//if (result == -1)
//{
//    Console.WriteLine("hedgehogs will not be able to reach their goal");
//}
//else
//{
//    Console.WriteLine($"hedgehogs will be able to reach their goal in so many encounters: {result}");
//}

int result = Hedgehog.Hedgehog.Solve(new[] { 0, 20, 9 }, 2);
if (result == -1)
{
    Console.WriteLine("hedgehogs will not be able to reach their goal");
}
else
{
    Console.WriteLine($"hedgehogs will be able to reach their goal in so many encounters: {result}");
}