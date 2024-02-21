


using task2;

var post = new Post();
post.SetPost("Norak");
post.AddLike();
post.AddLike();

post.AddComent("Sozi bad");
post.AddComent($"Be mo ha");

System.Console.WriteLine(post.GetInfo());

System.Console.WriteLine($"\n Coments {post.Coments.Count}");

int i=1;
foreach (var comment in post.Coments)
{
    System.Console.WriteLine($"{i} {comment}");
    i++;
}