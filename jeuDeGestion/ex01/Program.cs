// See https://aka.ms/new-console-template for more information

Village myVillage = new Village("Victor le createur");

myVillage.getName();

Console.WriteLine(myVillage.getName());
Console.WriteLine("nombre de villageois : " + myVillage.getVillageois());
Console.WriteLine(House.stone_needed );
House.stone_needed = 5;
Console.WriteLine(House.stone_needed );
Console.WriteLine(House.stone_needed);


Console.WriteLine(myVillage.chefHome);


public class Village{


    // Ressources
    private Ressources myRessources;

    // Batiments
    public House chefHome;
    // Villagois

    private int villageois; 

    // nom de village
    private string name;
    // 



    public Village(string name) {
        this.name = name;
        myRessources = new Ressources();
        chefHome = new House();
        villageois = House.villageois;
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

    public int getVillageois() {
        return villageois;
    }

    public void addVillageois(int nbr) {
        villageois += nbr;
    }


}