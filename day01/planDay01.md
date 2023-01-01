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

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->

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

La boucle for each permet de parcourir un tableau sans avoir besoin de connaître sa longueur.

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

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
```csharp
// parcourir son tableau avec un boucle while 
int[] tableau = { 1, 2, 3, 4, 5 };

foreach (int elems in arr)
{
Console.WriteLine(tableau[elems]); // afficher l'element elems du tableau

}
```

On voit bien ici, contrairement à la boucle `while`, `elems` s'incrémente automatiquement à la fin du bloc conditionnel.
