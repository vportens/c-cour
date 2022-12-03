---
marp: true
paginate: true
theme: gaia

backgroundImage: url(./Ressources/Theme/Diapo.png)
_backgroundImage: url(./Ressources/Theme/Title.png)
---

<link href="./Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(./Ressources/Theme/Title.png) -->


<!-- Tout le code saisit dans ce cour est du CSharp -->

# Variable

---

## Qu'est-ce qu'une variable ?
Une variable est une zone mémoire dans laquelle on pourra stocker une valeur. 


Elle est compose de 3 éléments :
* un nom
* un type
* une valeur

---

## Déclaration d'une variable

Pour declarer une variable on associer un type a un nom.
Avant d'associer celui-ci a une valeur.
Pour etre capable de bien associer une variable a une valeur, il faut deja comprendre les types,

---

# Type

---

## Qu'est-ce qu'un type ?

Un type est une facon de classer les variables. Il exite plusieurs types de variables :
* `int` : nombre entier
* `float` : nombre a virgule
* `string` : chaîne de caractères
* `bool` : booléen (vrai ou faux)

---

## Pourquoi utiliser des types ?
<!-- TODO : sperater la slide -->
Les types permettent de classer les variables, et de les utiliser plus facilement. 

Par exemple, si on a une variable de type `int`, on pourra l'utiliser pour stocker des nombres entiers. Si on a une variable de type `string`, on pourra l'utiliser pour stocker des chaînes de caractères.

Si on demande a l'utilisateur d'entrer un texte, on va stocker cette valeur dans une variable de type `string` et non `int`.

Et par exemple, on ne peut pas additionner une chaine de caractères avec un nombre.

---

## Int

Le type `int` est le type pour les nombres entiers. Un nombre entier est un nombre qui ne contient pas de virgule. Il peut aussi etre negatif.
Exemple : `125`, `0`, `-12`

---

## Float

Le type `float` est le type pour les nombres a virgule. Un nombre a virgule est un nombre qui contient une virgule. Il peut aussi etre negatif.
Exemple : `1.025`, `0.0`, `-12.256`

---

## String

Le type `string` est le type pour les chaines de caractères. Une chaine de caractères est une suite de caractères qui forme un mot ou une phrase.
Exemple : `"hello world"`, `"hello"`, `"world"`

---

## Bool

Le type `bool` est le type pour les valeurs booléennes. Une valeur booléenne est une valeur qui est vrai ou fausse.
Exemple : `true`, `false`

---

## Exemple de declaration

```csharp
int nom_de_variable = 12;
float variable_floating_point = 2.0;
string what_ever_name = "bonjour les amiches";
bool name_true_false = true;
```

Il faut bien comprendre ici que le nom des variables est libre de choix.

Mais pour autant il ne faut pas mettre n'importe quoi, car celle ci participe a la clarete de votre code.

---

#### Importance de choisir ses nom de variable

Vous demandez a un utilisateur de mettre le nom d'une voiture en input

Vous stockerez cette valeur dans une string et vous la nommerez en rapport avec l'objet de votre demande, 
 
Une voiture: 

```csharp
string marque_voiture;
string car_brand;
string brand_car;
string car_name;
```
 ---

### Exercice sur les variables

1. Creer une variable `age` de type `int` et lui assigner une valeur.
2. Creer une variable `name` de type `string` et lui assigner une valeur.
3. Creer une variable `isAdult` de type `bool` et lui assigner une valeur.
4. Creer une variable `height` de type `float` et lui assigner une valeur.

5. Afficher la valeur de chaque variable avec la fonction `Console.WriteLine(nom_de_variable)`

---
### Exercice solution

```csharp
int age = 20;
string name = "Jean";
bool isAdult = true;
float height = 1.83;

Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isAdult);
Console.WriteLine(height);
```

---
### Exercice sur le nommage des variables 

1. Vous possedez un cafe et vous voulez automatiser la visualisation de certain chiffre. Pour cela vous demandez au server du jour de rentrer le nombre de cafe servit, la quantite en graine (en gramme) utilise, le nombre de client servit et le nom du server, pour un programme que vous avez confectionne. Creer des variable adapter a chaqu'une des ses informations et nommer judicieusement.
---
2. Bob, Richard et Mark sont pecheur sur le meme bateau. Ils font la competion du nombre de poisson peche et du poids total peche. Le capitain leur propose de creer un petit programme dans lequel chaqu'un rentrera leurs nom, suivit du nombre de poisson peche aujourd'hui ainsi que le poids total de leurs prise du jours. Creer deux variables pour chaqu'un de et nommez les.
---


---

### Lecture

Une fois ma variable declare, elle pourra etre utilise tout au long de mon programme. Pour cela nous utiliserons son mon sans avoir a redefinir son type.

---

#### Comment utiliser ma variable

Pour utiliser une variable, c'est a dire acceder a la valeur stocker dans celle-ci, il suffit de l'appeler par son nom.
Pour autant, nous ne pouvons pas redefinir son type apres declaration.

