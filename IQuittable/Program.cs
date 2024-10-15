
public interface IQuittable
{
    
    void Quit();
}

public class Employee : IQuittable
{
   
    public string FirstName { get; set; }
    public string LastName { get; set; }

   
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}


class Program
{
    static void Main(string[] args)
    {
       
        Employee employee = new Employee() { FirstName = "John", LastName = "Doe" };

       
        IQuittable quittableEmployee = employee;

       
        quittableEmployee.Quit();

       
        Console.ReadLine();
    }
}
