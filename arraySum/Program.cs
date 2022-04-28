// See https://aka.ms/new-console-template for more information
Console.Write("How many Element You want to Add in Array:\t");
int sum = 0;
int num = int.Parse(Console.ReadLine());
int [] arr = new int [num];

for (int i = 0; i < arr.Length; i++)
{
Console.Write($"Enter value for Position number {i+1} & index Number {i}:\t");
int val = int.Parse(Console.ReadLine());
arr[i] = val;
}

Console.WriteLine();
Console.Write("Your Given value of Array is:\t");
foreach(int item in arr)
{
Console.Write(item+" ");
sum += item;
}
Console.WriteLine();
Console.WriteLine($"Sum of Given Value is:\t{sum}");
