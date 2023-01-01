---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../Ressources/Theme/Diapo.png)
_backgroundImage: url(../Ressources/Theme/Title.png)
---

<link href="../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../Ressources/Theme/Title.png) -->


<!-- Tout le code saisit dans ce cour est du CSharp -->

# Variable

---

## Qu'est-ce qu'une variable ?
Une variable est une zone mémoire dans laquelle on peut stocker une valeur. 


Elle est composée de 3 éléments :
* un nom
* un type
* une valeur

---


## Déclaration d'une variable

Pour déclarer une variable on associe un type à un nom, avant d'associer celui-ci à une valeur.
Pour être capable de bien associer une variable à une valeur, il faut déjà comprendre les types.

Exemple : 
string name = "Victor"
string étant le type
name étant ma variable
Victor étant la valeur a laquelle ma variable est associer

---

# Type

---

## Qu'est-ce qu'un type ?

Un type est une façon de classer les variables. Il existe plusieurs types de variables :
* `int` : nombre entier
* `float` : nombre à virgule
* `string` : chaîne de caractères
* `bool` : booléen (vrai ou faux)

---

## Pourquoi utiliser des types ?
<!-- TODO : sperater la slide -->

Les types permettent de classer les variables, et de les utiliser plus facilement. 

Par exemple, si on a une variable de type `int`, on pourra l'utiliser pour stocker des nombres entiers. Si on a une variable de type `string`, on pourra l'utiliser pour stocker des chaînes de caractères.

Si on demande à l'utilisateur d'entrer un texte, on va stocker cette valeur dans une variable de type `string` et non `int`.

---

## Pourquoi utiliser des types ?

Et par exemple, on ne peut pas additionner une chaîne de caractères avec un nombre.

---

## Int

Le type `int` est le type pour les nombres entiers. Un nombre entier est un nombre qui ne contient pas de virgule. Il peut aussi être négatif.
Exemple : `125`, `0`, `-12`

---

## Float

Le type `float` est le type pour les nombres à virgule. 
Un nombre à virgule est un nombre qui contient une virgule. Il peut aussi être négatif.
Exemple : `1.025`, `0.0`, `-12.256`


---

## String

Le type `string` est le type pour les chaînes de caractères. 
Une chaîne de caractères est une suite de caractères qui forme un mot ou une phrase.
Exemple : `"hello world"`, `"hello"`, `"world"`

---

## Bool

Le type `bool` est le type pour les valeurs booléennes. 
Une valeur booléenne est une valeur qui est vraie ou fausse.
Exemple : `true`, `false`

---

## Exemple de déclaration


```csharp
int nom_de_variable = 12;
float variable_floating_point = 2.0f;
string what_ever_name = "bonjour les amiches";
bool name_true_false = true;
```


Il faut bien comprendre ici que le nom des variables est libre de choix.

Mais pour autant il ne faut pas mettre n'importe quoi, car celle ci participe à la clarté de votre code.

---

## Bien choisir ses noms de variable

Vous demandez à un utilisateur de mettre le nom d'une voiture en input

Vous stockerez cette valeur dans une string et vous la nommerez en rapport avec l'objet de votre demande, 

Une voiture: 

```csharp
string marque_voiture;
string car_brand;
string brand_car;
string car_name;
```
---

## Exercice sur les variables

1. Créer une variable `age` de type `int` et lui assigner une valeur.
2. Créer une variable `name` de type `string` et lui assigner une valeur.
3. Créer une variable `isAdult` de type `bool` et lui assigner une valeur.
4. Créer une variable `height` de type `float` et lui assigner une valeur.

5. Afficher la valeur de chaque variable avec la fonction `Console.WriteLine(nom_de_variable)`

---
## Exercice solution

```csharp
int age = 20;
string name = "Jean";
bool isAdult = true;
float height = 1.83f;

Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isAdult);
Console.WriteLine(height);
```

---
## Exercice sur le nommage des variables 

1. Vous possédez un café et vous voulez automatiser la visualisation de certains chiffres. Pour cela vous demandez au serveur du jour de rentrer le nombre de cafés servis, la quantité en graine (en grammes) utilisées, le nombres de clients servis et le nom du serveur, pour un programme que vous avez confectionné. 
Créez des variables adaptées à chacune de ces informations et nommez-les judicieusement.
---
## Exercice
2. Bob, Richard et Mark sont pêcheurs sur le même bâteau. Ils font la compétition du nombre de poissons péchés et du poids total péché. Le capitaine leur propose de créer un petit programme dans lequel chacun entrera leur nom, suivi du nombre de poissons péchés aujourd'hui ainsi que le poids total de leurs prise du jour. 
Créez deux variables pour chacun d'eux et nommez-les.
---



