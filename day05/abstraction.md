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



<!-- TODO : exercice class avec un static -->




# Classes abstraites

---


## Classes abstraites

Une classe abstraite est une classe qui ne peut pas etre instancier.

Elle sert de base a d'autre classe qui vont l'hériter.

Une classe abstraite peut contenir des attributs et des méthodes.

Exemple : On ne veux pas de personnage qui n'appartienne à aucune classes dériver de personnage

---

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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
<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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

--- 
## Interfaces

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
<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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
<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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