```csharp
int nom_de_variable;

nom_de_variable = 153;

Console.WriteLine(nom_de_variable); // affichera 153
// nom_de_variable = "bonjour"   --> erreur car "bonjour" est une string et non un int
```

---

### Attribution

Pour affecter une valeur a une variable, nous utiliserons l'operateur `=`.
Cet operateur permet d'affecter une valeur a une variable.

---

#### Comment associer une valeur a ma variable

Il est possible de redefinir la valeur d'une variable en lui attribuant une nouvelle valeur.

```csharp
int nom_de_variable;

nom_de_variable = 153;
Console.WriteLine(nom_de_variable); // affichera 153

nom_de_variable = 12;
Console.WriteLine(nom_de_variable); // affichera 12
```

---

## Les operateurs 

Les operateurs sont des symboles qui permettent d'effectuer des operations sur des variables ou des valeurs.
Nous avons vu precedement l'operateur d'assignation `=`
pour associer une variable a une valeur.
Mais il en existe pour faire des operation aritmetiques, pour comparer des variables, pour en incrementer et pour concatener.

---

## Les operations arithmetiques

Il est possible d'effectuer des operations sur les variables.

### Addition

Pour additionner deux variables, nous utiliserons l'operateur `+`.

```csharp
int a = 3;
int b = 5;

int c = a + b;
Console.WriteLine(c); // affichera 8
```

---

### Soustraction

Pour soustraire deux variables, nous utiliserons l'operateur `-`.

```csharp
int a = 3;
int b = 5;

int c = a - b;
Console.WriteLine(c); // affichera -2
```

---

### Multiplication

Pour multiplier deux variables, nous utiliserons l'operateur `*`.

```csharp
int a = 3;
int b = 5;

int c = a * b;
Console.WriteLine(c); // affichera 15
```

---

### Division

Pour diviser deux variables, nous utiliserons l'operateur `/`.

```csharp
int a = 3;
int b = 5;

int c = a / b;
Console.WriteLine(c); // affichera 0
```

---

### Modulo

Pour calculer le reste d'une division entre deux variables, nous utiliserons l'operateur `%`.

```csharp
int a = 31;
int b = 5;

int c = a % b;
Console.WriteLine(c); // affichera 1
```

---

## Operations de comparaisons

La comparaison de variable est au coeur des boucles logiques et conditionnelles, elle vous permettera de comparer deux variables. 

Le retour d'une comparaison est une variable `bool` true ou false en fonction de la verite de comparaison.

---


### Egalite

Pour comparer si deux variables sont egales, nous utiliserons l'operateur `==`.

```csharp
int a = 3;
int b = 5;

bool c = a == b;
Console.WriteLine(c); // affichera false
```

---

### Superieur

Pour comparer si une variable est superieur a une autre, nous utiliserons l'operateur `>`.

```csharp
int a = 3;
int b = 5;

bool c = a > b;
Console.WriteLine(c); // affichera false
```

---

### Inferieur

Pour comparer si une variable est inferieur a une autre, nous utiliserons l'operateur `<`.

```csharp
int a = 3;
int b = 5;

bool c = a < b;
Console.WriteLine(c); // affichera true
```

---

### Superieur ou egal

Pour comparer si une variable est superieur ou egal a une autre, nous utiliserons l'operateur `>=`.

```csharp
int a = 3;
int b = 5;

bool c = a >= b;
Console.WriteLine(c); // affichera false
```

---

### Inferieur ou egal

Pour comparer si une variable est inferieur ou egal a une autre, nous utiliserons l'operateur `<=`.

```csharp
int a = 3;
int b = 5;

bool c = a <= b;
Console.WriteLine(c); // affichera true
```

---


### Operateurs d'incrementation

En informatique, l'incrémentation est l'opération qui consiste à ajouter 1 à un compteur.

Pour incrementer une variable de 1, nous utiliserons l'operateur `++`.

```csharp
int a = 3;

a++;
Console.WriteLine(a); // affichera 4
```

---

### Operateurs de decrementation

L'opération inverse, la décrémentation, consiste à retirer 1 au compteur
Pour decrementer une variable de 1, nous utiliserons l'operateur `--`.

```csharp
int a = 3;

a--;
Console.WriteLine(a); // affichera 2
```

---

### Operateur incrementation de n


Pour incrementer une variable de n, nous utiliserons l'operateur `+=`.

```csharp
int a = 3;

a += 5;
Console.WriteLine(a); // affichera 8
```

---

### Operateur decrementation de n

Pour decrementer une variable de n, nous utiliserons l'operateur `-=`.

```csharp
int a = 3;

a -= 5;
Console.WriteLine(a); // affichera -2
```

---

### Operateurs de concatenation

Pour concatener deux chaines de caracteres, nous utiliserons l'operateur `+`.

```csharp
string a = "Hello";
string b = "World";

string c = a + b;
Console.WriteLine(c); // affichera HelloWorld
```

---

<!-- fin de cour faire tp pratique  -->
---

