
using System.ComponentModel;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;

    private List<Comment> comments = new List<Comment>();


    public Video (string title, string author, int duration)
    {
        _title = title;

        _author = author; 

        _duration = duration;
    } 

    public void AddComment(Comment commentToAdd)
    {
        comments.Add(commentToAdd);
    }

    public int ReturnAmountOfComments()
    {
        return comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Duration(in seconds): {_duration}");
    }

    public void DisplayAllComments()
    {
        foreach(Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }

}