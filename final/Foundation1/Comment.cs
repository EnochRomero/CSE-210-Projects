

public class Comment
{
    private string _commenter; 

    private string _commentContents;


    public Comment(string commenter, string commentContents)
    {
        _commentContents = commentContents;

        _commenter = commenter;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}:{_commentContents}");
    }
}