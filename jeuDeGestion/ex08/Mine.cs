
public class Mine {
    public static int gain_stone {get {return 10;}}
    public static int stone_cost {get {return 2;}}
    public static int wood_cost {get {return 1;}}

    private int level;

    public Mine() {
        level = 1;
        Console.WriteLine("\nUn villageois a trouve une mine en ce promenant non loin du village, ca sera parfait pour recolter du pierre\n");
    }

    public int mineStone(int nbVillageois) {
        return nbVillageois * gain_stone;
    }

    public void upgrade() {
        level++;
    }

    public int getLevel() {
        return level;
    }
}