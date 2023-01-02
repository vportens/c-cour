// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
void printTab(int[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write(tab[i] + " ");
    }
    Console.WriteLine();
}

void fillTab(int[] tab, int a = 0, int b = 100)
{
    var random = new Random();
    for (int i = 0; i < tab.Length; i++)
    {
        tab[i] = random.Next(a, b);
    }
}

int tabSize = Convert.ToInt32(Console.ReadLine());
int[] tab = new int[tabSize]; 

fillTab(tab, 100, 1000);
printTab(tab);
*/

/*
string name = "Jan";
Console.WriteLine(name);

bool is_Billi(ref string nameToCheck) {
    if (nameToCheck == "Billi") {
        return true;
    } else {
        nameToCheck = "Billi";
        return false;
    }
}

bool ret = is_Billi(ref name);

Console.WriteLine(name);
Console.WriteLine(ret);

*/

/*
void draw2DimTab(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] tab = new int[2,3] { {1,2,3}, {4,5,6} };

Console.WriteLine(tab.GetLength(0));
draw2DimTab(tab);

*/
