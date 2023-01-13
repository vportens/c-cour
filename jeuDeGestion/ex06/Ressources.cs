
class Ressources {
    private int woods;
    private int stones;
    private int wood_max;
    private int stone_max;
    
    private int level;

    public Ressources() {
        woods = 10;
        stones = 10;
        wood_max = 250;
        stone_max = 250;
        level = 1;
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

    public void addStone(int nbr) {
        if (stones + nbr <= stone_max)
            stones += nbr;
        else
            stone = stone_max;
    }

    public void addWood(int nbr) {
        if (wood + nbr <= wood_max)
            wood += nbr;
        else
            wood = wood_max;
    }

    public void upgrade() {
        if (woods >= (int)(wood_max * 0.8) && stones >= (int)(stone_max * 0.8)) {
            woods -= (int)(wood_max * 0.8);
            stones -= (int)(stone_max * 0.8);
            wood_max *= 2;
            stone_max *= 2;
            level++;
        }
    }

    public void lookAround() {
        if (level > 1) {
            addStone(1);
            addWood(1);
        }
    }
    

}