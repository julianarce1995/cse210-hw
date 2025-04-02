using System;

public class Comment
{
    private string _personName;
    private string _commentText;

    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }
    public void DisplayPersonName()
    {
        Console.WriteLine("Person Name: "+_personName);
    }
    public void DisplayComment()
    {
        Console.WriteLine("Comentario: "+_commentText);
    }
}
