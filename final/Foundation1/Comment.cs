using System;

public class Comment {

    private string _author;
    private string _text;

    public Comment(string author, string text) {
        SetAuthor(author);
        SetText(text);
    }

    public void SetAuthor(string author){
        _author = author;
    }

    public void SetText(string text){
        _text = text;
    }

    public string GetAuthor(){
        return _author;
    }

    public string GetText(){
        return _text;
    }

    public void Display(){
        Console.WriteLine($"\tAuthor: {_author}");
        Console.WriteLine($"\tText  : {_text}");
        Console.WriteLine("");
    }

}