## Lecture

Une fois ma variable déclarée, elle pourra être utilisée tout au long de mon programme. Pour cela nous utiliserons son nom sans avoir à redéfinir son type.

---

## Comment utiliser ma variable

Pour utiliser une variable, c'est à dire accéder à la valeur stockée dans celle-ci, il suffit de l'appeler par son nom.
Pour autant, nous ne pouvons pas redéfinir son type après déclaration.

```csharp
int nom_de_variable;

nom_de_variable = 153;

Console.WriteLine(nom_de_variable); // affichera 153
// nom_de_variable = "bonjour"   --> erreur car "bonjour" est une string et non un int
```

---

## Attribution

Pour affecter une valeur à une variable, nous utiliserons l'opérateur `=`.
Cet opérateur permet d'affecter une valeur à une variable.

---

## Comment attribuer une valeur à ma variable

Il est possible de redéfinir la valeur d'une variable en lui attribuant une nouvelle valeur.

```csharp
int nom_de_variable;

nom_de_variable = 153;
Console.WriteLine(nom_de_variable); // affichera 153

nom_de_variable = 12;
Console.WriteLine(nom_de_variable); // affichera 12
```

---

## Les opérateurs 

Les opérateurs sont des symboles qui permettent d'effectuer des opérations sur des variables ou des valeurs.
Nous avons vu précédemment l'opérateur d'assignation `=`
pour associer une valeur à une variable.
Mais il en existe pour faire des opérations arithmétiques, pour comparer des variables, pour en incrémenter et pour concaténer.

---

## Les opérations arithmétiques

Il est possible d'effectuer des opérations sur les variables.

---

## Addition

Pour additionner deux variables, nous utiliserons l'opérateur `+`.

```csharp
int a = 3;
int b = 5;

int c = a + b;
Console.WriteLine(c); // affichera 8
```

---

## Soustraction

Pour soustraire deux variables, nous utiliserons l'opérateur `-`.

```csharp
int a = 3;
int b = 5;

int c = a - b;
Console.WriteLine(c); // affichera -2
```

---

## Multiplication

Pour multiplier deux variables, nous utiliserons l'opérateur `*`.

```csharp
int a = 3;
int b = 5;

int c = a * b;
Console.WriteLine(c); // affichera 15
```

---

## Division

Pour diviser deux variables, nous utiliserons l'opérateur `/`.

```csharp
int a = 3;
int b = 5;

int c = a / b;
Console.WriteLine(c); // affichera 0
```

---

## Modulo

Pour calculer le reste d'une division entre deux variables, nous utiliserons l'opérateur `%`.

```csharp
int a = 31;
int b = 5;

int c = a % b;
Console.WriteLine(c); // affichera 1
```

---

<!-- TODO : exercie operatation de variable basique -->

## Exercice 

1. Créer une variable pizza (entier) qui sera égale à 5.
2. Créer une variable part_de_pizza (entier) qui sera égale à 6.
3. Créer une variable nbr_part_de_pizza qui sera égale au nombre de pizza multiplier par part_de_pizza.

---
## Exercice

Vous etes 9 Personnes.

4. Créer une variable nbr_personne qui sera égale à 9.
5. Créer une variable part_de_pizza_par_personne, qui sera égale au nombre de part_de_pizza divisées par le nbr_personne.
6. Créer une variable part_de_pizza_restante qui sera égale au nombre de parts restantes après distribution (utilisez modulo)

---

## Solution 

```csharp
int pizza = 5;

int part_de_pizza = 6;

int nbr_part_de_pizza = pizza * part_de_pizza;

int nbr_personne = 9;

int part_de_pizza_par_personne = nbr_part_de_pizza / nbr_personne;

int part_de_pizza_restante = nbr_part_de_pizza % nbr_personne;
```

---

## Opérations de comparaisons

La comparaison de variables est au coeur des boucles logiques et conditionnelles, elle vous permettra de comparer deux variables. 

