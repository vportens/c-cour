TP : Jeu de gestion, je créer mon village


---

#   HelloMyVillage 

---

créer une classe `Village`,
qui aura comme attribut :

`string name` qui ne sera accessible que par la methode `getName()` et qui sera instancier a la creation d'un nouveau village.





---

# Give me some ressources


Dans un fichier Ressources.cs

créer une classe `Ressources`
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


créer un constructeur `Ressources` qui ne prendra aucun parametre et qui initialisera woods a 10 et stones a 10.


Une fois fait;

Rajoutez a votre village un attribut priver `myRessources` de type `Ressources`
Attribut qui sera instancier dans le constructeur de `Village` en appelans le constructeur de `Ressources`.

Rajoutez des getters 
- `getWood()`
- `getStone()`
qui appelerons, `getWood()`,`getStone()` de myRessources.




EXERCICE 01 : What is a kingdom without subject ?

créer un fichier House.cs
Dans lequel vous créerez une classe public House
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
créer un attribut `listHouse` qui sera une un tableau de maison public, 
Dans le constructeur de village, vous l'initialiserez;
apres avoir initialisez `chefHome`, telque votre `listHouse` continient `chefHome`.

Test son code,


```csharp
Village myVillage = new Village("Victor le createur");

myVillage.getName(); // affichera Victor le createur
Console.WriteLine(myVillage.listHouse.Length); // affichera 1
```

Ajoutez des maison a votre list,

créer une methode public qui ajoutera une `House` a votre `listHouse`.
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



