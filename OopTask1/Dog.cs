public class Dog : Animals
{
    public bool HasTail;
    public Dog(string name, byte age , bool hasTail) : base(name, age)
    {
        HasTail = hasTail;
    }
    public void Bark()
    {
        base.Eat();

        Console.WriteLine("Dogs are barking");
    }
        
    }

