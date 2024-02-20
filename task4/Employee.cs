namespace task4;

public class Employee
{

 public string FirstName;
 public string LastName;
 public int Age;
 public string Position;
 public float Salary;

 public void GetInfo()
 {
      System.Console.WriteLine($"Enter employee's FirstName: FirsName {FirstName}");
      System.Console.WriteLine($"Enter employee's LastName: LastName {LastName}");
      System.Console.WriteLine($"Enter employee's Age: Age {Age}");
      System.Console.WriteLine($"Enter employee's Position: Position {Position} ");
      System.Console.WriteLine($"Enter employee's Salary: Salary {Salary}");
 }
 
  public void SetSalary(float salary)
  {
    Salary = salary;
    System.Console.WriteLine($"Set a new Salary: {Salary}");
  
    
  }
    public float GetSalary()
    {
        return Salary;
    }
}
