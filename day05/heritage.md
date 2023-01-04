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

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->

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

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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