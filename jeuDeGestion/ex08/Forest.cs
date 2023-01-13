
public class Forest {
    public static int gain_wood {get {return 10;}}
    public static int stone_cost {get {return 2;}}
    public static int wood_cost {get {return 1;}}

    private int level;



    public Forest() {
        level = 1;
        Console.WriteLine("\nL'equipe d'exploration a trouve une foret au alentour, ca sera parfait pour recolter du bois\n");
    }

    public int cutWood(int nbVillageois) {
        return nbVillageois * (gain_wood + 10 *(level - 1));
    }

    public void upgrade() {
        level++;
    }
    public int getLevel() {
        return level;
    }
}