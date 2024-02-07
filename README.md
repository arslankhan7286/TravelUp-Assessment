# ASP.NET Core Assessment Project

## Overview
This project is an ASP.NET Core application that demonstrates the creation of a simple web API using the MVC (Model-View-Controller) pattern. The core components of the project include a model named `ItemModel` with attributes `name` and `id`. Additionally, a Web API has been implemented in the `Controllers/Api/ItemApiController` directory.

## Features
- **ItemModel:**
  - A model representing an item with attributes `name` and `id`.

- **Web API:**
  - The application includes a Web API located in `Controllers/Api/ItemApiController` to handle CRUD (Create, Read, Update, Delete) operations for the `ItemModel`.

- **JS/AJAX Integration:**
  - The API is consumed and utilized in the Razor script within the item view. This integration allows dynamic interaction with the API using JavaScript and AJAX.

## Getting Started

Follow these instructions to set up and run the ASP.NET Core Assessment Project on your local machine.

### Prerequisites
- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Running Migrations
1. Open a terminal or command prompt in the root directory of the project.
2. Run the following command to apply migrations and create the database:
   ```bash
   dotnet ef database update
   ```

### Running the Application
1. In the terminal or command prompt, navigate to the project's root directory.
2. Run the following command to start the application:
   ```bash
   dotnet run
   ```
3. Open your web browser and navigate to [http://localhost:5000](http://localhost:5000) to access the application.

## Usage
- Upon running the application, you can interact with the API through the provided Razor view, where JavaScript and AJAX are employed to make dynamic requests to the Web API.

## License
This project is licensed under the [MIT License](LICENSE) - see the [LICENSE](LICENSE) file for details.