---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../Ressources/Theme/Diapo.png)
_backgroundImage: url(../Ressources/Theme/Title.png)
---

<link href="../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../Ressources/Theme/Title.png) -->

# Correction loop 
---

## Exercice 3

```csharp

int randomNum = new Random().Next(1, 100);

Console.WriteLine("Guess a number between 1 and 100");

int UserResponce = Convert.ToInt32(Console.ReadLine());

while (UserResponce != randomNum)
{
    if (UserResponce > randomNum)
    {
        Console.WriteLine("Too high");
    }
    else
    {
        Console.WriteLine("Too low");
    }
    UserResponce = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("You got it!");

```

---

## Exercice 7 foreach

--- 

```csharp
Console.WriteLine("Hello, World!");

Console.Write("Enter a series of numbers separated by commas: ");
string input = Console.ReadLine();
// Split the input string into an array of strings, using the comma as the delimiter
string[] numbers = input.Split(',');
// Initialize a total variable to keep track of the sum of the numbers
int total = 0;
// Iterate over the array of numbers using a foreach loop
foreach (string number in numbers)
{
    // Convert the string to an int and add it to the total
    total += int.Parse(number);
}
// Calculate the average of the numbers by dividing the total by the number of numbers
double average = (double)total / numbers.Length;
// Output the average to the console
Console.WriteLine("Average: " + average);
```

---

## Exercice 7 for

---


```csharp
Console.WriteLine("Hello, World!");

Console.Write("Enter a series of numbers separated by commas: ");
string input = Console.ReadLine();
// Split the input string into an array of strings, using the comma as the delimiter
string[] numbers = input.Split(',');
// Initialize a total variable to keep track of the sum of the numbers
int total = 0;
// Iterate over the array of numbers using a foreach loop
for (int i = 0; i < numbers.Length; i++)
{
    // Convert the string to an int and add it to the total
    total += int.Parse(numbers[i]);
}
// Calculate the average of the numbers by dividing the total by the number of numbers
double average = (double)total / numbers.Length;
// Output the average to the console
Console.WriteLine("Average: " + average);
```