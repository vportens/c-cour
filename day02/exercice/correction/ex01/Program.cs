// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* on creer une fonction qui prend en paramètre un tableau d'entier (tab) et qui retourne rien */
/* la fonction va afficher le tableau d'entier */
void printTab(int[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write(tab[i] + " ");
    }
    Console.WriteLine();
}

/*EX01*/
/* on declare une fonction sqrt qui prend en paramètre un entier (nbrToSqrt) et qui retourne un entier */
int sqrt(int nbrToSqrt)
{
    return nbrToSqrt * nbrToSqrt; // on retourne le carré de l'entier passé en paramètre
}


/*EX02*/
/* on déclare une fonction qui prend en paramètre un entier (nbr) et qui retourne un entier */
int getNextPow2(int nbr) {
    int i = 1; // on déclare une variable i qui vaut 1
    while (i < nbr) { // tant que i est plus petit que nbr
        i *= 2; // on multiplie i par 2
    }
    return i; // on retourne i une fois que i est plus grand ou égal à nbr

}

/*EX03*/
/* on déclare une fonction qui prend en paramètre un entier (nbr) et qui retourne un entier */
int getPreviousPow2(int nbr) {
    int pow = 1; // on déclare une variable pow qui vaut 1
    while (pow < nbr) { // tant que pow est plus petit que nbr
        pow *= 2; // on multiplie pow par 2
    }
    if (pow == nbr) // si pow est égal à nbr
        return pow; // on retourne pow
    else // sinon
        return pow / 2; // on retourne pow divisé par 2
}

/*EX04*/
/* on déclare une fonction qui prend en paramètre un entier (nbr) et qui retourne un entier */
int PowOf2(int nbr) {
    int i = 0;
    int pow = 1; // on déclare une variable i qui vaut 0 et pow qui vaut 1

    while (pow < nbr) { // tant que pow est plus petit que nbr
        pow *= 2;
        i++; // on multiplie pow par 2 et on incrémente i
    }
    if (pow == nbr) // si pow est égal à nbr
       return i; // on retourne i
    else // sinon
        return i -1; // on retourne i - 1
}

/*EX05*/

/* on déclare une fonction qui va nous retourner 2 a la puissance de pow */
/* la fonction prend en paramètre un entier (nbr) et qui retourne un entier */
int Pow2(int pow) {
    int nbr = 1; // on déclare une variable nbr qui vaut 1 car 2 a la puissance 0 vaut 1
    for (int i = 0; i < pow; i++) { // on boucle tant que i est plus petit que pow
        nbr *= 2; // on multiplie nbr par 2
    }
    return nbr; // on retourne nbr (2 a la puissance de pow)
}

/* on déclare une fonction qui prend en paramètre un entier (nbr) et qui retourne rien */
void ConvertToBinary(int nbr) {
    int pow = PowOf2(nbr); // on déclare une variable pow qui vaut le résultat de la fonction PowOf2(nbr) (on récupère la puissance de 2 la plus proche, inferieur ou egale de nbr)

    int[] tab = new int[pow + 1]; // on déclare un tableau d'entier de taille pow + 1 car il ne faut pas oublier 2 a la puissance 0

    for (int i = 0; i < tab.Length; i++) { // on boucle tant que i est plus petit que la taille du tableau
        if (nbr >= Pow2(pow)) { // si nbr est plus grand ou égal à 2 a la puissance de pow
            tab[i] = 1; // le tableau a l'indice i vaut 1 car on a trouvé un 1 dans le nombre binaire
            nbr -= Pow2(pow); // on soustrait à nbr 2 a la puissance de pow a notre nombre nbr
        } else { // sinon
            tab[i] = 0; // le tableau a l'indice i vaut 0 car on a trouvé un 0 dans le nombre binaire
        }
        pow--; // on décrémente pow, on passe a la puissance de 2 inférieur pour pouvoir la recomparer a notre nombre.
    }


    printTab(tab); // on affiche le tableau
}


/*EX06*/
/* on déclare une fonction qui prend en paramètre un tableau d'entier a deux dimension (tab[,]) et qui retourne rien */
/*
void draw2DimTab(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++) // on boucle tant que i est plus petit que la taille de la première dimension du tableau, i représente les lignes
    {
        for (int j = 0; j < tab.GetLength(1); j++) // pour chaque ligne de mon tableau (i) on boucle tant que j est plus petit que la taille de la deuxième dimension du tableau, j représente les colonnes
        {
            Console.Write(tab[i, j] + " "); // on affiche le tableau a l'indice i, j. : tab[i, j] represente la valeur de la case a la ligne i et a la colonne j
        }
        Console.WriteLine(); // on affiche un retour a la ligne
    }
}

*/


