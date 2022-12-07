

abstract class Entity  {
    
    public string nom;
    public int pv;
    public int degat;

    public int agilite;

    public Entity() {
        nom = "default";
        pv = 100;
        degat = 10;
        agilite = 10;
    }

    public Entity(string nom, int pv, int degat, int agilite) {
        this.nom = nom;
        this.pv = pv;
        this.degat = degat;
        this.agilite = agilite;
    }
}
