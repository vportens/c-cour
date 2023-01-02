// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] myArray = {9, 3, 13, 12, 45, 6, 7, 8, 9};

Array.Sort(myArray, 3, 3);
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}