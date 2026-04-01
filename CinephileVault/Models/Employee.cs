namespace CinephileVault.Models;

public class Employee
{
    private string FirstName { get; }
    private string LastName { get; }
    private string Email { get; }
    private string Password { get; set; }
    private int Age { get; }
    public RoleType Role { get; }
    private double Salary { get; }

    public Employee(string firstName, string lastName, string email, int age, RoleType role, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        Role = role;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee[first_name = {FirstName}, " +
               $"last_name = {LastName}, " +
               $"email = {Email}, " +
               $"age = {Age}, " +
               $"role = {Role}, " +
               $"Salary = {Salary}]";
    }
}
    
    