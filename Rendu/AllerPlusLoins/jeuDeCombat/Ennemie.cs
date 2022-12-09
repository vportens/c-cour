interface IAttaquePersonnage {
    public void attaquer(Personnage p);
}

interface IGetHitByPersonnage {
    public void getHit(Personnage p, int degat);
}

abstract class Ennemi : Entity , IAttaquePersonnage, IGetHitByPersonnage {


    public Ennemi() : base() {
    }

    public Ennemi(string nom, int pv, int degat, int esquive) : base(nom, pv, degat, esquive) {
    }

    public void attaquer(Personnage p) {
        if (p.pv <= 0) {
            Console.WriteLine("Cible morte");
        } 
        else {
            p.getHit(this , degat);
        }
    }

    public void getHit(Personnage p, int degat) {
        if (this.pv <= 0) {
            Console.WriteLine("Cible morte");
            return ;
        } 

        if (agilite != 0) {
            var random = new Random();
            int chance = random.Next(0, 101);
        

            if (chance > agilite) {
                dealDommage(degat);
            } else {
                Console.WriteLine(nom + " a esquiver la perte de " + degat);
            }
        }
        else {
                dealDommage(degat);
        }
    }

    private void dealDommage(int degat) {
        pv -= degat;
        Console.WriteLine(nom + " a subit "  + degat + " points de dégats.");
        Console.WriteLine("pv restant : " + pv);
        if (pv <= 0) {
            Console.WriteLine(nom + " est mort");
        } 
    }
}