## Scope

Le Scope  | La portee


{

}

---

### Qu'est ce que le scope et en quoi impact-il nos variables

Le scope est la portee d'une variable, portee geographique, c'est a dire ou la variable est visible dans le code.
Les variables déclarées dans une :
-  boucle ne peuvent être utilisées que dans cette boucle.
-  fonction ne peuvent être utilisées que dans cette fonction.

---

Exemple:
```csharp
int a = 3;
{
	int b = 5;
	Console.WriteLine(a); // affichera 3
	Console.WriteLine(b); // affichera 5
}
Console.WriteLine(b); // affichera une erreur
```

Ici, `b` est declare dans des accolades `{ }`, et n'est donc accessible qu'au sein de ces `{ }`. C'est pour ca que nous avons une erreur au second `Console.WriteLine(b)`


---

### Variable global 

Une variable global est une variable declaree en dehors de tout scope. Elle est donc accessible partout dans le code.

Dans l'exemple ci dessus, `a` est une varible globale car elle est declarer en dehor de tout scope (`{ }`), et est accessible partout (toujours ci dessus nous avons acces a `a` dans le meme scope ou est declare `b`)



---

### Variable locale

Une variable locale est une variable declaree dans un scope, et qui ne peut etre utilisee que dans ce scope.

`b` est une variable dite locale a son scope.

```csharp
int a = 3;
{
	int b = 5;
	Console.WriteLine(a); // affichera 3
	Console.WriteLine(b); // affichera 5
}
Console.WriteLine(b); // affichera une erreur
```

---

### Scope dans un scope

---

Exemple:

```csharp
{       // debut du premier scope 
	int a = 3;
	Console.WriteLine(a); 
    {       // debut du scope 2 
        int b = 4;
        Console.WriteLine(a);
        Console.WriteLine(b);
        {       // debut du scope 3
            int c = 6;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }       // fin du scope 3
                // variable c n'est plus accessible ici !! 
    }   // fin du scope 2
        // variable b n'est plus accessible ici !!
}       // fin du premier scope 
```

---

Une variable est definie dans son scope comme vu precedement et ce scope possedera toutes les entitees presente dans celle-ci. 

C'est pour ca que le programme ci dessus fonctionne et affiche bien les resultats attendus

---

<!-- TODO : exercice pour le scope -->

---

## [] : Tableau

---

### Definition

Un tableau est une collection d'entitees du meme type. Chaque entitee est accessible via un index.

Un tableau peut etre visualise comme un coffre qui contient d'autre coffre.

---

### Comment declarer un tableau


Pour declarer un tableau, nous utiliserons la syntaxe suivante:

```csharp
type[] nomTableau = new type[taille];
```

2 nouveaux elements ici : 
- `[]`
- `new`  

`taille` correspond au nombres d'element dans mon tableau

---

### Exemple de declaration de tableaux: 

```csharp
int[] tableau_int = new int[10]; // tableau de 10 entiers

string[] tableau_string = new string[12]; // tableau de 12 string  

`````

---

### Remplir un tableau

Pour remplir un tableau, nous utiliserons la syntaxe suivante:

```csharp
nomTableau[index] = valeur;
```

Le premier index de mon tableau est 0.



---

### Exemple de remplissage de tableau:

```csharp
int[] tableau_int = new int[4]; // tableau de 4 entiers

tableau_int[0] = 3; //index = 0, valeur = 3;
tableau_int[1] = 5;
tableau_int[2] = 7;
tableau_int[3] = 9;
```

---

### Initialisation lors de la declaration 
Vous pouvez éviter l’expression `new` et le type de tableau lorsque vous initialisez un tableau lors de la déclaration, comme indiqué dans le code suivant.

```csharp
int[] array2 = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
```

---

### Acceder a la valeur dans le tableau

Pour acceder a la valeur dans le tableau, nous utiliserons la syntaxe suivante:

```csharp
nomTableau[index]
```

!! Le premier index de mon tableau est 0.

---

### Exemple d'acces a la valeur dans un tableau:

```csharp
int[] tableau_int = new int[4]; // tableau de 4 entiers

tableau_int[0] = 3; //index = 0, valeur = 3;
tableau_int[1] = 5;
tableau_int[2] = 7;
tableau_int[3] = 9;

Console.WriteLine(tableau_int[0]); // affichera 3
Console.WriteLine(tableau_int[1]); // affichera 5
Console.WriteLine(tableau_int[2]); // affichera 7
Console.WriteLine(tableau_int[3]); // affichera 9
```

---


### Methode de base contenue dans les tableaux

Un tableau en C# est un object qui possede des certaines propriete deja integre.
Pour les tableaux, la principal et la plus utilise est :
- `Length` : retourne la taille du tableau

Principalement utilise pour parcourir votre tableau.

---

Exemple

```csharp
int[] tableau_int = new int[4]; // tableau de 4 entiers

tableau_int[0] = 3; // index commence a 0
tableau_int[1] = 5;
tableau_int[2] = 7;
tableau_int[3] = 9;

Console.WriteLine(tableau_int.Length); // affichera 4
```

