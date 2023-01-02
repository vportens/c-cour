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

# Librairie

---


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

## Déclaration

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

## Méthode Dictionary


- `Add` : permet d'ajouter une clef / valeur
- `Remove` : permet de supprimer une clef / valeur
- `Clear` : permet de vider le dictionnaire
- `ContainsKey` : permet de vérifier si une clef existe
- `ContainsValue` : permet de vérifier si une valeur existe

