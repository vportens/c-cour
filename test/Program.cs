// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine(Personne.nbPersonne); // affichera 0
Personne Bob = new Personne("Bob");
Console.WriteLine(Personne.nbPersonne); // affichera 1
// Console.WriteLine(Bob.nbPersonne); // affichera error
// car la static n'est pas accessible via Bob


public class Personne {
    public string nom;
    public static int nbPersonne = 0;

	public Personne(string c_nom) {
		nom = c_nom;
		nbPersonne++;
	}

}