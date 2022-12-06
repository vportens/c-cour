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
`private int villageois;`
Initialiser ces variables dans le constructeur de village,
N'oubliez pas de rajouter le nombre de villageois disponible dans la chefHome au nombre de villageois de votre village.