---


## Logique

---

### Condition

Une condition est une expression qui retourne un `booleen (true ou false)`.

En fonction de la valeur de la condition, un bloc de code sera execute (`true`) ou non (`false`).

Tout les operateurs de Comparaison peuvent etre utilise dans les condition 

<!-- TODO link vers les operateur de comparaison -->

---

| Operateur de comparaison| Signification |
|-----------|---------------|
| ==        | egal a        |
| !=        | different de  |
| >         | superieur a   |
| >=        | superieur ou egal a |
| <         | inferieur a   |
| <=        | inferieur ou egal a |


---

#### If

La condition la plus simple est le `if` qui permet d'executer un bloc de code si la condition est vrai.

```csharp
if (condition 1)
{
	// code a executer si la condition 1 est vrai
}
```

---

#### Else

La condition `else` permet d'executer un bloc de code si la condition est fausse.

```csharp
if (condition 1)
{
	// code a executer si la condition 1 est vrai
}
else
{
	// sinon, code a executer si la condition 1 est fausse
}
```

---

#### Else if

La condition `else if` permet d'executer un bloc de code si la condition est fausse et que l'on souhaite verifier une autre condition.

```csharp
if (condition 1)
{
	// code a executer si la condition 1 est vrai
}
else if (condition 2)
{
	// sinon, code a executer si la condition 1 est fausse et que condition 2 est vrai
}
else
{
	// code a executer si la condition 1 est fausse et que condition 2 est fausse
}
```

---

### Exemple 

```csharp
int a = 5;
int b = 10;

if (a > b)
{
	Console.WriteLine("a est superieur a b");
}
else if (a < b)
{
	Console.WriteLine("a est inferieur a b");
}
else
{
	Console.WriteLine("a est egal a b");
}
```

---

### Exercice

```csharp
int ton_age = mettre ton age;
int nombre_denfant = mettre ton nombre d enfant;

1 Creer une condition pour verifier si tu es majeur.
Elle affichera \(avec Console.WriteLine\) si tu es majeur ou si tu es mineurs

2 Creer une ou plusieur conditions pour verifier si \:
tu n as pas d enfant,       // afficher je n'est pas d'enfant 
3 tu as moins de 3 enfants mais tu as des enfants,   // afficher j'ai nbr d enfant
4 tu as 4 ou moins mais plus que 2,   // j'ai plus que 2 enfant mais ce n'est pas une famille nombreuse
5 tu as plus que 4 enfants, // j'ai une famille nombreuse

```

---

### reponse 

```csharp
int ton_age = mettre ton age;
int nombre_denfant = mettre ton nombre d enfant;

if (ton_age >= 18) 
{
	Console.WriteLine("Tu es majeur");
}
else
{
	Console.WriteLine("Tu es mineur");
}

if (nombre_denfant == 0) // condition 1
{
	Console.WriteLine("Je n'ai pas d'enfant");
}
else if (nombre_denfant < 3) // si condition 1 fausse, condition 2
{
    // autre possibilite, nbr_denfant <= 2
	Console.WriteLine("J'ai " + nombre_denfant + " enfant");
}

```

---

```csharp

else if (nombre_denfant <= 4) // condition 3
{
	Console.WriteLine("J'ai plus que 2 enfant mais ce n'est pas une famille nombreuse");
}
else // condition 4 , si aucun des conditons etaient bonne
{
	Console.WriteLine("J'ai une famille nombreuse");
}
```

--- 

#### Operateur Booleen

Les operateurs booleen permettent de combiner des conditions.

| Operateur | Signification |
|-----------|---------------|
| &&        | ET            |
| \|\|      | OU            |
| !         | NON           |

##### ET

L'operateur ET permet d'executer un bloc de code si les deux conditions sont vrais.

```csharp
if (condition 1 && condition 2)
{
	// code a executer si les deux conditions sont vrais
}
```

##### OU

L'operateur OU permet d'executer un bloc de code si une des deux conditions sont vrais.

```csharp
if (condition 1 || condition 2)
{
	// code a executer si une des deux conditions sont vrais
}
```

---

##### NON

L'operateur NON permet d'inverser la valeur de la condition.

```csharp
if (!condition)
{
	// code a executer si la condition est fausse
}
```
---

### Exercice 
<!-- Creer un exercice ou on devrat utiliser if avec des operateurs booleen && || -->


```csharp
int nbr_pizza = 14;
int nbr_couvert = 30;
int nbr_personne = 12;

1 Creer une condition qui verifie : 
	- tout les mondes aura 2 couvert au moins 
		ET
	- tout le mondes aura 1 pizza au moins

2 Creer une condition qui verifie : 
	- tout les mondes aura 2 couvert au moins 
		OU
	- tout le mondes aura 1 pizza au moins



```

<!-- TODO : exercice -->

---

##### Priorite des parenthese

Les operateurs booleen sont evalue de gauche a droite dans une condition. 

