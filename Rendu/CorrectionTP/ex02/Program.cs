// See https://aka.ms/new-console-template for more information
using System;

Village myVillage = new Village("Victor le createur");

myVillage.getName();

Console.WriteLine(myVillage.getName());
Console.WriteLine(House.stone_needed );
Console.WriteLine(House.stone_needed);


Console.WriteLine(myVillage.chefHome);
Console.WriteLine(myVillage.listHouse.Length);
Console.WriteLine(myVillage.listHouse.Length);



public class Village{


    // Ressources
    private Ressources myRessources;

    // Batiments
    public House chefHome;

    public House[] listHouse;
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

    }



    private void addHouse() {
        House[] newListHouse = new House[listHouse.Length + 1];
        for (int i = 0; i < listHouse.Length; i++) {
            newListHouse[i] = listHouse[i];
        }
        newListHouse[listHouse.Length] = new House();
        listHouse = newListHouse;
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