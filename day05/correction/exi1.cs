interface IVolant
{
void Voler();
}

class Avion : IVolant
{
public void Voler()
{
Console.WriteLine("Je vole comme un avion");
}
}

class Oiseau : IVolant
{
public void Voler()
{
Console.WriteLine("Je vole comme un oiseau");
}
}