Le retour d'une comparaison est une variable `bool` true ou false en fonction de la vérité de comparaison.

---


## Egalite

Pour comparer si deux variables sont égales, nous utiliserons l'opérateur `==`.

```csharp
int a = 3;
int b = 5;

bool c = a == b;
Console.WriteLine(c); // affichera false
```

---

## Superieur

Pour comparer si une variable est supérieure à une autre, nous utiliserons l'opérateur `>`.

```csharp
int a = 3;
int b = 5;

bool c = a > b;
Console.WriteLine(c); // affichera false
```

---

## Inferieur

Pour comparer si une variable est inférieur à une autre, nous utiliserons l'opérateur `<`.

```csharp
int a = 3;
int b = 5;

bool c = a < b;
Console.WriteLine(c); // affichera true
```

---

## Supérieur ou égal

Pour comparer si une variable est supérieure ou égal ea une autre, nous utiliserons l'operateur `>=`.

```csharp
int a = 3;
int b = 5;

bool c = a >= b;
Console.WriteLine(c); // affichera false
```

---

## Inférieur ou égal

Pour comparer si une variable est inférieure ou égale à une autre, nous utiliserons l'opérateur `<=`.

```csharp
int a = 3;
int b = 5;

bool c = a <= b;
Console.WriteLine(c); // affichera true
```

---

<!-- TODO : exercice de comparaison de base -->
## Exercice  

Créer 4 variables, `a`, `b`, `c` et `d` de type `float` tel que :
- a = 1.5
- b = 5
- c = 1.5
- e = 0.5

---

## Exercice 
En utilisant l'opérateur `>` et 2 des 4 variables (`a`, `b`, `c`, `d`);
Créer 2 variables de type `bool` telque : 
- f = true
- g = false

---

## Exercice 

En utilisant l'opérateur `<` et 2 des 4 variables (`a`, `b`, `c`, `d`);
Créer 2 variables de type `bool` tel que : 
- h = true
- i = false

---
## Exercice 

En utilisant l'operateur `==` et 2 des 4 variables (`a`, `b`, `c`, `d`);
Créer 2 variables de type `bool` tel que : 
- j = true
- k = false

---

## Solution :

```csharp
float a = 1.5f;
float b = 5f;
float c = 1.5f;
float d = 0.5f;

bool f = b > a;
bool g = d > a;

bool h = c < b;
bool i = c < d;

bool j = a == c;
bool k = d == c;
```

---

## Opérateurs d'incrémentation

En informatique, l'incrémentation est l'opération qui consiste à ajouter 1 à un compteur.

Pour incrémenter une variable de 1, nous utiliserons l'opérateur `++`.

```csharp
int a = 3;

a++;
Console.WriteLine(a); // affichera 4
```

---

## Operateurs de decrementation

L'opération inverse, la décrémentation, consiste à retirer 1 au compteur
Pour décrementer une variable de 1, nous utiliserons l'opérateur `--`.

```csharp
int a = 3;

a--;
Console.WriteLine(a); // affichera 2
```

---

## Opérateur incrémentation de n


Pour incrémenter une variable de n, nous utiliserons l'opérateur `+=`.

```csharp
int a = 3;

a += 5;
Console.WriteLine(a); // affichera 8
```

---

## Opérateur décrementation de n

Pour décrementer une variable de n, nous utiliserons l'opérateur `-=`.

```csharp
int a = 3;

a -= 5;
Console.WriteLine(a); // affichera -2
```

---

## Opérateur décrementation de n
<!-- TODO : exercice incrementation de base -->
Créer deux variables `int`:  `salaire` et `solde_banque`

- Initialiser salaire à 1280 et solde_banque à 329.
- Incrémenter solde_banque de salaire

---

## Opérateur décrementation de n

Créer deux nouvelles variables `int` : `depense_course` et `loyer`
- Initialiser depense_course à 450
- Initialiser loyer à 600
- Décrémenter solde_banque de depense_course 
- Décrémenter solde_banque de loyer


---

## Opérateur décrementation de n

Vous avez une augmentation de salaire de 150
- Incrémenter votre salaire de 150

---

## Solution : 

```csharp
int salaire = 1280;
int solde_banque = 329;

solde_banque += salaire;

int depense_course = 450;
int loyer = 600;

solde_banque -= depense_course;
solde_banque -= loyer;

salaire += 150;

```


---

