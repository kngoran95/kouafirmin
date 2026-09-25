using System;


public class Comment
{
    private string _commentName;
    private string _commentText;


    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }


    public string GetCommmentName()
    {
        return _commentName;
    }


    public string GetCommemntText()
    {
        return _commentText;
    }
}