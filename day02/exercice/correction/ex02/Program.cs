// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*EX01*/
/* on crée une fonction qui prend en paramètre un int (number) et qui retourne un int */
int GetAbsoluteValue(int number)
{
    if (number < 0) // si le nombre est négatif
    {
        return -1 * number; // on retourne le nombre multiplié par -1
    }
    else // sinon (si le nombre est positif)
    {
        return number; // on retourne le nombre tel qu'il est
    }
    
}

/*EX02*/
/* on crée une fonction qui prend en paramètre un int (year) et qui retourne un booléen */
bool IsLeapYear(int year)
{
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) // si l'année est divisible par 4 et non divisible par 100 ou si elle est divisible par 400
        return true; // on retourne true 
    return false; // sinon on retourne false (return met fin à la fonction a la ligne precedente. Donc si on passe par ici, c'est que la condition precedente n'est pas remplie)
 
}

/*EX03*/
/* on crée une fonction qui prend en paramètre une string (str) et qui retourne une string */
string ReverseString(string str) {
    string reversed = ""; // on crée une variable de type string qui sera vide
    for (int i = str.Length - 1; i >= 0; i--) // on crée une boucle qui va de la longueur de la chaine de caractère - 1 (pour commencer à la fin) jusqu'à 0 (pour arriver au début)
    {
        reversed += str[i]; // on ajoute à la variable reversed le caractère à l'index i de la chaine de caractère
    }
    return reversed; // on retourne la variable reversed
}

/*EX04*/
/* on crée une fonction qui prend en paramètre un int (nbr) et qui retourne un tableau de int */
int [] ListDiviser(int nbr) {
    int [] diviseurs = new int [nbr]; // on crée un tableau de int de taille nbr
    int j = 0; // on crée une variable j qui vaut 0
    for (int i = 1; i <= nbr; i++) // on crée une boucle qui va de 1 à nbr
    {
        if (nbr % i == 0) // si nbr est divisible par i
        {
            diviseurs[j] = i; // on ajoute i à la case j du tableau diviseurs
            j++; // on incrémente j
        }
    }
    return diviseurs; // on retourne le tableau diviseurs
}

int main() {
    int number = -5;
    int year = 2020;
    string str = "Hello World";
    int nbr = 10;
    int [] diviseurs = ListDiviser(nbr);
    Console.WriteLine("EX01");
    Console.WriteLine("GetAbsoluteValue(" + number + ") = " + GetAbsoluteValue(number));
    Console.WriteLine("EX02");
    Console.WriteLine("IsLeapYear(" + year + ") = " + IsLeapYear(year));
    Console.WriteLine("EX03");
    Console.WriteLine("ReverseString(" + str + ") = " + ReverseString(str));
    Console.WriteLine("EX04");
    Console.WriteLine("ListDiviser(" + nbr + ") = ");
    for (int i = 0; i < diviseurs.Length; i++)
    {
        Console.WriteLine(diviseurs[i]);
    }
    return 0;
}

main();
