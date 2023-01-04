// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*EX01*/

bool IsPalindrome(string str) {
    string reversed = ""; // on crée une variable de type string qui sera vide
    for (int i = str.Length - 1; i >= 0; i--) // on crée une boucle qui va de la longueur de la chaine de caractère - 1 (pour commencer à la fin) jusqu'à 0 (pour arriver au début)
    {
        reversed += str[i]; // on ajoute à la variable reversed le caractère à l'index i de la chaine de caractère
    }
    if (reversed == str) // si la chaine de caractère est égale à la chaine de caractère inversée
        return true; // on retourne true
    return false; // sinon on retourne false
}

/*EX02*/
int PGCD(int a, int b) {
    int pgcd = 1; // on crée une variable pgcd qui vaut 1
    for (int i = 1; i <= a; i++) // on crée une boucle qui va de 1 à a
    {
        if (a % i == 0 && b % i == 0) // si a est divisible par i et b est divisible par i
            pgcd = i; // on met i dans la variable pgcd
    }
    return pgcd; // on retourne la variable pgcd
}

/*EX03*/
int  GetFibonacciNumber(int n) {
    int a = 0; // on crée une variable a qui vaut 0
    int b = 1; // on crée une variable b qui vaut 1
    int c = 0; // on crée une variable c qui vaut 0
    for (int i = 0; i < n; i++) // on crée une boucle qui va de 0 à n
    {
        c = a + b; // on met dans c la somme de a et b
        a = b; // on met dans a la valeur de b
        b = c; // on met dans b la valeur de c
    }
    return a; // on retourne la variable a
}

/*EX04*/

bool IsPrime(int n) {
    if (n == 1) // si n vaut 1
        return false; // on retourne false
    for (int i = 2; i < n; i++) // on crée une boucle qui va de 2 à n
    {
        if (n % i == 0) // si n est divisible par i
            return false; // on retourne false
    }
    return true; // sinon on retourne true
}