namespace CinephileVault.Models;

public class Movie
{
    public string Title { get; }
    private Director MovieDirector { get; }
    private Category MovieCategory { get; }
    private double Price { get; }

    public Movie(string title, Director movieDirector, Category movieCategory, double price)
    {
        Title = title;
        MovieDirector = movieDirector;
        MovieCategory = movieCategory;
        Price = price;
    }

    public override string ToString()
    {
        return $"Movie[title = {Title}, " +
               $"Director[name = {MovieDirector.Name}, " +
               $"email = {MovieDirector.Email}, " +
               $"bio = {MovieDirector.Bio}], " +
               $"category = {MovieCategory.Name}, " +
               $"price = {Price}]";
    }
}