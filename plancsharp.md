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

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

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

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

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


---
<!-- TODO : exercice -->

## Boucle

Une boucle permet d'exécuter plusieurs fois un bloc de code, tant que la condition est vraie.



---

## Boucle while

La boucle while permet de répéter un bloc de code tant qu'une condition est vraie.

```csharp
while (condition) // tant que la condition est vraie
{
// bloc de code à repéter
}
```

---

## Exemple pratique 

Les boucles `while` sont très pratiques pour, un exemple: itérer sur un tableau.

Rappel, 
Un tableau possède plusieurs éléments d'un même type;

Un tableau possède une fonction qui permet de connaître 
sa longueur : `.Lenght`;

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

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


<!-- TODO : exercice avec boucle simple while -->

---

## Boucle foreach

La boucle for each permet de parcourir un tableau sans avoir besoin de connaitre sa longeur.

```csharp
foreach (type element in tableau)
{
// bloc de code a repeter
}
```

---

## Boucle foreach

Mots clefs :
- `foreach`
- `in`

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp
// parcourir son tableau avec un boucle while 
int[] tableau = { 1, 2, 3, 4, 5 };

foreach (int elems in arr)
{
Console.WriteLine(tableau[elems]); // afficher l'element elems du tableau

}
```

On voit bien ici, contrairement à la boucle `while`, `elems` s'incrémente automatiquement à la fin du bloc conditionnel.

---
<!-- TODO : exercice  boucle foreach -->

## Fonction

Les fonctions sont des blocs de code qui peuvent être appelé n'importe quand dans le code.

Une fonction est une série d'instructions qui permet de réaliser une tâche précise.

Elle peut recevoir un ou des `parametres` en entrée et peut renvoyer une variable en sortie, le `retour`.


---

## Visualiser une fonction 

Une fonction peut être vue comme une usine avec un tapis roulant d'entrée (`parametres`) et un tapis roulant de sortie (`retour`).

On donne un ou des matières premières à l'usine en entrée (`parametres`), et l'usine nous resortira un produit fini (`retour`).

---

## Block de code, Organiser son code pour plus de clarete

Une fonction permet d'organiser son code pour plus de clareté, de séparer les tâches en bloc précis.

```csharp
void Main()
{
// code principal
}
void fonction1()
{
// code de la fonction 1
}
```

---

## Scope de fonction
<!-- rappel sur les variables dans le scopes et en dehor -->

Les variables créent dans une fonction ne sont pas visibles dans les autres fonctions.
La fonction va déclarer son scope, donc son champ d'action.

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
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
<!-- TODO : exercice fonction simple sans parametre -->

## Parameteres passe

Les paramètres sont l'entrée d'une fonction, ils permettent de passer des variables à la fonction.

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

## Parameteres passe

Le nom des paramètres n'est pas obligatoirement identique à celui passé dans la fonction.

Ils seront, dans la fonction, génériques pour pouvoir être clair.

Le Type par contre doit être le même.


---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

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


## Parametre par default

Les paramètres peuvent avoir une valeur par default, si il n'est pas passer a la fonction.

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

<!-- TODO : exercice fonction avec parametre et parametre par default -->


## Retour fonction 

Une fonction peut renvoyer un resultat, ce resultat est un `type` de variable.
Ce `type` est place devant le nom de la fonction, et celle ci ne pourra renvoyer que ce `type`.

On utilisera le mot clef `return` suivit de la variable que l'on voudra retourner.

```csharp
return_type 		fonction_name( parametre, ...) {
return variable_name ;
}

