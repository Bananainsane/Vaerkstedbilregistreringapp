Person p = new Person();
Person p2 = new Person("John", "Doe");

Console.WriteLine($"{p.SayHello()}");
Console.WriteLine($"{p2.SayHello()}");
Console.WriteLine($"Min bil er en {p2.MinBil.mærke} min alder er : {p2.age}");