Player thePlayer = new Player();
Goomba theGoomba = new Goomba();

Console.WriteLine($"{thePlayer.name} has {thePlayer.health} health");
Console.WriteLine($"{theGoomba.name} has {theGoomba.health} health");

Console.ReadKey();

Console.WriteLine("You attacked!");
theGoomba.health -= 30;

Console.WriteLine($"{theGoomba.name} now has {theGoomba.health} health");


Console.ReadKey();

Console.WriteLine("You got attacked!");
thePlayer.health -= 20;

Console.WriteLine($"{thePlayer.name} now has {thePlayer.health} health");


Console.WriteLine("Press a key to quit");
Console.ReadKey();