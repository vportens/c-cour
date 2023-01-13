// See https://aka.ms/new-console-template for more information
using System;

Village myVillage = new Village("Victor le createur");
Console.WriteLine(myVillage.getName());

myVillage.cutWood(2);
myVillage.mineStone(2);
myVillage.cutWood(4);
myVillage.mineStone(4);

Console.WriteLine(myVillage.getWood());
Console.WriteLine(myVillage.getStone());

myVillage.buildHouse(2);
Console.WriteLine(myVillage.listHouse.Length);
Console.WriteLine(myVillage.villageois);

myVillage.cutWood(15);
myVillage.mineStone(15);
Console.WriteLine(myVillage.getWood());
Console.WriteLine(myVillage.getStone());
myVillage.buildHouse(4);
myVillage.upgradeForest();
Console.WriteLine(myVillage.getWood());
myVillage.cutWood(1);

/*
myVillage.cutWood(13);
myVillage.mineStone(13);
myVillage.cutWood(16);
myVillage.mineStone(16);
Console.WriteLine(myVillage.getWood());
Console.WriteLine(myVillage.getStone());
*/





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

    public void buildHouse(int nbrHouse) {
        if (House.wood_needed * nbrHouse <= getWood() && House.stone_needed * nbrHouse <= getStone()) {
            myRessources.useWood(House.wood_needed * nbrHouse);
            myRessources.useStone(House.stone_needed * nbrHouse);
            for (int i = 0; i < nbrHouse; i++) {
                addHouse();
            }
        }
        else {
            Console.WriteLine("Il n'y a pas assez de ressources");
        }
    }


// Getters

    public string getName() {
        return name;
    }

    public int getWood() {
        return myRessources.getWood() ;
    }

    public int getStone() {
        return myRessources.getStone();
    }

    public void upgradeRessource() {
        myRessources.upgrade();
    }

    public void lookAround() {
        myRessources.lookAround();
    }

    public void upgradeMine() {
        if (myRessources.getStone() >= ((Mine.gain_stone + 10 * (mine.getLevel() -1))) * 10)
           mine.upgrade();
    }
    public void upgradeForest() {
        if (myRessources.getWood() >= ((Forest.gain_wood + 10 * (forest.getLevel() -1)))* 10)
           forest.upgrade();
    }

}