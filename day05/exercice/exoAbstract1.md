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

# Exercice Heritage

- heritage classique
- attribut protected
- class abstraite
- override
- interface

---

## Exercice 1 Geometrie

Créez une classe abstraite `FormeGeometrique` avec une méthode abstraite `CalculerSurface()` qui ne retourne un double et qui n'a pas d'arguments.

Ajoutez également une méthode `AfficherSurface()` qui affiche le résultat de `CalculerSurface()`.

---

## Exercice 1.2

Ensuite, créez des classes qui héritent de FormeGeometrique : `Cercle et Rectangle`. 

Implémentez la méthode abstraite `CalculerSurface()` dans ces deux classes de manière à ce qu'elle calcule et retourne la surface du cercle ou du rectangle en fonction de leurs dimensions.

Formule Surface Cercle : `PI * rayon * rayon`
Formule Surface Rectangle : `longueur * largeur`

---

## Exercice 1.3

Tester son code :

Ensuite, créez un objet de type Cercle et un objet de type Rectangle et appelez la méthode `AfficherSurface()` sur chacun de ces objets pour vérifier que le message affiché correspond à ce qui est attendu.

```csharp
Cercle monCercle = new Cercle(2.0);
monCercle.AfficherSurface();

Rectangle monRectangle = new Rectangle(3.0, 4.0);
monRectangle.AfficherSurface();
```

---

## Exercice 2 Animal

Créer une classe abstraite `Animal` qui possède les attributs suivants :

- Nom : le nom de l'animal
- Age : l'âge de l'animal
- Poids : le poids de l'animal

La classe `Animal` possède également une méthode abstraite `Parler` qui doit être redéfinie dans les classes filles.

---

## Exercice 2.1

Ensuite, nous allons créer les classes `Chien`, `Chat` et `Oiseau` qui héritent de la classe `Animal`.

Chacune de ces classes possède un constructeur qui appelle le constructeur de la classe `Animal` en utilisant la syntaxe `base`.
(Il faut donc que la classe `Animal` possède un constructeur qui prend en paramètre le nom, l'âge et le poids de l'animal).

---

## Exercice 2.2

Voici les spécificités de chaque classe :

- La classe `Chien` possède en plus un attribut `Race` et une méthode `Parler` qui affiche "Ouaf ! Ouaf !" à l'écran.
- La classe `Chat` possède en plus un attribut `Couleur` et une méthode `Parler` qui affiche "Miaou ! Miaou !" à l'écran.
- La classe `Oiseau` possède en plus un attribut `Type` (ex : perroquet, pigeon, etc.) et une méthode `Parler` qui affiche "Cui ! Cui !" à l'écran.


---

## Exercice 3

Créez une classe abstraite Personnage avec les attributs suivants :

- nom (string)
- pv (int)
- degats (int)
- arme (string)

Ajoutez une méthode abstraite `Attaquer()` qui retourne une chaîne de caractères indiquant le nom du personnage et les dégâts infligés.

---

## Exercice 3

Créez un constructeur pour la classe Personnage qui prend en paramètre le nom, les pv et les dégâts du personnage.

---

## Exercice 3.1

Créez une classe `Guerrier` qui hérite de Personnage et qui ajoute les attributs suivants :

- force (int)

Redéfinissez la méthode Attaquer() pour afficher également la force du guerrier.

Et un constructeur qui prend en paramètre le nom, les pv, les dégâts et la force du guerrier.


---

## Exercice 3.2

Créez une classe `Mage` qui hérite de `Personnage` et qui ajoute les attributs suivants :

- mana (int)
- sort (string)

Redéfinissez la méthode Attaquer() pour afficher également le sort du mage et le coût en mana.

---


## Exercice 4 Produit

Vous devez écrire une classe abstraite `Produit` qui représente un produit disponible à la vente sur la boutique en ligne. Cette classe devra posséder les attributs suivants :

- int `id` : un identifiant unique pour chaque produit
- string `nom` : le nom du produit
- double `prix` : le prix du produit en euros
- int `quantite` : la quantité disponible en stock pour ce produit

---

## Exercice 4

Penser a ajouter un constructeur qui prend en paramètre le nom, le prix et la quantité du produit.

(Pensez a utiliser une variable tempons static pour generer un id unique)

---

## Exercice 4.1

La classe Produit devra également avoir une méthode abstraite double `getPrixTotal()` qui renvoie le prix total de la quantité de produits disponibles en stock.

---

## Exercice 4.2

Vous devez ensuite écrire deux classes concrètes héritant de Produit :

- `Livre` : représente un livre à la vente.
Cette classe doit avoir un attribut supplémentaire string `auteur` qui indique l'auteur du livre.
La méthode `getPrixTotal()` de cette classe doit renvoyer le prix total de tous les livres disponibles en stock.

---

## Exercice 4.2

- `Vetement` : représente un vêtement à la vente. Cette classe doit avoir un attribut supplémentaire string `taille` qui indique la taille du vêtement. La méthode `getPrixTotal()` de cette classe doit renvoyer le prix total de tous les vêtements disponibles en stock.

Pensez aux constructeurs !

---

## Exercice 4.3

Enfin, vous devez écrire une classe `Boutique` qui contient une liste de Produit.
Elle possedera une methode `addProduct` qui ajoutera un produit a la list et qui une méthode double `getPrixTotal()` qui renvoie le prix total de tous les produits de la boutique.

---

## Exercice 4.3


```csharp
Livre livre1 = new Livre( "Harry Potter", 20, 10, "J.K. Rowling");
Livre livre2 = new Livre( "Le Seigneur des Anneaux", 25, 10, "J.R.R. Tolkien");
Vetement vetement1 = new Vetement( "T-shirt", 15, 10, "M");
Vetement vetement2 = new Vetement( "Pantalon", 30, 10, "L");

Boutique boutique = new Boutique();
boutique.ajouterProduit(livre1);
boutique.ajouterProduit(livre2);
boutique.ajouterProduit(vetement1);
boutique.ajouterProduit(vetement2);

```


