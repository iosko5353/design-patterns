using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create books and attach BookShops

        book book = new book("Алиса в страната на чудесата", 12.00);
        book.Attach(new BookShop("Сиела"));
        book.Attach(new BookShop("Хеликон"));
        book.Attach(new BookShop("Orange"));

        book2 book2 = new book2("Хари Потър", 11.00);
        book2.Attach(new BookShop("Сиела"));
        book2.Attach(new BookShop("Хеликон"));
        book2.Attach(new BookShop("Orange"));

        book3 book3 = new book3("Изборът", 13.00);
        book3.Attach(new BookShop("Сиела"));
        book3.Attach(new BookShop("Хеликон"));
        book3.Attach(new BookShop("Orange"));

        // Fluctuating prices will notify BookShops

        book.Price = 12.50;
        book.Price = 12.90;


        book2.Price = 11.50;
        book2.Price = 12.50;


        book3.Price = 14.00;
        book3.Price = 14.50;


        // Wait for user

        Console.ReadKey();
    }
}

/// <summary>

/// The 'Book' abstract class

/// </summary>

abstract class Book
{
    private string _bookName;

    private double _price;

    private List<IBookShop> _BookShops = new List<IBookShop>();

    // Constructor

    public Book(string bookName, double price)
    {
        this._bookName = bookName;

        this._price = price;
    }


    public void Attach(IBookShop BookShop)
    {
        _BookShops.Add(BookShop);
    }

    public void Detach(IBookShop BookShop)

    {
        _BookShops.Remove(BookShop);
    }


    public void Notify()
    {
        foreach (IBookShop BookShop in _BookShops)
        {
            BookShop.Update(this);
        }
        Console.WriteLine("");
    }

    // Gets or sets the price

    public double Price
    {
        get { return _price; }

        set

        {

            if (_price != value)

            {

                _price = value;

                Notify();

            }

        }

    }


    // Gets the bookName

    public string BookName

    {

        get { return _bookName; }

    }

}



/// <summary>

/// The 'ConcreteSubject' class

/// </summary>

class book3 : Book

{

    // Constructor

    public book3(string bookName, double price)

      : base(bookName, price)

    {

    }

}

class book2 : Book

{

    // Constructor

    public book2(string bookName, double price)

      : base(bookName, price)

    {

    }

}

class book : Book

{

    // Constructor

    public book(string bookName, double price)

      : base(bookName, price)

    {

    }

}


/// <summary>

/// The 'Observer' interface

/// </summary>

interface IBookShop

{

    void Update(Book vegatable);

}


/// <summary>

/// The 'ConcreteObserver' class

/// </summary>

class BookShop : IBookShop

{

    private string _name;

    private Book _book;



    // Constructor

    public BookShop(string name)

    {

        this._name = name;

    }



    public void Update(Book book)

    {

        Console.WriteLine("Уведомява книжарница {0}, че цената на книгата {1} " +

          "се променя на {2:C}", _name, book.BookName, book.Price);

    }


    // Gets or sets the book

    public Book book

    {

        get { return _book; }

        set { _book = value; }

    }

}