## Opérateurs de concatenation

Pour concatener deux chaînes de caractères, nous utiliserons l'opérateur `+`.

```csharp
string a = "Hello";
string b = "World";

string c = a + b;
Console.WriteLine(c); // affichera HelloWorld
```


<!-- fin de cour faire tp pratique  -->


---

## Scope

Le Scope  | La portée

```
{

}
```

---

## Qu'est-ce que le scope

Le scope est la portée d'une variable, portée géographique : c'est là où la variable est visible dans le code.
Les variables déclarées dans une :
-  boucle ne peuvent être utilisées que dans cette boucle.
-  fonction ne peuvent être utilisées que dans cette fonction.

---

## Exemple:
```csharp
int a = 3;
{
int b = 5;
Console.WriteLine(a); // affichera 3
Console.WriteLine(b); // affichera 5
}
Console.WriteLine(b); // affichera une erreur
```

Ici, `b` est déclaré dans des accolades `{ }`, et n'est donc accessible qu'au sein de ces `{ }`. C'est pour ça que nous avons une erreur au second `Console.WriteLine(b)`


---

## Variable globale 

Une variable globale est une variable declarée en dehors de tout scope. Elle est donc accessible partout dans le code.

Dans l'exemple ci-dessus, `a` est une varible globale car elle est déclarée en dehors de tout scope (`{ }`), et est accessible partout (toujours ci-dessus nous avons accès à `a` dans le même scope où est déclaré `b`)



---

## Variable locale

Une variable locale est une variable declarée dans un scope, et qui ne peut être utilisée que dans ce scope.

`b` est une variable dite locale à son scope.

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

# Scope dans un scope

---

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->

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

## Scope dans un scope

Une variable est définie dans son scope comme vu précédemment et ce scope possèdera toutes les entitées présente dans celle-ci. 

C'est pour ça que le programme ci-dessus fonctionne et affiche bien les résultats attendus

---

## Exercice
<!-- TODO : exercice pour le scope -->
Créer 3 variables globals telles que :
- `jean` une string initialisée à "Jean"
- `ville` une string initialisée à "Paris"
- `annee` un int initialisée à 1998

---

## Exercice

Créer un scope dans lequel seront instanciés :
- `annee2` un int égal à 1999
- `lea` une string égale à "Lea"


Créer un second scope dans le premier et instanciez :
- `fact_check` un boléen qui vérifiera `annee < anne2`;
- une string `copie_ville` qui sera égale à `ville`

---

## Solution : 

```csharp
string jean = "Jean";
string ville = "Paris";
int annee = 1998;
{
int annee2 = 1999;
string lea = "Lea";
{
	bool fact_check = annee < annee2;
	string copie_ville = ville;
}
}

```

<!-- TODO : 2nd exercice -->

---

# [] : Tableau

---

## Définition

Un tableau est une collection d'entitées du même type. Chaque entité est accessible via un index.

Un tableau peut être visualisé comme un coffre qui contient d'autres coffres.

---

## Comment déclarer un tableau


Pour déclarer un tableau, nous utiliserons la syntaxe suivante:

```csharp
type[] nomTableau = new type[taille];
```

2 nouveaux éléments ici : 
- `[]`
- `new`  

`taille` correspond au nombre d'éléments dans mon tableau

---

## Exemple de déclaration de tableaux: 

```csharp
int[] tableau_int = new int[10]; // tableau de 10 entiers

string[] tableau_string = new string[12]; // tableau de 12 string  

`````

---

## Remplir un tableau

Pour remplir un tableau, nous utiliserons la syntaxe suivante:

```csharp
nomTableau[index] = valeur;
```

Le premier index de mon tableau est 0.



---

## Exemple de remplissage de tableau:

```csharp
int[] tableau_int = new int[4]; // tableau de 4 entiers

tableau_int[0] = 3; //index = 0, valeur = 3;
tableau_int[1] = 5;
tableau_int[2] = 7;
tableau_int[3] = 9;
```

---

## Initialisation lors de la déclaration 
Vous pouvez éviter l’expression `new` et le type de tableau lorsque vous initialisez un tableau lors de la déclaration, comme indiqué dans le code suivant.

```csharp
int[] array2 = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
```

---

<!-- TODO : exercice declaration tableau basique -->
## Exercice : 

- Créer un tableau de string `mois` pour y mettre tous les mois de l'année et instanciez le.

