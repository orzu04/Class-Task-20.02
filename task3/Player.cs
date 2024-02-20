namespace task3;

public class Player
{

public string Name;
public int Number;
public string Position;
public string Team;


public void ScoreGoal()
{
     System.Console.WriteLine($" {Name} ({Number}) scores a goal");
     System.Console.Write($" {Name} ({Number}) assist a goal for ");

}

public void AssistGoal(string name,int number)
{
    Name= name;
    Number = number;
    System.Console.WriteLine($"{Name} ({Number})");

}

public void GetInfo()
{
    System.Console.WriteLine($"Name: {Name} ");
    System.Console.WriteLine($"Number:{Number}");
    System.Console.WriteLine($"Position: {Position}");
    System.Console.WriteLine($"Team: {Team}");
    
}

}
