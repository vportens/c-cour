
public class Forest {
    public static int gain_wood {get {return 10;}}
    public static int stone_cost {get {return 2;}}
    public static int wood_cost {get {return 1;}}

    public Forest() {
    }

    public int cutWood(int nbVillageois) {
        return nbVillageois * gain_wood;
    }
}