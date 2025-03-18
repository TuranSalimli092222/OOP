Animals animal = new Animals("shengulum" , 9 );

Console.WriteLine($"heyvanimin adi:{animal.Name},heyvanimin yashi {animal.Age}");

animal.Eat();

Dog alabash = new Dog("Alabash",6,true);

Console.WriteLine($"Itin adi:{alabash.Name},Itin yashi {alabash.Age}, quyruguda {alabash.HasTail}");

Console.WriteLine(alabash.Bark());

Bear ayi = new Bear("Turo",20,true);

Console.WriteLine($"Ayinin adi:{ayi.Name},Ayinin yashi {ayi.Age}, vesildirmi? {ayi.IsWild}");

ayi.Eat();

Bird kanarya = new Bird("fener",5,false);

Console.WriteLine($"Qushun adi:{kanarya.Name},Qushun yashi {kanarya.Age}, uze bilirmi?? {kanarya.CanSwim}");

Console.WriteLine( kanarya.Fly());