Les parenthese `()` fonctionne en informatique comme en mathematique.
La priorite de la condition se dirige dans la parenthese en 1er.


---

##### Table de verite


| A | B | A && B |
|---|---|--------|
| Vrai | Vrai | Vrai     |
| Vrai | Faux | Faux     |
| Faux | Vrai | Faux     |
| Faux | Faux | Faux     |

---

| A | B | A \|\| B |
|---|---|--------|
| Vrai | Vrai | Vrai     |
| Vrai | Faux | Vrai     |
| Faux | Vrai | Vrai     |
| Faux | Faux | Faux     |

---

| A | !A |
|---|---|
| Vrai | Faux |
| Faux | Vrai |

---

### Exercice 

Reprendre l'exercice precedent en ajoutant la derniere condition :

```csharp

3 Creer une condition qui verifie : 
	- tout le monde aura 2 couvert au moins 
		ET
	- tout le monde aura 1 pizza au moins
		ET
			- il y a plus de 20 couvert
				OU	
			- il y a plus de 10 personne
```


---
<!-- TODO : exercice -->

### Boucle

Une boucle permet d'executer plusieurs fois un bloc de code, tant que la condition est vraie.



---

#### Boucle while

La boucle while permet de repeter un bloc de code tant qu'une condition est vrais.

```csharp
while (condition) // tant que la condition est vraie
{
	// bloc de code a repeter
}
```

---

### Exemple pratique 
Les boucles `while` sont tres pratique pour par exemples iterer sur un tableau.

Rappel, 
Un tableau possede plusieur elements d'un meme type;
Un tableau possede une fonction qui permet de connaitre sa longeur : `.Lenght`;

---

```csharp
// parcourir son tableau avec un boucle while 
int[] tableau = { 1, 2, 3, 4, 5 };

int index = 0;
while (index < tableau.Lenght) // tant que index est plus petit que la longeur du tableau
{
	Console.WriteLine(tableau[i]); // afficher l'element i du tableau
	index++; // augmenter index de 1
}
```

A partir de maintenant nous utiliserons une convention de code pour nommer une variable `index` : `i`

---


#### Boucle foreach

La boucle for each permet de parcourir un tableau sans avoir besoin de connaitre sa longeur.

```csharp
foreach (type element in tableau)
{
	// bloc de code a repeter
}
```
  



Mots clefs :
- `foreach`
- `in`

---

```csharp
// parcourir son tableau avec un boucle while 
int[] tableau = { 1, 2, 3, 4, 5 };

foreach (int elems in arr)
{
	Console.WriteLine(tableau[elems]); // afficher l'element elems du tableau
	
}
```

On vois bien ici, contrairement a la boucle `while`, `elems` s'incremente automatiquement a la fin du bloc conditionnelle.

---
<!-- TODO : exercice  -->
--- 

## function

Les fonctions sont des blocs de code qui peuvent etre appelé n'importe quand dans le code.

Une fonction est une serie d'instruction qui permet de realiser une tache precise.

Elle peut recevoir un ou des `parametres` en entree et peut renvoyer une variable en sortie, le `retour`.


---

### Visualiser une fonction 

Une fonction peut etre vu comme une usine avec tapis roulant d'entre (`parametres`) et tapis roulant de sortis (`retour`).

On donne un ou des matiere premiere a l'usine en entree (`parametres`), et l'usine nous resortira un produit fini (`retour`).

---

### Block de code, Organiser son code pour plus de clarete

Une fonction permet d'organiser son code pour plus de clareté, de separer les taches en bloc precie.

```csharp
void Main()
{
	// code principal
}
void fonction1()
{
	// code de la fonction 1
}
void fonction2()
{
	// code de la fonction 2
}
```

---

#### Scope de fonction
<!-- rappel sur les variables dans le scopes et en dehor -->

Les variable creer dans une fonction ne sont pas visible dans les autres fonctions.
La fonction va declarer son scope, donc son champ d'action.

```csharp
void Main()
{
	int a = 1;
	fonction1();
	Console.WriteLine("var in main " + a); // affiche 1
}
void fonction1()
{
	int a = 2;
	Console.WriteLine("var in function " + a);
}
```

---

### Parameteres passe

Les parametres sont l'entree d'une fonction, ils permettent de passer des variables a la fonction.

```csharp
void main()
{
	int a = 3;
	int b = 8;
	function1(a, b);
}
void fonction1(int a, int b)
{
	Console.WriteLine(a + b); // affiche 11;
}
```

---

Le nom des parametres n'est pas obligatoirement identique a celle passer dans la fonction.

Ils seront, dans la fonction, generique pour pouvoir etre claire.

Le Type par contre doit etre le meme.


---

### Exemple

```csharp
void main()
{
	int a = 3;

	square(a);
	print(a);
}

void square(int number_to_quare)
{
	Console.WriteLine(a * a); // affichera 9;
}

void print(string str) // error, parametre string, parametre passe int 
{
	Console.WriteLine(str); // affichera la string;
}
```