```
--- 
<!-- _backgroundImage: url(./Ressources/Theme/Flat.png)  -->
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




<!-- TODO : exercice faire une fonction avec un retour -->

---

## Associer le retour d'une fonction

On peut associer le retour d'une fonction à une variable.

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


<!-- TODO : exercice faire une fonction avec un retour et l'associer a une variable -->

---

<!-- gros exercice -->
## Exercice

- créer une fonction qui prend en paramètre un tableau d'entier, et qui renvoie le plus grand élément du tableau.
- créer une fonction qui prend en paramètre un tableau d'entier, et qui renvoie la somme de tous les éléments du tableau.


---

# Référence

---

## Qu'est ce qu'une référence?

Une référence permet d'accéder à la variable et la modifier en dehor de son scope dans des fonctions.


---

## Quand utiliser la référence de ma variable

La référence est utile dans des fonctons qui ont pour but de modifier les variables en paramètre.


En C# certaines variable comme les `tableaux` sont de type référence de base. 

Les variables classiques, `int `, `float` , `string` ne le sont pas.

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png)  -->
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


## Comment utiliser la reference

Mot clef `ref` devant le type de la variable dans les paramètre de la fonction.

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
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

## Exercice avec les references

Ecrire une fonction `is_Billi` qui prend en paramètre une référence sur string, renvoie un booléen.
La fonction vérifie si l'argument est égale à `Billi` et renvera `true` si vrai.
Sinon modifier l'argument pour le transforme en `Billi` et renvoyer false.


---

<!-- TODO : exercicie sur les references -->



## Librairie

Une librairie est un ensemble de fonction déjà écrite, utilisable dans notre programme, réunit dans une classe.

Tout au long de ce cour nous avons utiliser `Console.WriteLine`, Console étant un classe avec des fonctions comme WriteLine.



---

## Random

La classe `Random` permet de générer des nombres aléatoires.

```csharp
Random rnd = new Random();
int x = rnd.Next(0, 100); // x est un nombre aleatoire entre 0 et 100
```

---

## Dictionnaire

La classe `Dictionary` permet de créer un tableau de `clef / valeur`.
Les avantages sont : 
- les méthodes de base a dispositions.
- Le faites que le "tableau" soit extensible.
- La recherche des éléments rapide.


---

## Declaration

Un dictionnaire ce déclare avec 2 types;
Un type pour la `clef`, un pour la `valeur`.



```csharp
Dictionary<int , string> dict = new Dictionary<string, int>(); // int --> clef , string --> valeur
```

---

## Clef Valeur

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



## Fonction recherche

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

## Methode Dictionary


- `Add` : permet d'ajouter une clef / valeur
- `Remove` : permet de supprimer une clef / valeur
- `Clear` : permet de vider le dictionnaire
- `ContainsKey` : permet de vérifier si une clef existe
- `ContainsValue` : permet de vérifier si une valeur existe

---

<!-- TODO : petit exercice avec les dictionnaires -->

---

## Qu'est ce que la POO (Programmation oriente object)

La programmation orienté objet est une méthode de programmation qui permet de structurer un programme en `objet`.

Un objet est une représentation d'une entité, comme une voiture, un chat, un humain, un programme, etc...

---

## Pourquoi POO 

La POO permet de créer des objets qui ont des propriétés et des méthodes.
Cela permet :
- Reutilisation du code
- Efficacité de l'appel de fonction
- Facilité la maintenance

---

## Pourquoi POO 

- Facilité le dépannage
- Facilité la lecture du code
- Facilité la modification du code

---

# Les classes


---

## Les classes
Une classe est une structure de données qui permet de définir un nouvel objet.


Une classe est un modele de données.

Exemple : `Console`, `Dictionary`, `Math`


---

## Declaration d'une classe

Une classe se déclare avec le mot clef `class` suivi du nom de la classe.

```csharp
public class Personne { // Declaration d'une classe Personne
// ...
}
```

---


## Classes privees et publiques 

Nous pouvons déclarer les classes de deux manières différentes, en utilisant les mots clés a mettre devant `class`: 
- `Public`
- `Private`



---


## Classe Private

Une classe private ne peut être utilisée que dans la classe ou elle est déclarée. Nous parlons ici de l'encapsulation d'une classe.

Car oui, une classe peut être déclarée dans une classe.

```csharp
private class Personne { // Classe private
// ...
}
```

---

## Classe Public

Une classe public peut être utilisée dans toute le programme.

```csharp
public class Personne { // Classe public
// ...
}
```

---

## Attributs

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

## Attributs private

De la même maniere, un attribut private ne peut etre utiliser que dans la classe ou il est déclaré.

---

## Attributs public

Un attribut public peut être utilisée dans toute le programme.

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

<!-- TODO : exercicie decalration de class avec des attributs public et priver -->


## Encapsulation 

L'encapsulation c'est le faite de donner ou non accès aux attributs a l'utilisateur.

Lorsque vous creez une classe, tout les attributs n'ont pas vocations à être accessible par l'utilisateur.

Il est important d'organiser ses attributs priver/public pour protéger vos classes. Et garantir une meilleur experience a l'utilisateur.

---

## getter / setter 

Les getters et setters permet de définir le retour et l'attribution d'un attribut.

`get` va retourner un attribut, et `set` va declarer/initialiser un attribut.

`get` et `set` sont des fonctions.

---

## Utilisation get

Dans l'exemple précédent, une voiture aura toujours 4 roues, donc on pourrait definir le retour de `wheel` a 4.


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
<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

Un getter peut aussi retourner une variable de classe (même private vu qu'il s'agit d'une fonction au sein de la classes)

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


<!-- TODO : faire un exercice sur les getter -->

---

## Utilisation set

Le setter permet d'attribuer une valeur à une variable de classe.

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




<!-- TODO : faire un exercice sur les setter -->


<!-- TODO : faire un exercice sur les getter et setter -->

---

## Methode

Une méthode est une fonction qui est déclarée dans une classe.

Elle peut être `public` ou `private`. (toujours pour rendre la methode utilisable en dehors de la classe ou non )

---

## Methode

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

## Methode avec des Parametres

Une méthode peut prendre des paramètres, tout comme une fonction.

```csharp
Personne steve = new Personne();
Console.WriteLine(steve.Presentation("Steve", 32, "developper"));

