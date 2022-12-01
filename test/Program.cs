// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[5];

// fill the array with values
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine(arr.Length);

int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
// print all val
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}