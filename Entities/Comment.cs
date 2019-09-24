using System;

public class Comment{
    public string nameAuthor {get;set;}
    public string text {get;set;}
    public DateTime date {get;set;}

    public Comment(string nameAuthor, string text, DateTime date)
    {
        this.nameAuthor = nameAuthor;
        this.text = text;
        this.date = date;
    }

}