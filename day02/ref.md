---
marp: true
paginate: true
theme: gaia

backgroundImage: url(../Ressources/Theme/Diapo.png)
_backgroundImage: url(../Ressources/Theme/Title.png)
---

<link href="../Ressources/Theme/CSS/theme.css" rel="stylesheet">

<!-- _backgroundImage: url(../Ressources/Theme/Title.png) -->





# Référence

---

## Qu'est ce qu'une référence?

Une référence permet d'accéder à la variable et la modifier en dehors de son scope dans des fonctions.


---

## Utiliser la référence

La référence est utile dans des fonctions qui ont pour but de modifier les variables en paramètre.


En C# certaines variable comme les `tableaux` sont de type référence de base. 

Les variables classiques, `int `, `float` , `string` ne le sont pas.

---

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png)  -->
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

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->
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

Écrire une fonction `is_Billi` qui prend en paramètre une référence sur string, renvoie un booléen.
La fonction vérifie si l'argument est égale à `Billi` et renverra `true` si vrai.
Sinon modifier l'argument pour le transforme en `Billi` et renvoyer false.

--- 

## Exercice corrigé

--- 

<!-- _backgroundImage: url(../Ressources/Theme/Flat.png) -->

```csharp
string name = "Jan";
Console.WriteLine(name);

bool is_Billi(ref string nameToCheck) {
    if (nameToCheck == "Billi") {
        return true;
    } else {
        nameToCheck = "Billi";
        return false;
    }
}

bool ret = is_Billi(ref name);

Console.WriteLine(name);
Console.WriteLine(ret);
```