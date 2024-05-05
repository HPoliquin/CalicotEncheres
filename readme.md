# Calicot Echères

## Description

Calicot Echères is a robust and efficient auction platform designed to facilitate online bidding. It provides a user-friendly interface for both buyers and sellers, ensuring a seamless auction experience.

For sellers, it offers easy listing of items with detailed descriptions and images. For buyers, it provides a secure and transparent bidding process with real-time updates.

Built with a focus on performance and security, Calicot Echères aims to revolutionize the online auction industry.

## Application Features

1. **User Registration and Authentication**: Users can create an account and log in to the application.

2. **Item Listing**: Sellers can list items for auction, providing detailed descriptions and images.

3. **Bidding**: Buyers can place bids on listed items. The application provides real-time updates on the bidding process.

4. **Search and Filter**: Users can search for items and filter the results based on various criteria such as category, price range, etc.

5. **User Profiles**: Users have profiles where they can manage their listed items, bids, and personal information.

6. **Notifications**: Users receive notifications about bidding updates, auction outcomes, and other relevant information.

7. **Security**: The application implements robust security measures to protect user information and ensure a fair bidding process.

## Code Structure

The directory structure for the Calicot Echères application is as follows:

- `.vscode`: This directory is used by Visual Studio Code to store project-specific settings.

- `Auctions`: This is the main directory for the application.

- `Areas`: In ASP.NET Core, areas are used to partition a large application into smaller, more manageable pieces. The `Identity` area likely contains code related to user authentication and authorization.

- `bin`: This directory contains the compiled output of the project.

- `Controllers`: This directory contains the controller classes responsible for handling user input in an MVC (Model-View-Controller) application.

- `Data`: This directory contains code related to data access, including database context classes, migrations, and data services.

- `Models`: This directory contains classes that represent the data in the application.

- `obj`: This directory contains temporary files used by the .NET build system.

- `Properties`: This directory typically contains the `launchSettings.json` file, which configures the settings for running the application.

- `Views`: This directory contains the Razor view files, which are used to generate the HTML that is sent to the client.

- `wwwroot`: This directory contains static files, such as CSS, JavaScript, and images. The `lib` subdirectory contains libraries like Bootstrap and jQuery.

The `bin` and `obj` directories contain subdirectories for different languages, which are likely related to localization of system messages in those languages. The `runtimes` directory contains platform-specific native code.

## Framework list and dependancies

### Framework

- .NET 7.0

### Dependencies

- Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 7.0.5
- Microsoft.AspNetCore.Identity.EntityFrameworkCore 7.0.5
- Microsoft.AspNetCore.Identity.UI 7.0.5
- Microsoft.EntityFrameworkCore.SqlServer 7.0.10
- Microsoft.EntityFrameworkCore.InMemory 7.0.10
- Microsoft.EntityFrameworkCore.Tools 7.0.10
- Microsoft.VisualStudio.Web.CodeGeneration.Design 7.0.
