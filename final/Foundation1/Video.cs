using System.ComponentModel.DataAnnotations;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();

    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _commentList;
    }

    public int GetCommentCount()
    {
        return _commentList.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }
}