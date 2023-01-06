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


## Exercice 1

Créer une classe `Animal` qui contient les propriétés suivantes:
- name
Avec un constructeur qui prend en paramètre le nom de l'animal.
Et une méthode `MakeSound` qui affiche un bruit de l'animal.
```csharp
L animal "name" fait ouah ouah
```

---

## Exercice 1.2

Créer une classe `Dog` qui hérite de `Animal` et qui redéfini la méthode `MakeSound` pour afficher un bruit de chien.
Dog doit avoir un constructeur qui prend en paramètre le nom du chien.
```csharp
Animal animal = new Animal("Tigre");
animal.MakeSound(); // Affiche "L'animal Tigre fait ouah ouah"

Dog dog = new Dog("Buddy");
dog.MakeSound(); // Affiche "Le chien Buddy fait ouaf ouaf"
```

---

## Exercice 1.3

Créer une classe `Cat` qui hérite de `Animal` et qui redéfini la méthode `MakeSound` pour afficher un bruit de chat.

Cat doit avoir un constructeur qui prend en paramètre le nom du chat.

```csharp

Cat cat = new Cat("Felix");
cat.MakeSound(); // Affiche "Le chat Felix fait miaou miaou"

```



---

## Exercice 2

Créez une classe `Vehicule` avec les attributs suivants :

- nbRoues : entier qui représente le nombre de roues du véhicule
- vitesseMax : entier qui représente la vitesse maximale du véhicule

---

## Exercice 2

Ajouter un constructeur par default qui initialise les attributs à 0.

Un constructeur qui prend en paramètre le nombre de roues et la vitesse maximale du véhicule.

Ajoutez également une méthode `Demarrer()` qui affiche "Le véhicule démarre" à l'écran.



---

## Exercice 2.1

Ensuite, créez deux classes qui héritent de Vehicule :   
- Voiture
- Moto

Donner leur des constructeurs qui prennent en paramètre le nombre de roues et la vitesse maximale du véhicule.

---

## Exercice 2.1

Ajoutez à chacune de ces classes un attribut supplémentaire :

Voiture : `nbPlaces` qui représente le nombre de places dans la voiture.

Moto : `type` qui représente le type de moto (sportive, trail, custom, etc.)

---


## Exercice 2.2

Redéfinissez la méthode `Demarrer()` dans chaque classe fille pour qu'elle affiche un message différent.

 Par exemple : "La voiture a "nbrPlace" démarre" ou "La moto "type" démarre".

---



## Exercice 3

Créer une classe `Personnage` avec des attributs tels que `Nom`, `PV`, `Agilite` et `Degats`.

Il doit avoir un constructeur qui prend en paramètre le nom du personnage qui initialisera :
- `Nom`parametre passer au constructeur
- `PV` a 100
- `Agilite` a 10
- `Degats` a 10.

---

## Exercice 3.2

Créer des classes `Magicien`, `Guerrier` et `Ninja` qui hérite de `Personnage`.

Ils auront un constructeur qui prend en paramètre le nom du personnage et qui appellera le constructeur de `Personnage` avec le nom en paramètre.


(suite prochaine page) ->

---

## Exercice 3.2 (suite)
Dans ces constructeur, il faudra modifier les valeurs de `Agilite`, `Degats` et `PV` pour chaque classe :
- Ninja aura `Agilite` a 15; `Degats` a 12; `PV` a 70;
- Guerrier aura `Agilite` a 8; `Degats` a 17; `PV` a 120;
- Magicien aura `Agilite` a 17; `Degats` a 5; `PV` a 150;


---

## Exercice 3.3

Ajouter des méthodes specifique a chaque classe :

- `Ninja` aura une méthode `camouflage` qui affiche qui augmente `Agilite` de 10 et baisse ses degats de 1.

- `Guerrier` aura une méthode `rage` qui augmente `Degats` de 10 et baisse ses PV de 10.

- `Magicien` aura une méthode `soin` qui augmente ses PV de 15 et baisse ses degats de 1.

---

## Exercice 3.4


Ajouter une methode `Attaque` a la classe `Personnage` qui prend en paramètre un autre personnage et qui affiche un message dans le terminal : 

``` "monNom" attaque "nomPersonnageAttaquer" et tente de lui inflige "nbrDegats" degats```

---

## Exercice 3.5

Ajouter une overload de la methode `soin` qui prendra en parametre un personnage et qui soignera ce personnage.



---

## Exercice 4

Créez une classe Forme avec les attributs suivants :

`couleur` : chaîne de caractères qui représente la couleur de la forme

`remplit`: booléen qui indique si la forme est remplie ou non

Avec un constructeur qui prend en paramètre la couleur et le remplissage de la forme.

Ajoutez également une méthode `Afficher()` qui affiche les caractéristiques de la forme (couleur et remplissage) à l'écran.

---

## Exercice 4.1

Ensuite, créez deux classes qui héritent de Forme : `Cercle` et `Rectangle`. 

Ajoutez à chacune de ces classes un attribut supplémentaire :

- Cercle : rayon qui représente le rayon du cercle
- Rectangle : largeur et hauteur qui représentent la largeur et la hauteur du rectangle

---

## Exercice 4.1

Ajoutez à chacune de ces classes un constructeur qui prend en paramètre la couleur et le remplissage de la forme ainsi que les attributs spécifiques à la forme.

Modifiez également la méthode `Afficher()` pour qu'elle affiche les caractéristiques de la forme ainsi que les caractéristiques spécifiques à la forme.

```csharp
Par exemple :
 "Cercle rouge, rempli, rayon = 3" 
"Rectangle bleu, vide, longueur = 5, largeur = 10".
```


---

## Exercice 4.2

Ajoutez une méthode `CalculerPerimetre()` à la classe Cercle qui retourne le périmètre du cercle. 

La formule du périmètre d'un cercle est `2 * PI * Rayon`

Enfin, ajoutez une méthode `CalculerSurface()` à la classe Rectangle qui retourne la surface du rectangle.

La formule de la surface d'un rectangle est longueur * largeur

---

## Exercice 5

Créez une classe BankAccount avec les attributs suivants :

- `balance` : entier qui représente le solde du compte
- `owner` : chaîne de caractères qui représente le nom du propriétaire du compte

Ajoutez également une méthode `Deposit`(int amount) qui permet de déposer de l'argent sur le compte et une méthode `Withdraw`(int amount) qui permet de retirer de l'argent du compte. 

---

## Exercice 5

Assurez-vous que la méthode `Withdraw` ne retire pas plus d'argent que le solde du compte.
Si c'est le cas, affichez un message d'erreur.

---

## Exercice 5.1

Ensuite, créez une classe qui hérite de BankAccount : `CheckingAccount`.
Ajoutez à cette classe un attribut supplémentaire :
- `overdraftLimit` : entier qui représente le plafond de découvert autorisé sur ce compte.

---


## Exercice 5.2

Redéfinissez la méthode Withdraw dans la classe `CheckingAccount` pour qu'elle autorise le retrait de fonds jusqu'à la limite du découvert autorisé (overdraftLimit).

Si le retrait dépasse cette limite, affichez un message d'erreur.

---

## Exercice 5.3

Ensuite, ajoutez une méthode `PayInterest()` à la classe `CheckingAccount` qui ajoute un intérêt au solde du compte (par exemple, 1% du solde du compte seront  ajoute a votre compte).


