using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CinephileVault.Models;

public class CinephileVault
{
    public ObservableCollection<Movie> Movies { get; }
    public ObservableCollection<Employee> Staff { get; }
    public double Budget { get; set; }

    public CinephileVault(double budget)
    {
        Movies = new ObservableCollection<Movie>();
        Staff = new ObservableCollection<Employee>();
        Budget = budget;
    }

    public void AddMovie(Movie movie)
    {
        if (!Movies.Contains(movie))
        {
            Movies.Add(movie);
        }
    }

    public void RemoveMovie(Movie movie)
    {
        Movies.Remove(movie);
    }

    public Movie? GetMovieByTitle(string title)
    {
        return Movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public List<Movie> FindMoviesContaining(string keyword)
    {
        return Movies.Where(m => m.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Employee> GetEmployeesByRole(string role)
    {
        return Staff.Where(e => string.Equals(e.Role.ToString(), role, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public override string ToString()
    {
        var movieTitles = string.Join(", ", Movies.Select(m => m.Title));
        return $"Vault[Movies = {movieTitles}]";
    }
}