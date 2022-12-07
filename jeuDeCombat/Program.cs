// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

jeu test = new jeu();
test.main();
public class jeu {
    public void main() {
        MageGeurrier mageG = new MageGeurrier();
        Gobelin FredLeGobelin = new Gobelin();

        mageG.attaquer(FredLeGobelin);
        mageG.bouleDeFeu(FredLeGobelin);
        FredLeGobelin.attaquer(mageG);
        mageG.bouleDeFeu(FredLeGobelin);
        Console.WriteLine("Fred Le Gobelin a " + FredLeGobelin.pv + " points de vie");
        mageG.bouleDeFeu(FredLeGobelin);
        mageG.bouleDeFeu(FredLeGobelin);
        mageG.bouleDeFeu(FredLeGobelin);

    }
}
