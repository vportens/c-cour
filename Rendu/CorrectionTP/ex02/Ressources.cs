
class Ressources {
    private int woods;
    private int stones;

    public Ressources() {
        woods = 10;
        stones = 10;
    }

    public int getStone() {
        return stones;
    }

    public int getWood() {
        return woods;
    }

    public void useStone(int nbr) {
        if (nbr <= stones) {
            stones -= nbr;
        }
    }

    public void useWood(int nbr) {
        if (nbr <= woods) {
            woods -= nbr;
        }
    }

}