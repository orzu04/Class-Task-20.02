namespace task2;

public class Post
{

public string Text;
public int Likes;
public List<string> Coments;

  public void SetPost(string text)
  {
    Text = text;
  }

  public void AddLike()
  {
    Likes++;
  }
  public void AddComent(string comment)
  {
    Coments.Add(comment);
  }
  public string GetInfo()
  {
    return $"Text: {Text} \n Likes: {Likes} \n Comments: {Coments} ";
  }
 

}
