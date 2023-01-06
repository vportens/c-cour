class Vehicule
{
    protected int nbRoues;
    protected int vitesseMax;

    public Vehicule(int nbRoues, int vitesseMax)
    {
        this.nbRoues = nbRoues;
        this.vitesseMax = vitesseMax;
    }

    public void Demarrer()
    {
        Console.WriteLine("Le véhicule démarre");
    }
}

class Voiture : Vehicule
{
    private int nbPlaces;

    public Voiture(int nbRoues, int vitesseMax, int nbPlaces) : base(nbRoues, vitesseMax)
    {
        this.nbPlaces = nbPlaces;
    }

    public override void Demarrer()
    {
        Console.WriteLine("La voiture démarre");
    }
}

class Moto : Vehicule
{
    private string type;

    public Moto(int nbRoues, int vitesseMax, string type) : base(nbRoues, vitesseMax)
    {
        this.type = type;
    }

    public override void Demarrer()
    {
        Console.WriteLine("La moto démarre");
    }
}
