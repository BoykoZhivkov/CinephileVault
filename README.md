Implement a Cinephile Vault in which you can add movies and check what movies you have:

For this you will need the following classes:

1) Director - every movie has a director, and the director is described by the following properties:
		- full name
		- email
		- bio (short description)
		- toString to display the information like this "Director[name=?,email=?]"
		
2) Movie :
		- title
		- director (object)
    - category (object)
		- price    (rental/purchase price)
		- toString to display the information like this "Movie[title=?,Director[name=?,email=?],price=?]"

3) MovieCategory :
		- name            (e.g., Sci-Fi, Horror)
		- description
		- age rating      (e.g., G, PG-13, R)
		
4) CinephileVault:
		- movies (List, Collection)
    - budget (Total budget of the collection)
		- Methods to implement
			- you can add new movies
			- remove movies from the vault
			- search for a movie by its title
			- find if any movie title contains a specific word
			- see all movies in the collection
      - add/search employees by role
		- toString to display the information like this "CinemaVault[Movie=?,Movie=?,Movie=?,....]" - for all of the movies in the library

5) Employees:
		- first name
		- last name
    - email 
		- password
		- age
		- role (e.g., Critic, Admin, Moderator)
		- salary
		- toString to display all information for employee
		
		
