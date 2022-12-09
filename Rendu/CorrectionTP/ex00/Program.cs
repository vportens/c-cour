// See https://aka.ms/new-console-template for more information

Village myVillage = new Village("Victor le createur");

myVillage.getName();
Console.WriteLine(myVillage.getName());


public class Village{


    // Ressources
    private Ressources myRessources;

    // Batiments

    // Villagois

   int villageois = 0; 

    // nom de village
    private string name;
    // 



    public Village(string name) {
        this.name = name;
        myRessources = new Ressources();
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