---


#### Parametre par default

Les parametres peuvent avoir une valeur par default, si il n'est pas passer a la fonction.

```csharp
void main()
{
	int a = 3;
	int b = 8;
	function1(a, b);  // affichera 11
	function1(a);	// affichera 5
}
void function1(int a, int b = 2)
{
	Console.WriteLine(a + b);
}
```

---

### Retour fonction 

Une fonction peut renvoyer un resultat, ce resultat est un `type` de variable.

Ce `type` est place devant le nom de la fonction, et celle ci ne pourra renvoyer que ce `type`.

On utilisera le mot clef `return` suivit de la variable que l'on voudra retourner.

```csharp

retour type 		fonction_name( parametre, ...) {
	return variable_name ;
}

```
--- 

Si une fonction ne renvoie rien, on dit qu'elle est de type `void`.

Exemple : 
```csharp
void main() 
{
	int a = 3;
	int b = 8;
	Console.WriteLine(square(a)); // affichera 9
	Console.WriteLine(square(b)); // affichera 64

}
int square(int x) 
{
	return (x * x);
}
```



---

#### Associer le retour d'une fonction a une variable

On peut associer le retour d'une fonction a une variable.

```csharp
void main() 
{
	int a = 3;
	int b = 8;
	int x = square(a);
	int y = square(b);
	Console.WriteLine(x); // affichera 9
	Console.WriteLine(y); // affichera 64
}
int square(int x) 
{
	return (x * x);
}
```

---

<!-- TODO : exercice plus simple -->

---

<!-- gros exercice -->
### Exercice

- Creer une fonction qui prend en parametre un tableau d'entier, et qui renvoie le plus grand element du tableau.
- Creer une fonction qui prend en parametre un tableau d'entier, et qui renvoie la somme de tous les elements du tableau.


---

## Reference

---

### Qu'est ce qu'une reference?

Une reference permet d'acceder a la variable et la modifier en dehor de son scope dans des fonctions.


---

### Quand utiliser la reference de ma variable

La reference est utile dans des fonctons qui ont pour but de modifier les variables en parametre.


En C# certaines variable comme les `tableaux` sont de type reference de base. 

Les variables classiques, `int `, `float` , `string` ne le sont pas.

### Exemple de comprehension
---
```csharp
main();

void function1(int[] arr) {
    arr[0] = 100;
};
void function2(int num) {
    num = 10;
};

void main() {

    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int num = 18;

	Console.WriteLine("before go to fonction1 " + arr[0]); // affiche 1
	Console.WriteLine("before go to fonction2 " + num);  // affiche 18

    function1(arr);
    function2(num);


    Console.WriteLine("after fonction1 "+ arr[0]); // affiche 100
    Console.WriteLine("after fonction2 "+ num); // afficher 18

};
```

---


### Comment utiliser la reference de ma variable

Mot clef `ref` devant le type de la variable dans les parametre de la fonction.

---

```csharp
main();

void function1(ref int num) { // mot clef ref
    num = 1000;
};

void main() {

    int num = 18;

    Console.WriteLine("before go to fonction2 " + num); // affichera 18
    function1(ref num); // mot clef ref
    Console.WriteLine("after fonction2 "+ num); // affichera 1000

};
```

---

### Exercice avec les references

Ecrire une fonction `is_Billi` qui prend en parametre une reference sur string, renvoie un boolen.
La fonction verifie si l'argument est egale a `Billi` est renvera `true` si vrai.
Sinon modifier l'argument pour le transforme en `Billi` et renvoyer false.

---

### Librairie

Une librairie est un ensemble de fonction deja ecrite, utilisable dans notre programme, reunit dans une classe.

Tout au long de ce cour nous avons utiliser `Console.WriteLine`, Console etant un classe avec des fonctions comme WriteLine.



---

### Random

La classe `Random` permet de generer des nombres aleatoires.

```csharp
Random rnd = new Random();
int x = rnd.Next(0, 100); // x est un nombre aleatoire entre 0 et 100
```

---

### Dictionnaire

La classe `Dictionary` permet de creer un tableau de `clef / valeur`.
Les avantages sont : 
- les methodes de base a dispositions.
- Le faites que le "tableau" soit extensible.
- La recherche des elements rapide.


---

### Declaration

Un dictionnaire ce declare avec 2 types;
Un type pour la `clef`, un pour la `valeur`.



```csharp
Dictionary<int , string> dict = new Dictionary<string, int>(); // int --> clef , string --> valeur
```

---

### Clef Valeur

Un dictionnaire associe une clef a une valeur.

Une clef est unique.
Pour rechercher une valeur, nous utiliserons sa clef comme index.


```csharp
Dictionary<int, string> dictionnaire = new Dictionary<int, string>();
dictionnaire.Add(1, "un");
dictionnaire.Add(2, "deux");
dictionnaire.Add(3, "trois");

Console.WriteLine(dictionnaire[1]); // affichera un
Console.WriteLine(dictionnaire[2]); // affichera deux
Console.WriteLine(dictionnaire[3]); // affichera trois
```

