// See https://aka.ms/new-console-template for more information
using System;

Village myVillage = new Village("Victor le createur");
Console.WriteLine(myVillage.getName());

myVillage.cutWood(50);

Console.WriteLine(myVillage.getStone());
Console.WriteLine(myVillage.getWood());

myVillage.cutWood(6);
Console.WriteLine(myVillage.getStone());
Console.WriteLine(myVillage.getWood());
myVillage.cutWood(5);
myVillage.cutWood(5);
Console.WriteLine(myVillage.getStone());
Console.WriteLine(myVillage.getWood());
myVillage.cutWood(5);






public class Village{


    // Ressources
    private Ressources myRessources;

    // Batiments
    public House chefHome;

    public House[] listHouse;


    public Mine mine; 
    public Forest forest;
    // Villagois

    public int villageois {get {return listHouse.Length * House.villageois;}} 

    // nom de village
    private string name;
    // 



    public Village(string name) {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        listHouse = new House[1] {chefHome};
        mine = new Mine();
        forest = new Forest();

    }



    private void addHouse() {
        House[] newListHouse = new House[listHouse.Length + 1];
        for (int i = 0; i < listHouse.Length; i++) {
            newListHouse[i] = listHouse[i];
        }
        newListHouse[listHouse.Length] = new House();
        listHouse = newListHouse;
    }



    public void mineStone(int nbrVillageois) {
        if (nbrVillageois <= villageois) {
            if (Mine.stone_cost * nbrVillageois <= getStone() && Mine.wood_cost * nbrVillageois <= getWood()) {
                myRessources.useWood(Mine.wood_cost * nbrVillageois);
                myRessources.useStone(Mine.stone_cost * nbrVillageois);
                myRessources.addStone(mine.mineStone(nbrVillageois));
            }
            else {
                Console.WriteLine("Il n'y a pas assez de ressources");
            }
        }
        else {
            Console.WriteLine("Il n'y a pas assez de villageois");
        }
    }


    public void cutWood(int nbrVillageois) {
        if (nbrVillageois <= villageois) {
            if (Forest.wood_cost * nbrVillageois <= getWood() && Forest.stone_cost * nbrVillageois <= getStone()) {
                myRessources.useWood(Forest.wood_cost * nbrVillageois);
                myRessources.useStone(Forest.stone_cost * nbrVillageois);
                myRessources.addWood(forest.cutWood(nbrVillageois));
            }
            else {
                Console.WriteLine("Il n'y a pas assez de ressources");
            }
        }
        else {
            Console.WriteLine("Il n'y a pas assez de villageois");
        }
    }


// Getters

    public string getName() {
        return name;
    }

    public int getWood() {
        return myRessources.getWood();
    }

    public int getStone() {
        return myRessources.getStone();
    }




}