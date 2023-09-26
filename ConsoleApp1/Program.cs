// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Mammal
{

    public virtual string GetTypeName()
    {
        return "This is a mammal";
    }
}
class Horse : Mammal
{

    public override string GetTypeName()
    {
        return "This is a horse";
    }
}
class Whale : Mammal
{

    public override string GetTypeName()
    {
        return "This is a whale";
    }
}
class Aardvark : Mammal
{

}
class program
{
    static void Main(string[] args)

    {
        Mammal myMammal;
        Horse myHorse = new Horse();
        Whale myWhale = new Whale();
        Aardvark myAardvark = new Aardvark();
        myMammal = myHorse;
        Console.WriteLine(myMammal.GetTypeName()); // Horse
        myMammal = myWhale;
        Console.WriteLine(myMammal.GetTypeName()); // Whale
        myMammal = myAardvark;
        Console.WriteLine(myMammal.GetTypeName()); // Aardvark

    }
}










//using System;

//class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Some  animal sound");
//    }
//}

//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Woof! Woof!");
//    }
//}

//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Meow!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal[] animals = new Animal[]
//        {
//            new Dog(),
//            new Cat(),
//            new Dog(),
//            new Cat()
//        };

//        foreach (Animal animal in animals)
//        {
//            animal.MakeSound();
//        }
//    }
//}
