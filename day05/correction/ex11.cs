Cercle monCercle = new Cercle(5.0);
monCercle.AfficherSurface();

Rectangle monRectangle = new Rectangle(3.0, 4.0);
monRectangle.AfficherSurface();



abstract class FormeGeometrique
{
    public abstract double CalculerSurface();

    public void AfficherSurface()
    {
        CalculerSurface();
        Console.WriteLine("La surface de la forme géométrique est de {0} unités carrées.",  CalculerSurface());
    }
}

class Cercle : FormeGeometrique
{
    private double rayon;

    public Cercle(double rayon)
    {
        this.rayon = rayon;
    }

    public override double CalculerSurface()
    {
        return  Math.PI * rayon * rayon;
    }
}

class Rectangle : FormeGeometrique
{
    private double largeur;
    private double hauteur;

    public Rectangle(double largeur, double hauteur)
    {
        this.largeur = largeur;
        this.hauteur = hauteur;
    }

    public override double CalculerSurface()
    {
        return largeur * hauteur;
    }
}