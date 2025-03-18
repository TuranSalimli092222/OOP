public class Dog : Animals
{
    public bool HasTail;
    public Dog(string name, byte age , bool hasTail) : base(name, age)
    {
        HasTail = hasTail;
    }
    public string Bark()
    {
        base.Eat();

      return "Dogs are barking";
    }
        
    }

