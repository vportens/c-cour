// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!")
interface IDeplacer {
	public void deplacer();
}

interface IAttaquer {
	public void attaquer();
}


abstract class Personnage {
    public string nom;
    public int pv;
    public int agilite;
    public int degat;

    public Personnage(string c_nom) {
        nom = c_nom;
        pv = 100;
        agilite = 10;
        degat = 10;
    }

	public void presentation() {
		Console.WriteLine("Je suis " + nom + " et j'ai " + pv + " points de vie.");
	}	

}

class Ninja : Personnage, IDeplacer, IAttaquer {
    public int esquive;

    public Ninja(string c_nom) : base(c_nom) {  
        esquive = 100;
		agilite = 34;
		pv = 90;
    }

/*	public void attaquer() {
		// code
	}
	*/

	public void deplacer() {
		// code
	}
}
;