---



### Fonction recherche

La fonction `ContainsKey` permet de rechercher si une clef existe dans le dictionnaire.

```csharp
Dictionary<int, string> dictionnaire = new Dictionary<int, string>();
dictionnaire.Add(1, "un");
dictionnaire.Add(2, "deux");
dictionnaire.Add(3, "trois");

if (dictionnaire.ContainsKey(1)) {
	Console.WriteLine("La clef 1 existe dans le dictionnaire");
}
```

---

### Methode Dictionary


- `Add` : permet d'ajouter une clef / valeur
- `Remove` : permet de supprimer une clef / valeur
- `Clear` : permet de vider le dictionnaire
- `ContainsKey` : permet de verifier si une clef existe
- `ContainsValue` : permet de verifier si une valeur existe

---

### Qu'est ce que la POO (Programmation oriente object)

La programmation orienté objet est une methode de programmation qui permet de structurer un programme en `objet`.

Un objet est une representation d'une entite, comme une voiture, un chat, un humain, un programme, etc...

---

### Pourquoi POO (Programmation oriente object)

La POO permet de creer des objets qui ont des proprietes et des methodes.
Cela permet :
- Reutilisation du code
- Efficacite de l'appel de fonction
- Facilite la maintenance
- Facilite le depannage
- Facilite la lecture du code
- Facilite la modification du code

---

# Les classes


---

## Les classes
Une classe est une structure de donnees qui permet de definir un nouvel objet.


Une classe est un modele de données.

Exemple : `Console`, `Dictionary`, `Math`


---

## Declaration d'une classe

Une classe se declare avec le mot clef `class` suivi du nom de la classe.

```csharp
public class Personne { // Declaration d'une classe Personne
    // ...
}
```

---


## Classes privees et publiques 

Nous pouvons declarer les classes de deux manieres differentes, en utilisant les mots cles a mettre devant `class`: 
- `Public`
- `Private`



---


### Classe Private

Une classe private ne peut etre utiliser que dans la classe ou elle est declaree. Nous parlons ici de l'encapsulation d'une classe.

Car oui, une classe peut etre declarer dans une classe.

```csharp
private class Personne { // Classe private
    // ...
}
```

---

### Classe Public

Une classe public peut etre utilisee dans toute le programme.

```csharp
public class Personne { // Classe public
    // ...
}
```

---

### Attributs

Les attributs sont les variables d'une classe.
Elles peuvent elles aussi etre `public` ou `private`

```csharp
class Personne {
	public string nom;
	public int age;
	public string metier;
	private float taille ;
}
```

---

### Attributs private

De la meme maniere, un attribut private ne peut etre utiliser que dans la classe ou il est declare.

---

### Attributs public

Un attribut public peut etre utiliser dans toute le programme.

Exemple : 

```csharp
Car peugot  = new Car();
Console.WriteLine(peugot.wheel); // affichera 4
Console.WriteLine(peugot.serial_number); // error --> attribut private


public class Car{
    public int wheel = 4;
	private int serial_number = 3201244;
}
```

---

### Encapsulation 

L'encapsulation c'est le faite de donner ou non acces aux attributs a l'utilisateur.

Lorsque vous creez une classe, tout les attributs n'ont pas vocations a etre accessible par l'utilisateur.

Il est important d'organiser ses attributs priver/public pour proteger vos classes. Et garantir une meilleur experience a l'utilisateur.

---

### getter / setter 

Les getter et setter permet de definir le retour et l'attribution d'un attribut.

`get` va retourner un attribut, et `set` va declarer/initialiser un attribut.

`get` et `set` sont des fonctions.

---

### Utilisation get

Dans l'exemple precedent, une voiture aura toujours 4 roues, donc on pourrait definir le retour de `wheel` a 4.


```csharp
Car peugot  = new Car();
Console.WriteLine(peugot.wheel);

public class Car{
    public int wheel {
		get {return 4;} 
	}
}
```

---