---

## Solution : 

```csharp
string[] mois = {"janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };

--- reponce alternative

string[] mois = new string [12];
mois[0] = "janvier";
.
.
.
mois[11] = "decembre";

```

---



---

## Accéder à la valeur dans le tableau

Pour accéder à la valeur dans le tableau, nous utiliserons la syntaxe suivante:

```csharp
nomTableau[index]
```

!! Le premier index de mon tableau est 0.

---

## Exemple d'accès à la valeur dans un tableau:

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

## Exercie

Avec l'exercice précédent, 
Créer un tableau de string `mois_avec_e`, qui contiendra tous les mois qui possèdent un `e` dans leurs nom.
Celui-ci sera initialiser seulement à l'aide d'index et le tableau de `mois`.

---

## Solution :

```csharp
string[] mois = {"janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };

string[] mois_avec_e = new string [7];
mois_avec_e[0] = mois[0];
mois_avec_e[1] = mois[1];
mois_avec_e[2] = mois[6];
mois_avec_e[3] = mois[8];
mois_avec_e[4] = mois[9];
mois_avec_e[5] = mois[10];
mois_avec_e[6] = mois[11];


```

---

## Méthode de base

Un tableau en C# est un object qui possède des centaines de propriétés déjà intégrées.
Pour les tableaux, la principale et la plus utilisée est :
- `Length` : retourne la taille du tableau

Principalement utilisée pour parcourir votre tableau.

---

## Exemple

```csharp
int[] tableau_int = new int[4]; // tableau de 4 entiers

tableau_int[0] = 3; // index commence a 0
tableau_int[1] = 5;
tableau_int[2] = 7;
tableau_int[3] = 9;

Console.WriteLine(tableau_int.Length); // affichera 4
```

---

<!-- TODO : exercice acceder a des valeur dans des tableaux -->

---

# Logique

---

## Condition

Une condition est une expression qui retourne un `booleen (true ou false)`.

En fonction de la valeur de la condition, un bloc de code sera éxécuté (`true`) ou non (`false`).

Tous les opérateurs de comparaison peuvent être utilisé dans les conditions

<!-- TODO link vers les operateur de comparaison -->

---

</br>

| Opérateur de comparaison| Signification |
|-----------|---------------|
| ==        | égal à        |
| !=        | différent de  |
| >         | supérieur à   |
| >=        | supérieur ou égal à |
| <         | inférieur à   |
| <=        | inférieur ou égal à |


---

## If

La condition la plus simple est le `if` qui permet d'éxécuter un bloc de code si la condition est vraie.

```csharp
if (condition 1)
{
// code a executer si la condition 1 est vrai
}
```

---

<!-- TODO : exercice sur if -->

## Exercice : 
créer deux variable `int` solde_camille et solde_bob
initialiser les telque : 
solde_camille = 1111;
solde_bob = 289; 
créer une condition `if` si solde_camille est supérieur au solde_bob et y mettre le code suivant
```csharp
Console.WriteLine("camille a un solde superieur a bob " + solde_camille);
```

Exécuter le code.


---

## Solution :
```csharp
int solde_camille = 1111;
int solde_bob = 289;

if (solde_camille > solde_bob) {

Console.WriteLine("camille a un solde superieur a bob " + solde_camille);
}

```

---

## Else

La condition `else` permet d'éxécuter un bloc de code si la condition est fausse.

```csharp
if (condition 1)
{
// code à éxécuter si la condition 1 est vraie
}
else
{
// sinon, code à éxécuter si la condition 1 est fausse
}
```

---

<!-- TODO : exercice sur if else -->
## Exercice : 
Reprendre le code précédent et ajouter au scope de else :  
```csharp
Console.WriteLine("Bob a un solde superieur a bob " + solde_bob);
```


Exécuter le code.

Changer le solde de bob a 2222;

Exécuter le code.
Quel que chose a-t-il changé dans l'affichage du terminal?

---

## Else if

La condition `else if` permet d'éxécuter un bloc de code si la condition est fausse et que l'on souhaite vérifier une autre condition.

```csharp
if (condition 1)
{
// code à éxécuter si la condition 1 est vraie
}
else if (condition 2)
{
// sinon, code à éxécuter si la condition 1 est fausse et que condition 2 est vraie
}
else
{
// code à éxécuter si la condition 1 est fausse et que condition 2 est fausse
}
```

