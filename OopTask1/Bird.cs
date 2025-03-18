    public class Bird : Animals
    {
    public bool CanSwim;
    public Bird(string name , byte age,bool canSwim) : base(name , age) 
    {
        CanSwim = canSwim;
    }
    public string Fly()
    {
        base.Eat();
        return "fly";
    }
}

