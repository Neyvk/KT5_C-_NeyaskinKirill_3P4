using System;

interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}

class Dog : IAnimal
{
    string _Name;
    public string Name
    {
        get {return _Name;}
        set {_Name = value;} 
    }

    public Dog(string name)
    {
        _Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав");
    }
}

class Cat : IAnimal
{
    string _Name;
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public Cat(string name)
    {
        _Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Бобик");
        Cat cat = new Cat("Мурка");

        dog.MakeSound();
        cat.MakeSound();
    }
}
