
public class Mine {
    public static int gain_stone {get {return 10;}}
    public static int stone_cost {get {return 2;}}
    public static int wood_cost {get {return 1;}}

    public Mine() {
        Console.WriteLine("Mine created");
    }

    public int mineStone(int nbVillageois) {
        return nbVillageois * gain_stone;
    }
}