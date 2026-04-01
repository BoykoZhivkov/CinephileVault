namespace CinephileVault.Models;

public class Director
{
    public string Name { get; }
    public string Email { get; }
    public string Bio { get; }

    public Director(string name, string email, string bio)
    {
        Name = name;
        Email = email;
        Bio = bio;
    }

    public override string ToString()
    {
        return $"Director[name = {Name}, email = {Email}, bio = {Bio}]";
    }
}