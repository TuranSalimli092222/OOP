public class Bear : Animals
    {
    public bool IsWild;
    public Bear(string name,byte age , bool isWild) : base(name,age) 
    {
        IsWild = isWild;
    }
    public void Eat()
    {
        Console.WriteLine("“Able to eat”");
    }
}

