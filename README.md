# Student Portal MVC Project

This is a simple MVC (Model-View-Controller) project built with ASP.NET Core for managing students. It allows you to perform CRUD (Create, Read, Update, Delete) operations on student records stored in a SQL database.

## Features

- Add new students
- View a list of all students
- Edit existing student records
- Delete student records

## Getting Started

To run this project locally, follow these steps:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
3. Make sure you have the necessary dependencies installed. If not, restore packages using NuGet Package Manager.
4. Set up your SQL database. You can use Entity Framework Core migrations to create the necessary tables.
5. Configure your database connection string in `appsettings.json`.
6. Build and run the project.

## Project Structure

The project structure is organized as follows:

- **Controllers**: Contains controller classes responsible for handling HTTP requests and responses.
- **Models**: Contains the entity models used in the application.
- **Views**: Contains the Razor views that define the UI for the application.
- **Data**: Contains the DbContext class (`ApplicationDbContext`) for interacting with the database.
- **Migrations**: Contains Entity Framework Core migrations for managing database schema changes.

## Dependencies

This project relies on the following dependencies:

- ASP.NET Core
- Entity Framework Core
- Bootstrap (for styling)
- jQuery (for client-side scripting)

## Credits

This project was built with reference to a tutorial by Sameer Saini. You can find the tutorial [here](https://www.youtube.com/watch?v=_uSw8sh7xKs).
