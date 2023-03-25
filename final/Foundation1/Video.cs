using System;

public class Video {
    private string _author;
    private string _title;
    private int _duration;
    private List<Comment> _listComment = new List<Comment>();

    public Video(string author, string title, int duration){
        SetAuthor(author);
        SetTitle(title);
        SetDuration(duration);
    }

    public string GetAuthor(){
        return _author;
    }
    
    public string GetTitle(){
        return _title;
    }
    
    public int GetDuration(){
        return _duration;
    }
    
    public int GetNumberOfComments(){
        return _listComment.Count;
    }
    
    public List<Comment> GetComments(){
        return _listComment;
    }

    
    public void SetAuthor(string author){
        _author = author;
    }
    
    public void SetTitle(string title){
        _title = title;
    }
    
    public void SetDuration(int duration){
        _duration = duration;
    }
    
    public void AppendToComments(Comment comment){
        _listComment.Add(comment);
    }

    public void Display(){
        Console.WriteLine("");
        Console.WriteLine("Video information");
        Console.WriteLine("-----------------");
        Console.WriteLine( $"Title   : {_title}" );
        Console.WriteLine( $"Author  : {_author}" );
        Console.WriteLine( $"Duration: {_duration.ToString()}" );
        Console.WriteLine("Comments:");

        foreach (Comment comment in _listComment){
            comment.Display();
        }

    }

}