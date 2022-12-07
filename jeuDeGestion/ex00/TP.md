 # TP : Jeu de gestion, je creer mon village


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
- `public void useWood(int nbr)`
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




