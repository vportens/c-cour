
public class Mine {
    public static int gain_stone {get {return 10;}}
    public static int stone_cost {get {return 2;}}
    public static int wood_cost {get {return 1;}}

    private int level;

    public Mine() {
        Console.WriteLine("Mine created");
        level = 1;
    }

    public int mineStone(int nbVillageois) {
        return nbVillageois * (gain_stone+ 10 *(level - 1));
    }

    public void upgrade() {
        level++;
    }

    public int getLevel() {
        return level;
    }
}