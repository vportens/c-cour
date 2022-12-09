

interface ISort{
    void soin(Personnage p);
    void bouleDeFeu(Ennemi e);

    void meditation();

}

class Mage : Personnage, ISort{
    public Mage() : base("Mage faible", 150, 15, 20, 250) {
    }

    public Mage(string nom) : base(nom + " le faible", 150, 15, 20, 250) {
    }

    public virtual void soin(Personnage p){
        p.pv += 20;
        Console.WriteLine(nom + " soigne " + p.nom + " de " + 20 + " points de vie");
    }

    public virtual void bouleDeFeu(Ennemi e){
        if (mana >= 70) {
        Console.WriteLine(nom + " attaque avec boule de feu");
        e.getHit(this, degat * 1);
        mana -= 70;
        }
        else {
            Console.WriteLine(nom + " n'a pas assez de mana pour attaquer");
        }

    }

    public virtual void meditation(){
        if (mana < 250) {
            mana = 250;    
        }
        Console.WriteLine(nom + " se repose et récupère son mana ");
    }
}

class soigneur : Mage {
    public soigneur() : base("Soigneur") {
        nom = "Soigneur";
    }

    public override void soin(Personnage p){
        p.pv += 40;
        Console.WriteLine(nom + " soigne " + p.nom + " de " + 40 + " points de vie");
    }
}

class MageGeurrier : Mage {
    public MageGeurrier() : base("MageGeurrier") {
        nom = "MageGeurrier";
    }

    public override void bouleDeFeu(Ennemi e){
        if (mana >= 80) {
        Console.WriteLine(nom + " attaque avec boule de feu et lance un sort de guerrier");
            e.getHit(this, degat * 2);
            mana -= 80;
        }
        else {
            Console.WriteLine(nom + " n'a pas assez de mana pour attaquer");
        }
    }

}