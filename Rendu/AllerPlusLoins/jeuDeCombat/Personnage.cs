interface IAttaquer {
	public void attaquer(Ennemi cible);
}


interface IGetHitByEnnemie {
    public void getHit(Ennemi e, int degat);
}

abstract class Personnage : Entity , IAttaquer, IGetHitByEnnemie {
    public int mana;

    public Personnage() : base() {
    }

    public Personnage(string nom, int pv, int degat, int esquive, int mana) : base(nom, pv, degat, esquive) {
        this.mana = mana;
    }

    public void attaquer(Ennemi cible) {
        if (cible.pv <= 0) {
            Console.WriteLine("Cible morte");
        } 
        else {
            cible.getHit(this , degat);
        }
    }

    public void getHit(Ennemi cible, int degat) {
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
                Console.WriteLine(nom + " a esquiver la perte de " + degat + " de " + cible.nom);
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
