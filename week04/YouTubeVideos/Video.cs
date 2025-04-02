using System;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    public string GetTitle() { return _title; }
    public void SetTitle(string title) { _title = title; }
    public string GetAuthor() { return _author; }
    public void SetAuthor(string author) { _author = author; }
    public int GetLength() { return _lengthInSeconds; }
    public void SetLength(int lengthInSeconds) { _lengthInSeconds = lengthInSeconds; }
    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoData()
    {
        Console.WriteLine("Video Title: "+_title);
        Console.WriteLine("Video Author: "+_author);
        Console.WriteLine("Duration Video: "+_lengthInSeconds);
        int numberOfCommentsInVideo = NumberOfComments();
        Console.WriteLine("Number of Comments in the video: "+numberOfCommentsInVideo);
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayPersonName();
            comment.DisplayComment();
        }
    }
}
