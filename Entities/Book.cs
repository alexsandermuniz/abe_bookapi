using System;

public class Book{
    public string name {get;set;}
    public string publisher {get;set;}
    public DateTime date {get;set;}
    public string type {get;set;}
    public decimal value {get;set;}

    public Book(string name, string publisher, DateTime date,string type, decimal value)
    {
        this.name = name;
        this.publisher = publisher;
        this.date = date;
        this.type = type;
        this.value = value;
    }

}