---

## Exemple 

```csharp
int a = 5;
int b = 10;

if (a > b)
{
Console.WriteLine("a est supérieur à b");
}
else if (a < b)
{
Console.WriteLine("a est inférieur à b");
}
else
{
Console.WriteLine("a est égal à b");
}
```

Exécuter le code.

---

## Exercice
```
Changer int a = 120;
Exécuter le code.
Changer int a = 120;
Changer int b = 120;
Exécuter le code.
```

---

## Exercice

```csharp
int ton_age = mettre ton age;
int nombre_denfant = mettre ton nombre d enfant;

1 Créer une condition pour vérifier si tu es majeur.
Elle affichera \(avec Console.WriteLine\) si tu es majeur, ou si tu es mineur

2 Créer une ou plusieurs conditions pour vérifier si \:
tu n as pas d enfant,       // afficher je n'est pas d'enfant 
3 tu as moins de 3 enfants mais tu as des enfants,   // afficher j'ai nbr d enfant
4 tu as 4 ou moins mais plus que 2,   // j'ai plus que 2 enfants mais ce n'est pas une famille nombreuse
5 tu as plus que 4 enfants, // j'ai une famille nombreuse

```

---

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->

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
// autre possibilité, nbr_denfant <= 2
Console.WriteLine("J'ai " + nombre_denfant + " enfant");
}

```

---

## Reponse 

```csharp

else if (nombre_denfant <= 4) // condition 3
{
Console.WriteLine("J'ai plus que 2 enfants mais ce n'est pas une famille nombreuse");
}
else // condition 4 , si aucune des conditons n'étaient bonne
{
Console.WriteLine("J'ai une famille nombreuse");
}
```

--- 

## Opérateur Booleen

Les opérateurs booleen permettent de combiner des conditions.

| Opérateur | Signification |
|-----------|---------------|
| &&        | ET            |
| \|\|      | OU            |
| !         | NON           |

---

## ET

L'opérateur ET permet d'exécuter un bloc de code si les deux conditions sont vraies.

```csharp
if (condition 1 && condition 2)
{
// code à executer si les deux conditions sont vraies
}
```

---

## OU

L'opérateur OU permet d'exécuter un bloc de code si une des deux conditions est vraie.

```csharp
if (condition 1 || condition 2)
{
// code à executer si une des deux conditions sont vraies
}
```


<!-- TODO : exercice condition avec ou -->

---

## NON

L'opérateur NON permet d'inverser la valeur de la condition.

```csharp
if (!condition)
{
// code à executer si la condition est fausse
}
```
---

## Exercice 
<!-- TODO : créer un exercice où on devra utiliser if avec des operateurs booleen && || -->


```csharp
int nbr_pizza = 14;
int nbr_couvert = 30;
int nbr_personne = 12;

1 créer une condition qui verifie : 
- tout le monde aura 2 couverts au moins 
	ET
- tout le monde aura 1 pizza au moins

2 créer une condition qui verifie : 
- tout le monde aura 2 couvert au moins 
	OU
- tout le monde aura 1 pizza au moins
```

<!-- TODO : exercice -->

---

## Priorité des parenthèses

Les opérateurs booleen sont evalués de gauche à droite dans une condition. 

Les parenthèses `()` fonctionnent en informatique comme en mathématiques
La priorité de la condition se dirige dans la parenthèse en 1er.


---

## Table de verite

</br>

| A | B | A && B |
|---|---|--------|
| Vrai | Vrai | Vrai     |
| Vrai | Faux | Faux     |
| Faux | Vrai | Faux     |
| Faux | Faux | Faux     |

---

</br>

| A | B | A \|\| B |
|---|---|--------|
| Vrai | Vrai | Vrai     |
| Vrai | Faux | Vrai     |
| Faux | Vrai | Vrai     |
| Faux | Faux | Faux     |

---

</br>

| A | !A |
|---|---|
| Vrai | Faux |
| Faux | Vrai |

---

## Exercice 

Reprendre l'exercice précédent en ajoutant la dernière condition :

```csharp

3 Créer une condition qui vérifie : 
- tout le monde aura 2 couverts au moins 
	ET
- tout le monde aura 1 pizza au moins
	ET
		- il y a plus de 20 couverts
			OU	
		- il y a plus de 10 personnes
```