Un getter peut aussi retourner une variable de classe (meme private vu qu'il s'agit d'une fonction au sein de la classes)

```csharp
Car peugot  = new Car();
Console.WriteLine(peugot.wheel);
Console.WriteLine(peugot.name);

public class Car{
	private string car_name = "peugot";
    public int wheel {
		get {return 4;} 
	}
	public string name {
		get { return car_name;}
	}
}
```
---

### Utilisation set

Le setter permet d'attribuer une valeur a une variable de classe.

```csharp
Car peugot  = new Car();
peugot.wheel = 15; // attribution ici
Console.WriteLine(peugot.wheel);
public class Car{
    private string carname = "peugot";
    private int _wheel;
    public int wheel {
		get {return _wheel;}
		set {_wheel = value;} // possible grace au set
	}
}
```


---

## Methode

Une methode est une fonction qui est declaree dans une classe.

Elle peut etre `public` ou `private`. (toujours pour rendre la methode utilisable en dehors de la classe ou non )


```csharp
Personne steve = new Personne();
Console.WriteLine(steve.Presentation());

public class Personne {
    public string nom = "Steve";
    public int age = 32;
    public string metier = "developper"; 
	private float taille = 1.76F; // F suffixe pour float
	
	public string Presentation() {
		return ("Je m'appel " + nom + ", j'ai " + age + " et mon metier est " + metier);
	}
}
```

--- 
### Methode avec des Parametres

Une methode peut prendre des parametres, tout comme une fonction.

```csharp
Personne steve = new Personne();
Console.WriteLine(steve.Presentation("Steve", 32, "developper"));

public class Personne {
    public string Presentation(string nom, int age, string metier) {
		return ("Je m'appel " + nom + ", j'ai " + age + " et mon metier est " + metier);
	}
}
```

---

### Overload

Une methode peut etre redefinie avec des argument differents. 

C'est ce qu'on appel l'overload (surcharge en FR?) de methode.

```csharp
Personne steve = new Personne();
Console.WriteLine(steve.Presentation("Steve", 32, "developper"));
Console.WriteLine(steve.Presentation("Steve", 32));

public class Personne {
    public string Presentation(string nom, int age, string metier) { // methode de base presentation
		return ("Je m'appel " + nom + ", j'ai " + age + " et mon metier est " + metier);
	}
	
public string Presentation(string nom, int age) { // overload de la methode presentation avec 2 arguments au lieu de 3
		return ("Je m'appel " + nom + ", j'ai " + age);
	}
}
```
 
--- 

## Constructeur

Un constructeur est une methode qui s'execute a l'instanciation d'une classe.

`new` permet d'instancier une classe.

Le constructeur permet d'instancier des variables de classe en meme temps que la declaration de la variable de classe.

Le constructeur est une methode qui porte le nom de la classe 

Passant de 

---

```csharp

Personne steve = new Personne();
Console.WriteLine(steve.nom);
public class Personne {
	public string nom = "Steve";
	public int age = 32;
	public string metier = "developper"; 
	private float taille = 1.76F; 
}

```

---

```csharp
Personne steve = new Personne();
Console.WriteLine(steve.nom);

public class Personne {
	public string nom;
	public int age;
	public string metier;
	private float taille;
	
	public Personne() { // constructeur
		nom = "Steve";
		age = 32;
		metier = "developper";
		taille = 1.76F;
	}
}
```	

---

### Parametres du constructeur
Le constructeur peut prendre des parametres, comme un fonction.

Toute les personnes ne s'appelle pas Steve et n'ont pas 32 ans.

Nous allons creer un constructeur qui va `set` notre personne, histoire de la rendre un peu plus unique


---

```csharp

Personne steve = new Personne("Steve", 32, "developper", 1.73F);
Console.WriteLine(steve.nom);

public class Personne {
    public string nom;
    public int age;
    public string metier;
	private float taille;
	
	public Personne(string c_nom, int c_age, string c_metier, float c_taille) { // constructeur
        nom = c_nom;
        age = c_age;
        metier = c_metier;
        taille = c_taille;
	}
}
```	

---

Maintenant vous pouvez creer une variable de type Personne en la nommant comme vous le souhaitez sans avoir a toucher au code dans la classe.


---

### Overload de Constructeur

Un constructeur peut etre redefini avec des argument differents. 
Comme une fonction.

C'est ce qu'on appel l'overload de constructeur.

---

```csharp
Personne steve = new Personne("Steve", 32, "developper", 1.73F);
Personne Lola = new Personne("Lola", 29);
Console.WriteLine(steve.nom);
Console.WriteLine(Lola.nom);

public class Personne {
    public string nom;
    public int age;
    public string metier;
	private float taille;
	
	public Personne(string c_nom, int c_age, string c_metier, float c_taille) { // constructeur
        nom = c_nom;
        age = c_age;
        metier = c_metier;
        taille = c_taille;
	}

	public Personne(string c_nom, int c_age) { // overload du constructeur
		nom = c_nom;
		age = c_age;
	}
}
```


---

### Static

---

### Attribut Static

Un attribut static est une variable qui appartient a la classe et non a l'objet.

Elle ne sera pas accessible via une variable; mais par le type.

---

```csharp
Console.WriteLine(Personne.nbPersonne); // affichera 0
Personne Bob = new Personne("Bob");
Console.WriteLine(Personne.nbPersonne); // affichera 1
// Console.WriteLine(Bob.nbPersonne); // affichera error
// car la static n'est pas accessible via Bob


public class Personne {
    public string nom;
    public static int nbPersonne = 0;

	public Personne(string c_nom) {
		nom = c_nom;
		nbPersonne++;
	}

}
```

---

<!-- EXERCICE -->
<!-- TODO : resumer de la day  -->
<!-- fin du jour -->

--- 

# Heritage

---

### Qu'es ce que l'heritage






## Constructeur parent

## Heritage simple

## Protected

## Classes abstraites

### Override

## Interfaces

### Override
