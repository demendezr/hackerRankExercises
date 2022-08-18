// See https://aka.ms/new-console-template for more information
using InterviewProblem;

Console.WriteLine("START!");

int[] input = new int[] { 123, 89, 12, 67, 43 };
int[,] output = Operations.Calculate(input);

Console.WriteLine();
Console.WriteLine("RESULT OF NUMBERS IN DESCENDING ORDER ACCORDING TO WEIGHT:");
for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine($"Weight: {output[i, 0]}, Number: {output[i, 1]}");
}

Console.WriteLine();    
Console.WriteLine("END!");