// See https://aka.ms/new-console-template for more information
using System;

Village myVillage = new Village("Victor le createur");





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

    private int day = 0;

    public Village(string name) {
        Console.WriteLine("Village en cours de creation...");
        System.Threading.Thread.Sleep(7000); // attendre 7 secondes
        this.name = name;
        Console.WriteLine(name + " a donner son nom au village, maintenant le village portera le nom de \n" + name + "\n");
        System.Threading.Thread.Sleep(7000);
        chefHome = new House();
        Console.WriteLine("\nLe chef a construit sa mainson au coeur du village\n");

        System.Threading.Thread.Sleep(7000);
        myRessources = new Ressources();
        System.Threading.Thread.Sleep(7000);
        listHouse = new House[1] {chefHome};
        mine = new Mine();
        System.Threading.Thread.Sleep(7000);
        forest = new Forest();

        System.Threading.Thread.Sleep(7000);
        Console.WriteLine("Le village est pret a etre construit et ameliore !");
        System.Threading.Thread.Sleep(7000);

        cycle();

    }

    private string choice() {
        return "\n\nJour " + day + "\n" +
                "Hello " + name + "\n" +
                "Aujourd'hui, le village possede " + villageois + " villageois\n" +
                "Tu as " + getWood() + " de bois, \n" + 
                "Tu as " + getStone() + " de pierre\n" +
                "Il est temps d'agir ! Fait ton choix, pour le Village !!!!\n" +
                "\n" +
                "1 - Couper du bois\n" +
                "2 - Miner de la pierre\n" +
                "3 - Construire une maison\n" +
                "4 - Ameliorer la foret\n" +
                "5 - Ameliorer la mine\n" +
                "6 - Ameliorer les reserve\n" + 
                "7 - Regarder au alentour\n" +
                "42 - Quitter le jeu\n";
    }

    private bool checkChoice(string rep) {
        if (rep == "1" || rep == "2" || rep == "3" || rep == "4" || rep == "5" || rep == "6" || rep == "7" || rep == "42") {
            return true;
        }
        return false;
    }  

    private bool checkNbr(string rep) {
        int nbr;
        if (int.TryParse(rep, out nbr)) {
            return true;
        }
        return false;
    }

    private void cycle() {
        int choix = 0;
        string? reponce = "";
        int nbr = 0;
        while (choix != 42) {
            nbr = 0;
            reponce = "";
            Console.WriteLine(choice());
            reponce = (Console.ReadLine());
            if (reponce == null)  {
                Console.WriteLine("Tu dois faire un choix");
            }
            else if (checkChoice(reponce)) {
                choix = int.Parse(reponce);
                if (choix == 1) {
                    Console.WriteLine("Combien de bois voulez vous couper ?");
                    reponce = (Console.ReadLine());
                    if (reponce == null) {
                        reponce = "";
                    }
                    while (checkNbr(reponce) == false) {
                        Console.WriteLine("Veuillez entrer un nombre");
                        reponce = (Console.ReadLine());
                        if (reponce == null)
                            reponce = "";
                    }
                    nbr = int.Parse(reponce);
                    cutWood(nbr);
                }
                else if (choix == 2) {
                    Console.WriteLine("Combien de pierre voulez vous miner ?");
                    reponce = (Console.ReadLine());
                    if (reponce == null) {
                        reponce = "";
                    }
                    while (checkNbr(reponce) == false) {
                        Console.WriteLine("Veuillez entrer un nombre");
                        reponce = (Console.ReadLine());
                        if (reponce == null)
                            reponce = "";
                    }
                    nbr = int.Parse(reponce);
                    mineStone(nbr);
                }
                else if (choix == 3) {
                    Console.WriteLine("Combien de maison voulez vous construire ?");
                    reponce = (Console.ReadLine());
                    if (reponce == null) {
                        reponce = "";
                    }
                    while (checkNbr(reponce) == false) {
                        Console.WriteLine("Veuillez entrer un nombre");
                        reponce = (Console.ReadLine());
                        if (reponce == null)
                            reponce = "";
                    }
                    nbr = int.Parse(reponce);
                    buildHouse(nbr);
                }
                else if (choix == 4) {
                    upgradeForest();
                }
                else if (choix == 5) {
                    upgradeMine();
                }
                else if (choix == 6) {
                    upgradeRessource();
                }
                else if (choix == 7) {
                    lookAround();
                }
                else if (choix == 42) {
                    Console.WriteLine("Votre village " + name + " a parcourut un long chemin depuis le premier jour");
                    Console.WriteLine("Il a survécu a " + day + " jours");
                    Console.WriteLine("Il a " + getWood() + " de bois");
                    Console.WriteLine("Il a " + getStone() + " de pierre");
                    Console.WriteLine("Au revoir");
                }
                day++;
            }
            else {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choix invalide, velleuillez choisir un nombre entre 1 et 7 ou 42 pour quitter");
            }
        }
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
        if (myRessources.getStone() >= (mine.mineStone(1) * 10))
        {
            myRessources.useStone(mine.mineStone(1) * 10);
            mine.upgrade();
        }
    }
    public void upgradeForest() {
        if (myRessources.getWood() >= ((Forest.gain_wood + 10 * (forest.getLevel() -1)))* 10) {
            myRessources.useWood(forest.cutWood(1) * 10);
            forest.upgrade();
        }
    }


}