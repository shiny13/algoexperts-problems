// See https://aka.ms/new-console-template for more information
using ValidateSubsequence;

Console.WriteLine("Validate Subsequence problem \r\n");

var sol = new ProblemSolution(new int[] { 5, 1, 22, 25, 6, -1, 8, 10, 11, 7 }, new int[] { 1, 6, -1, 10 });
sol.PrintArrays();
var result = sol.Solution();
Console.WriteLine(result ? "true" : "false");

Console.ReadKey();
