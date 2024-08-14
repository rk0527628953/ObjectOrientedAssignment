using ObjectOrientedAssignment;

Dog d1 =new Dog(0);
Cat c1=new Cat(0);  
Frog f1=new Frog(1);
Console.WriteLine(d1.ToString());
Console.WriteLine(c1.ToString());
Console.WriteLine(f1.ToString());
d1.SayHello(0);
c1.SayHello();
c1.SayHello(0);
f1.SayHello();
Console.WriteLine(f1.HasGills());
Console.WriteLine(Animal.MOOD_HAPPY);
    