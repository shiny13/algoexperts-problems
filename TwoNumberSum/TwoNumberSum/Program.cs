// See https://aka.ms/new-console-template for more information
using TwoNumberSum;

Console.WriteLine("Two number sum from array with target sum");

var input = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };
var targetSum = 10;

var solution = new TwoNumberSumSolution(input, targetSum);

var result1 = solution.SolutionWithDictionary();
Console.WriteLine($"Solution using a dictionary gives a result of: [{result1[0]},{result1[1]}]");

var result2 = solution.SolutionWithSort();
Console.WriteLine($"Solution using sort gives a result of: [{result2[0]},{result2[1]}]");

Console.ReadKey();
