TP : Jeu de gestion, je creer mon village


---

#   HelloMyVillage 

---

Creer une classe `Village`,
qui aura comme attribut :

`string name` qui ne sera accessible que par la methode `getName()` et qui sera instancier a la creation d'un nouveau village.





---

# Give me some ressources


Dans un fichier Ressources.cs

Creer une classe `Ressources`
Elle possedera deux attributs priver :
- `int woods`
- `int stones`

Ces ressources ne seront accessible que par des getter respectif : 
- `getWood()`
- `getStone()`

Rajoutez des fonctions pour utiliser vos ressources avec les prototipe suivants : 
-  `public void useStone(int nbr)`
- `public void useWood(int nbr)`)
nbr est le nombre de ressources utilisees

!! attention on ne pourra pas utiliser plus de ressource que l'on en a. 


Creer un constructeur `Ressources` qui ne prendra aucun parametre et qui initialisera woods a 10 et stones a 10.


Une fois fait;

Rajoutez a votre village un attribut priver `myRessources` de type `Ressources`
Attribut qui sera instancier dans le constructeur de `Village` en appelans le constructeur de `Ressources`.

Rajoutez des getters 
- `getWood()`
- `getStone()`
qui appelerons, `getWood()`,`getStone()` de myRessources.




EXERCICE 01 : What is a kingdom without subject ?

Creer un fichier House.cs
Dans lequel vous creerez une classe public House
Elle aura 3 attributs : 
- `stone_needed` (cout en pierre)
- `wood_needed` (cout en bois)
- `villageois` (nbr de villageois que ce batimment apportera)

C'est attribut seront accessible uniquement avec la class House en non avec un object de classes.
Ils ne seront pas pas instenssiable.
Stone_needed et wood_needed renverront toujours 3.
Villageois renvera toujours 10.


Tester son code : 
```csharp
Console.WriteLine(House.wood_needed) // affichera 3
Console.WriteLine(House.stone_needed) // affichera 3
// Console.WriteLine(House.stone_needed++) // --> Erreur
House justAHouse = new House()
// justAHouse.wood_need // --> Erreur
// justAHouse.villageois // --> Erreur
// justAHouse.villageois = 20 // --> Erreur

```

Une fois fait, ajoutez a la class Village votre maison,
`public House chefHome;`
Ainsi que le nombre de sujet de votre village : 
`private int villageois = 0;`
Initialiser cette variable dans le constructeur de village,
N'oubliez pas de rajouter le nombre de villageois disponible dans la chefHome au nombre de villageois de votre village.




Exercice 2 : One house is not suffisant for a village

Dans votre class Village, 
Creer un attribut `listHouse` qui sera une un tableau de maison public, 
Dans le constructeur de village, vous l'initialiserez;
apres avoir initialisez `chefHome`, telque votre `listHouse` continient `chefHome`.

Test son code,


```csharp
Village myVillage = new Village("Victor le createur");

myVillage.getName(); // affichera Victor le createur
Console.WriteLine(myVillage.listHouse.Length); // affichera 1
```

Ajoutez des maison a votre list,

Creer une methode public qui ajoutera une `House` a votre `listHouse`.
Prototype : `public void addHouse()`



Test son code,


```csharp
Village myVillage = new Village("Victor le createur");

myVillage.getName(); // affichera Victor le createur
Console.WriteLine(myVillage.listHouse.Length); // affichera 1
myVillage.addHouse();
myVillage.addHouse();
Console.WriteLine(myVillage.listHouse.Length); // affichera 3
```

Une fois fait, on changera un peu l'attribut villageois.
Deja on le rendra public.
Ensuite pour savoir combien on a de `villageois`  dans notre `Village`, on retournera le produit du nombre de maison contenue dans `listHouse` par le nombre de `villageois` par `House`.



```csharp
Village myVillage = new Village("Victor le createur");

myVillage.getName(); // affichera Victor le createur
Console.WriteLine(myVillage.listHouse.Length); // affichera 1
myVillage.addHouse();
myVillage.addHouse();
Console.WriteLine(myVillage.listHouse.Length); // affichera 3
Console.WriteLine(myVillage.villageois); // affichera 30
```

On passera juste addHouse en priver a la fin quand les test seront valide.




Exercice 3 : Sujets au travail !!

Vous avez 10 villageois, vous avez 10 pierres, vous avez 10 bois.
Mais ce n'est pas suffisant !!!
Mettez vos sujets au travails pour leurs chef (vous).


Creer un fichier Mine.cs
Avec une classe `Mine`

Sur le meme model de `House`
Creer des les attributs suivant : 
- gain_stone (retournera 10)
- stone_cost (retournera 2)
- wood_cost (retournera 1)

```csharp
Console.WriteLine(Mine.gain_stone) // affichera 10
Console.WriteLine(Mine.stone_cost) // affichera 2
Console.WriteLine(Mine.wood_cost) // affichera 1
```

Creer un construceur `Mine()`
qui affichera dans le terminal `"Mine created"`)

Creer une methode public `mineStone` qui prendra en argument un nombre de villageois, et qui renvera le produit de `nombre de villageois * gain_stone`

Ajouter a la classes `Village` : 
- un attribut `Mine` qui sera instancier dans le constructeur.

- une methode public `mineStone` qui prendra en parametre un nombre de villageois.

Lorsqu'un villageois utilise la methode `mineStone` celui-ci consomme `Mine.stone_cost` et `Mine.wood_cost`
Et celui-ci vous rapportera `Mine.gain_stone` (creer une methode dans la classes `Ressource`  `public addStone(int nbr)` qui ajouteras nbr a stone).


`mineStone` devra etre protege contre : 
- si en parametre, il y a plus de nbr de villageois que votre village n'en possede.
Auquel cas vous ecrirez dans le terminal `"Il n'y a pas assez de villageois"`

- si l'operation coute plus de ressources que vous n'en possedez.
Auquel cas vous ecrirez dans le terminal `"Il vous manque des ressources"`

Tester son code :
```csharp
Village myVillage = new Village("Victor le createur");

myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois

Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood());// Affichera 10

myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
Console.WriteLine(myVillage.getStone()); // Affichera 10
Console.WriteLine(myVillage.getWood()); // Affichera 10
myVillage.mineStone(5);
myVillage.mineStone(5);
Console.WriteLine(myVillage.getStone()); // Affichera 90
Console.WriteLine(myVillage.getWood()); // Affichera 0
myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources
```
