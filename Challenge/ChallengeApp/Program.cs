// See https://aka.ms/new-console-template for more information
using ChallengeApp.Common;

string[] cases = {
    "{}",
    "}{",
    "\"\"",
    "{abc...xyz}"
};

foreach (var item in cases)
{
    Console.WriteLine($"Case #{cases.IndexOfItem(item)} is {item.IsBracketsBalanced()}");
}

Console.ReadKey();