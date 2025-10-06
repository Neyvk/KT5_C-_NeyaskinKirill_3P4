using System;


public interface IComparable<T>
{
    int CompareTo(T other);
}
class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public int CompareTo(Student other)
    {
        int result = Grade.CompareTo(other.Grade);

        if (result == 0)
            Console.WriteLine($"{Name} и {other.Name} учатся одинаково");
        else if (result < 0)
            Console.WriteLine($"{Name} учится хуже, чем {other.Name}");
        else
            Console.WriteLine($"{Name} учится лучше, чем {other.Name}");

        return result;
    }
}

class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public int CompareTo(Book other)
    {
        int result = Price.CompareTo(other.Price);

        if (result == 0)
            Console.WriteLine($"{Title} и {other.Title} стоят одинаково");
        else if (result < 0)
            Console.WriteLine($"{Title} дешевле, чем {other.Title}");
        else
            Console.WriteLine($"{Title} дороже, чем {other.Title}");

        return result;
    }
}

class Program3
{
    static void Main()
    {
        Student Maria = new Student("Маша", 16, 4.5);
        Student Nikita = new Student("Никита", 19, 3.9);
        Book Book1 = new Book("Книга1", "Я лично писал", 100);
        Book Book2 = new Book("Книга2", "Пушкин", 150);


        Maria.CompareTo(Nikita);
        Book1.CompareTo(Book2);
    }
}
