using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CinephileVault.Models;

namespace CinephileVault.Views;

public partial class MainWindow : Window
{
    private readonly CinephileVault.Models.CinephileVault _vault;
    public MainWindow()
    {
        InitializeComponent();

        _vault = new CinephileVault.Models.CinephileVault(500000);

        // --- Directors ---
        var nolan = new Director("Christopher Nolan", "nolan@imax.com", "Loves manipulating with time");
        var villenueve = new Director("Denis Villenueve", "denis@films.com", "Master of Sci-Fi");
        var safdie = new Director("Josh Safide", "josh@safdie.com", "Known for high-tension stories");
        var nakache = new Director("Olivier Nakache", "olivier@nakache.com", "Known for making my fav movie");
        
        // --- Categories ---
        var scifi = new Category(Genre.SciFi, "Mind-bending", 13);
        var drama = new Category(Genre.Drama, "Emotional storytelling", 12);
        var comedy = new Category(Genre.Comedy, "Funny", 0);
        var mystery = new Category(Genre.Mystery, "Tension and thriller", 16);
        
        // --- Employees ---
        var emp = new Employee("Boyko", "Zhivkov", "jivkov.boiko@gmail.com", 21, RoleType.Admin, 1000);
        _vault.Staff.Add(emp);
        
        // --- Movies ---
        _vault.AddMovie(new Movie("Interstellar", nolan, scifi, 19.99));
        _vault.AddMovie(new Movie("The Intouchables", nakache, comedy, 14.99));
        _vault.AddMovie(new Movie("Arrival", villenueve, scifi, 12.50));
        _vault.AddMovie(new Movie("Incendies", villenueve, mystery, 15.00));
        _vault.AddMovie(new Movie("Marty Supreme", safdie, drama, 18.00));

        // Show all movies by default
        ResultsList.ItemsSource = _vault.Movies;
    }

    private void OnSearchTitleClick(object sender, RoutedEventArgs e)
    {
        // Get the text from the TextBox named 'SearchInput'
        var searchText = SearchInput.Text ?? "";
        
        // Use search logic
        var movie = _vault.GetMovieByTitle(searchText);

        // Update the list with the result
        ResultsList.ItemsSource = movie != null ? new List<Movie> { movie } : null;
    }

    private void OnSearchRoleClick(object sender, RoutedEventArgs e)
    {
        var roleText = SearchInput.Text ?? "";
        
        var employees = _vault.GetEmployeesByRole(roleText);
        
        ResultsList.ItemsSource = employees;
    }
}