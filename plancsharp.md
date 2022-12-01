---
marp: true
paginate: true
theme: gaia

backgroundImage: url(./Ressources/Theme/Diapo.png)
_backgroundImage: url(./Ressources/Theme/Title.png)
---

<link href="./Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(./Ressources/Theme/Title.png) -->

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

Si vous demandez a un utilisateur de mettre le nom d'une voiture en input; vous stockerez cette valeur dans une string et vous la nommerez en rapport avec l'objet de votre demande, ici une voiture: 

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


### Methode de base contenue dans les tableaux

### Attributs de base contenue dans les tableaux

### Les reference s'applique t-elle dans les tableaux?


## Logique

### Condition

#### If

#### Else

#### Operateur Booleen

##### ET

##### OU

##### Priorite des parenthese

##### Table de verite

### Boucle

#### While

#### For each

## function

### Image : une usine avec tapis roulant entree et tapis roulant de sortis

### Block de code, Organiser son code pour plus de clarete

#### Scope
<!-- rappel sur les variables dans le scopes et en dehor -->

### parameter

#### Parametre passer

#### Parametre par default

### Retour

#### Type de retour

#### Associer le retour d'une fonction a une variable


## Reference

### Qu'est ce qu'une reference?

### Quand utiliser la reference de ma variable

### Comment utiliser la reference de ma variable



### Librairie

### Random

### Dictionnaire

#### Cle Valeur

#### Fonction recherche


# Pourquoi POO

# Les classes

## Encapsulation

### Private

### Public

## Attributs

### getter / setter

### Static

## Methode

### Static

### Overload

## Constructeur

### Parametres

### Overload

## Destructeur

# Heritage

## Constructeur parent

## Heritage simple

## Protected

## Classes abstraites

### Override

## Interfaces

### Override
