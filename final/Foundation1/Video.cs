using System;

public class Video
{

    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenter, string text)
    {
        Comments.Add(new Comment(commenter, text));
    }

    public int GetNumberofComments()
    {
        return Comments.Count;
    }
}