/*Meme chose que l'exercice 6 avec un tableau de string en parametre*/
void draw2DimTab(string[,] tab)
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


string [,] generateBoard(int row, int columns) {
    string [,] board = new string[row, columns];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < columns; j++) {
            board[i, j] = ".";
        }
    }
    return board;
}

void PlaceToken(string [,] board, int row, int column, string token) {
    board[row, column] = token;
}

bool CheckPosToken(string [,] board, int row, int column) {
    if (row < 0 || column < 0)
        return false;
    if (row >= board.GetLength(0) || column >= board.GetLength(1))
        return false;
    if (board[row, column] == ".") {
        return true;
    } else {
        return false;
    }
}

bool checkWinColumn(string [,] board, int row, int column, int player, int count) {
    if (column + 1 < board.GetLength(1)) {
        string token = board[row, column + 1];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (column + 2 < board.GetLength(1)) {
                string token2 = board[row, column + 2];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                    Console.WriteLine("Win 1");
                    return true;
                }
            }
        }
    }

    if (column - 1 >= 0) {
        string token = board[row, column - 1];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (count == 3) {
                    Console.WriteLine("Win 2");
                return true;
            }
            if (column - 2 >= 0) {
                string token2 = board[row, column - 2];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                    Console.WriteLine("Win 3");
                    return true;
                }
            }
        }
    }
   return false;
}

bool checkWinRow(string [,] board, int row, int column, int player, int count) {
    if (row + 1 < board.GetLength(0)) {
        string token = board[row + 1, column];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (row + 2 < board.GetLength(0)) {
                string token2 = board[row + 2, column];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                Console.WriteLine("Win here 0");
                    return true;
                }
            }
        }
    }

    if (row - 1 >= 0) {
        string token = board[row - 1, column];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (count == 3) {
                Console.WriteLine("Win here");
                return true;
            }
            if (row - 2 >= 0) {
                string token2 = board[row - 2, column];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                Console.WriteLine("Win here 1");
                    return true;
                }
            }
        }
    }
   return false;
}

bool checkWinDiagonal(string [,] board, int row, int column, int player, int count) {
    if (row + 1 < board.GetLength(0) && column + 1 < board.GetLength(1)) {
        string token = board[row + 1, column + 1];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (row + 2 < board.GetLength(0) && column + 2 < board.GetLength(1)) {
                string token2 = board[row + 2, column + 2];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                    return true;
                }
            }
        }
    }
    if (row - 1 >= 0 && column - 1 >= 0) {
        string token = board[row - 1, column - 1];
        if ((player == 1 && token == "X") || (player == 2 && token == "O")) {
            count++;
            if (count == 3)
                return true;
            if (row - 2 >= 0 && column - 2 >= 0) {
                string token2 = board[row - 2, column - 2];
                if ((player == 1 && token2 == "X") || (player == 2 && token2 == "O")) {
                    return true;
                }
            }
        }
    }
    return false;

}

bool checkWin(string [,] board, int row, int column) {
    int count = 1;
    int player = 0;

    if (board[row, column] == "X") {
        player = 1;
    } else if (board[row, column] == "O") {
        player = 2;
    }

    if (checkWinRow(board, row, column, player, count)) {
        Console.WriteLine("Win Row");
        return true;
    }

    if (checkWinColumn(board, row, column, player, count)) {
        Console.WriteLine("Win Col");
        return true;
    }

    if (checkWinDiagonal(board, row, column, player, count)) {
        Console.WriteLine("Win Diag");
        return true;
    }
    return false;

}

int getPos() {
    return Convert.ToInt32(Console.ReadLine()) - 1;
}

void StartMorpion() {
    string [,] board = generateBoard(3, 3);
    int player = 1;
    int row = 0;
    int column = 0;
    bool win = false;
    int nbrTurn = 0;

    while (!win && nbrTurn < 9) {
        nbrTurn++;
        draw2DimTab(board);
        Console.WriteLine("Player " + player + " turn");
        Console.WriteLine("Row : ");
        row = getPos();
        Console.WriteLine("Column : ");
        column = getPos();

        while (!CheckPosToken(board, row, column)) {
            Console.WriteLine("You can't place a token here, retry");
            Console.WriteLine("Row : ");
            row = getPos();
            Console.WriteLine("Column : ");
            column = getPos();
        }

        if (player == 1) {
            PlaceToken(board, row, column, "X");
            player = 2;
        } else {
            PlaceToken(board, row, column, "O");
            player = 1;
        }

        if (checkWin(board, row, column)) {
            win = true;
            Console.WriteLine("Player " + player%2 + 1 + " win !");
        }
    }
    draw2DimTab(board);
    if (!win)
        Console.WriteLine("Draw");
}

void main() {
    StartMorpion();
}

main();