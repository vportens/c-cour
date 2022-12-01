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

### Exercice sur les variables

1. Creer une variable `age` de type `int` et lui assigner une valeur.
2. Creer une variable `name` de type `string` et lui assigner une valeur.
3. Creer une variable `isAdult` de type `bool` et lui assigner une valeur.
4. Creer une variable `height` de type `float` et lui assigner une valeur.

5. Afficher la valeur de chaque variable avec la fonction `Console.WriteLine(nom_de_variable)`

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

### Exercice sur le nommage des variables 


## Operation


### Lecture

#### Comment utiliser ma variable

### Attribution

#### Comment associer une valeur a ma variable

## Scope

### Qu'est ce que le scope et en quoi impact-il nos variables

## Reference

### Qu'est ce qu'une reference?

### Quand utiliser la reference de ma variable

### Comment utiliser la reference de ma variable

## Tableau

### Comment declarer un tableau

### Comment initialiser un tableau

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