public class Personne {
public string Presentation(string nom, int age, string metier) {
	return ("Je m'appel " + nom + ", j'ai " + age + " et mon metier est " + metier);
}
}
```


<!-- TODO : Exercice sur creation de classes avec quelque methode -->

---

## Overload

Une methode peut être redéfinie avec des argument différents. 

C'est ce qu'on appel l'overload (surcharge en FR?) de méthode.

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


<!-- TODO : exercice sur l'overload de methode -->

---

## Constructeur

Un constructeur est une méthode qui s'execute a l'instanciation d'une classe.

`new` permet d'instancier une classe.

Le constructeur permet d'instancier des variables de classe en même temps que la declaration de la variable de classe.

Le constructeur est une méthode qui porte le nom de la classe 

Passant de 

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
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

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

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

## Parametres du constructeur
Le constructeur peut prendre des paramètres, comme un fonction.

Toute les personnes ne s'appelle pas Steve et n'ont pas 32 ans.

Nous allons créer un constructeur qui va `set` notre personne, histoire de la rendre un peu plus unique


---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
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

## Parametres du constructeur

Maintenant vous pouvez créer une variable de type Personne en la nommant comme vous le souhaitez sans avoir à toucher au code dans la classe.


<!-- TODO : exercice une classe avec deux constructeur un parametrique et sans parametre -->

---

## Overload de Constructeur

Un constructeur peut etre redéfini avec des argument différents. 
Comme une fonction.

C'est ce qu'on appel l'overload de constructeur.

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
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


<!-- TODO : exercice overload de constructeur parametrique -->

---

# Static

---

## Attribut Static

Un attribut static est une variable qui appartient à la classe et non à l'objet.

Elle ne sera pas accessible via une variable; mais par le type.

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp
Console.WriteLine(Personne.nbPersonne); // affichera 0
Personne Bob = new Personne("Bob");
Console.WriteLine(Personne.nbPersonne); // affichera 1
Personne Lea = new Personne("Lea");
Console.WriteLine(Personne.nbPersonne); // affichera 2
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

<!-- TODO : exercice class avec un static -->


# Heritage


---

## Qu'es ce que l'héritage

L'héritage permet de réutiliser du code en creant des classes enfant a partir de classes parent.

La classe enfant va pouvoir utiliser les variables et les méthodes de la classe parent.

Elle peut aussi redéfinir les méthodes,

Ajouter de nouvelle variable,

La classe parent peut imposer la définition de méthode dans la classe enfant.

---

## A quoi ca sert

Vous voulez créer un jeu video de combat et pour cela vous avez besoin de : 
- Personnages

Vous voulez avoir plusieur classe de Personnages :
- Magicien
- Gueurier
- Ninja

---

## A quoi ca sert

Chaqu'une d'elle aura des propriété de bases telque: 
- nom
- pv (point de vie)
- agilite (% d'esquive des attaques subit)
- degat (attaque)

Maintenant vous pouriez me dire  : " pourquoi ne pas faire une seul classe avec plusieur méthode, on pourrait trouver un moyen ?"

---

## A quoi ca sert

Daccord, apres la réalisation de ma classe unique je  veux rajouter un personnage soigner et un énvouteur;

Je devrais changer des implementation dans la classe Personnage et faire attention a ne pas casser les implementations des autre personnages deja créer.

De plus il sera plus dur d'implémenter des méthodes uniques pour certain personnage.

---

## Avantage
- Scalabilité du code
- Separtion et clarte
- Pas de multiple définition des variables et méthodes
- Imposer des variables et des méthodes


---

## Comment ca marche

Lorsque l'on hérite d'une classe, les attributs et les méthodes de la classe parent sont accéssible dans la classe enfant.

Mots clefs : `:` + nom de classe parent lors de la déclaration de la classe fils.

---

## Comment ca marche

Ici `Magicien` (`fils`) hérite de `Personnage` ( `parent`)

De ce faite, Magicien aura tout les attributs et méthode de Personnage


```csharp
class Magicien : Personnage {} // class Magicien herite de class Personnage
```

---

## Constructeur parent

Si la classe parent a un constructeur, il FAUT l'appeler dans le constructeur de la classe enfant.
Mot clef : `: base`

```csharp
class Magicien : Personnage {
public Magicien(string c_nom) : base(c_nom) { // va appeler le constructeur 
// de Personnage(string c_nom)

	// code

}
}
```

--- 


## Exemple 

```csharp
class Personnage {
public string nom;
public int pv;
public int agilite;
public int degat;

public Personnage(string c_nom) {
	nom = c_nom;
	pv = 100;
	agilite = 10;
	degat = 10;
}

public void presentation() {
	Console.WriteLine("Je suis " + nom + " et j'ai " + pv + " points de vie.");
}	
}

