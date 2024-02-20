namespace task1;

public class Person
{
  public string FirstName;
  public string LastName;
  public int Age;


  public void GetInfo()
  {
       System.Console.WriteLine($"Enter your FirstName : ");
       System.Console.WriteLine($"FirstName: {FirstName}");
       System.Console.WriteLine($"Enter your LastName : ");
       System.Console.WriteLine($"LastName: {LastName}");
       System.Console.WriteLine($"Enter your Age : ");
       System.Console.WriteLine($"Age: {Age}");

  }
}
