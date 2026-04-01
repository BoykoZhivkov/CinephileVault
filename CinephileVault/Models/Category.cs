namespace CinephileVault.Models;

public class Category
{
    public Genre Name { get; }
    public string Description { get; set; }
    public int AgeRestriction { get; set; }

    public Category(Genre name, string description, int ageRestriction)
    {
        Name = name;
        Description = description;
        AgeRestriction = ageRestriction;
    }
}