
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
        Console.WriteLine("\nVos resserves de ressource ont ete creer");
        Console.WriteLine("Vous avez " + woods + " bois et " + stones + " pierres");
        Console.WriteLine("Attention les reserves sont niveau " + level);
        Console.WriteLine("Vous pouvez stocker " + wood_max + " bois et " + stone_max + " pierres, au maximum");
        Console.WriteLine("Augmentez votre niveau de stockage pour pouvoir stocker plus de ressources\n");
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
            stones = stone_max;
    }

    public void addWood(int nbr) {
        if (woods + nbr <= wood_max)
            woods += nbr;
        else
            woods = wood_max;
    }

    public void upgrade() {
        if (woods >= (int)(wood_max * 0.8) && stones >= (int)(stone_max * 0.8)) {
            woods -= (int)(wood_max * 0.8);
            stones -= (int)(stone_max * 0.8);
            wood_max *= 2;
            stone_max *= 2;
            level++;
            Console.WriteLine("Vous avez ameliore votre niveau de stockage");
            Console.WriteLine("Votre reserve est maintenant au niveau " + level);
            Console.WriteLine("Vous pouvez maintenant stocker " + wood_max + " bois et " + stone_max + " pierres, au maximum");
        }
    }

    public void lookAround() {
        if (level > 1) {
            addStone(1);
            addWood(1);
        }
    }
    

}