// Interface for walkable creatures
interface IWalkable
{
    void Walk();
}

// Interface for flying creatures
interface IFlyable
{
    void Fly();
}

// Class representing an animal that can walk
class Animal : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("The animal is walking.");
    }
}

// Class representing an animal that can walk and fly
class Bird : IWalkable, IFlyable
{
    public void Walk()
    {
        Console.WriteLine("The bird is walking.");
    }

    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Bird myBird = new Bird();

        myAnimal.Walk();
        myBird.Walk();
        myBird.Fly();
    }
}