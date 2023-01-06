---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../../Ressources/Theme/Diapo.png)
_backgroundImage: url(../../Ressources/Theme/Title.png)
---

<link href="../../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../../Ressources/Theme/Title.png) -->



<!-- Tout le code saisit dans ce cour est du CSharp -->



<!-- TODO : exercice class avec un static -->

# Exercice Interface

---
## Exercice 1

Créer une interface `IVolant` qui définit une méthode `Voler()`.

Ensuite, créez une classe `Avion` qui implémente l'interface `IVolant`.

La méthode `Voler()` de la classe Avion doit simplement afficher "Je vole comme un avion" dans la console.

Enfin, créez une classe `Oiseau` qui implémente également l'interface `IVolant`.

La méthode `Voler()` de la classe Oiseau doit simplement afficher "Je vole comme un oiseau" dans la console.

---

## Exercice 2

Vous êtes en charge de développer une application de gestion de stock pour une entreprise. Cette application doit permettre de gérer les différents produits stockés dans l'entreprise.

Chaque produit possède les attributs suivants:

- Un nom
- Un prix
- Un nombre de unités en stock


---

## Exercice 2

La classe Produit doit implémenter l'interface IStockable.

Cette interface possède une méthode `void Ajouter(int nb)` qui permet d'ajouter un certain nombre d'unités en stock,

Et une méthode `void Retirer(int nb)` qui permet de retirer un certain nombre d'unités en stock.

---

## Exercice 3

Creez une interface `IAttaque` qui définit une méthode `Attaquer()`.

Creez une interface `IPresentation` qui définit une méthode `SePresenter()`.

Creez une interface `IJouer` qui définit une méthode `Jouer()`.

Creez une classe `Personnage` qui implémente les interfaces `IAttaque` et `IPresentation` et `IJouer`.

---

## Exercice 3

La classe `Personnage` possedera les attributs suivants:

- Un nom
- Un nombre de points de vie
- Un nombre de points d'attaque

La classe Personnage doit implémenter les méthodes `Attaquer()`, `SePresenter()` et `Jouer()`.

---

## Exercice 3

La méthode `Attaquer()` doit afficher "nom frappe de points de d'attaque" dans la console.

La méthode `SePresenter()` doit afficher "Je suis un nom" dans la console.

La méthode `Jouer()` doit afficher "nom veux faire une partie de jeu" dans la console.

---

## Exercice 3.1

Creer la classes `PetitEnfant` qui implementera l'inteface `IPresentation` et `IJouer`.

La classe `PetitEnfant` possedera les attributs suivants:
- Un nom
- Un age
- Un jeu préféré


---

## Exercice 3.1


La classe `PetitEnfant` doit implémenter les méthodes `SePresenter()` et `Jouer()` tel que :

La méthode `SePresenter()` doit afficher "Je suis un nom et j'ai age ans" dans la console.

La méthode `Jouer()` doit afficher "nom veux faire une partie de jeu préféré" dans la console.




