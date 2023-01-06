
Animal animal = new Animal("Tigre");
animal.MakeSound(); // Affiche "L'animal Tigre fait ouah ouah"

Dog dog = new Dog("Buddy");
dog.MakeSound(); // Affiche "Le chien Buddy fait ouaf ouaf"

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        this.Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"L'animal {Name} fait ouah ouah");
    }
}


public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"Le chien {Name} fait ouaf ouaf");
    }
}