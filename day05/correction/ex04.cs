class Forme
{
    protected string couleur;
    protected bool remplissage;

    public Forme(string couleur, bool remplissage)
    {
        this.couleur = couleur;
        this.remplissage = remplissage;
    }

    public void Afficher()
    {
        Console.WriteLine($"Forme {couleur}, remplissage = {remplissage}");
    }
}

class Cercle : Forme
{
    private double rayon;

    public Cercle(string couleur, bool remplissage, double rayon) : base(couleur, remplissage)
    {
        this.rayon = rayon;
    }

    public void Afficher() // Redéfinition
    {
        Console.WriteLine($"Cercle {couleur}, remplissage = {remplissage}, rayon = {rayon}");
    }
}