```

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->

```csharp
class Magicien : Personnage {
public int mana;

public Magicien(string c_nom) : base(c_nom) { 
	mana = 100;
}
}

class Gueurier : Personnage {
public int armure;

public Gueurier(string c_nom) : base(c_nom) { 
	armure = 10;
	pv = 250;
	agilite = 5;
}
}

class Ninja : Personnage {
public int esquive;

public Ninja(string c_nom) : base(c_nom) {  
	esquive = 100;
	agilite = 34;
	pv = 90;
}
}
```

---

## Protected

Un attribut ou une méthode protected est accessible dans la classe parent et dans la classe enfant.

Contrairement à un attribut ou méthode private qui ne peut être accessible dans une classes hérite.

Exemple :

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp
class A {
protected int nbr_protected = 2;
private int nbr_private = 3;

public A() {
	Console.WriteLine(nbr_protected); // affichera 2
	Console.WriteLine(nbr_private); // affichera 3
}
}

class B : A {
public B() : base() {
	Console.WriteLine(nbr_protected); // affichera 2
	Console.WriteLine(nbr_private); // error ---> attribut private d'une autre class 

}
}


```


---



## Classes abstraites

Une classe abstraite est une classe qui ne peut pas etre instancier.

Elle sert de base a d'autre classe qui vont l'hériter.

Une classe abstraite peut contenir des attributs et des méthodes.

Exemple : On ne veux pas de personnage qui n'appartienne à aucune classes dériver de personnage

---

<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp
abstract class Personnage {
public string nom;
public int pv;
public int agilite;
public int degat;

public Personnage(string c_nom) {
	nom = c_nom;
	pv = 100;
	agilite = 10;
	degat = 10;
}

public void presentation() {
	Console.WriteLine("Je suis " + nom + " et j'ai " + pv + " points de vie.");
}	

abstract public void attaquer();
}
```

---
<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp
class Magicien : Personnage {
public int mana;

public Magicien(string c_nom) : base(c_nom) { 
	mana = 100;
}

public override void attaquer() {
	// code
}
}

class Gueurier : Personnage {
public int armure;

public Gueurier(string c_nom) : base(c_nom) { 
	armure = 10;
	pv = 250;
	agilite = 5;
}

public override void attaquer() {
	// code
}
}

class Ninja : Personnage {
public int esquive;

public Ninja(string c_nom) : base(c_nom) {  
	esquive = 100;
	agilite = 34;
	pv = 90;
}

public override void attaquer() {
	// code
}
}
```

---

## Override

Une méthode peut aussi etre abstract.

Cela veut dire que la méthode doit etre redéfini dans la classe enfant.

Si une méthode est abstract dans la classe parent et n'est pas defini dans la classes enfant, le code ne fonctionnera pas.


Mot clef : `override`

---

## Interfaces

Une interface est une classe abstraite qui ne contient que des méthodes abstraites.

Une interface peut etre implementer dans une classe.

Dans ta classe abstraite il peut y avoir des fonctions/méthodes avec une implémentation. 

Tu peux également avoir des variables, alors que les interfaces ne peuvent avoir que des propriétés.

Tu ne peux hériter que d'une seule classe abstraite, alors qu'avec les interfaces non.

Exemple : 

---


## Exemple

```csharp
interface IDeplacer {
public void deplacer();
}

interface IAttaquer {
public void attaquer();
}


```

---
<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp

abstract class Personnage {
public string nom;
public int pv;
public int agilite;
public int degat;

public Personnage(string c_nom) {
	nom = c_nom;
	pv = 100;
	agilite = 10;
	degat = 10;
}

public void presentation() {
	Console.WriteLine("Je suis " + nom + " et j'ai " + pv + " points de vie.");
}	

}

```

---
<!-- _backgroundImage: url(./Ressources/Theme/Flat.png) -->
```csharp

class Ninja : Personnage, IDeplacer, IAttaquer {
public int esquive;

public Ninja(string c_nom) : base(c_nom) {  
	esquive = 100;
	agilite = 34;
	pv = 90;
}

public void attaquer() {
	// code
}

public void deplacer() {
	// code
}
}

```