Movie Database Browser with API Integration
Key Features
Search Movies:

Fetch movies from the API based on user input (title or genre).
Movie Details:

Display details like title, release year, genre, cast, and synopsis for a selected movie.
Custom Watchlist:

Allow users to save favorite movies to a local watchlist using an in-memory structure (like a list or dictionary).
Responsive User Interface:

Intuitive UI with search, filter, and movie detail panels.
Event-Driven Programming:

Handle user interactions like button clicks and list selections.
Asynchronous Programming:

Use async/await to fetch data from the API without freezing the UI.
Initial Design Plan
Architecture Overview
Frontend: Windows Forms or WPF for creating an interactive GUI.
Backend: A C# class for managing API requests and handling movie data.
API Integration: Use the OMDb API for movie data.
Implementation Steps
1. Set Up the Project
Create the Project:
In Visual Studio, create a new Windows Forms or WPF project.
Install Dependencies:
Install System.Net.Http for making API requests (already included in .NET Core).
2. Configure API Access
Register for an OMDb API Key:
Go to OMDb API and get a free API key.
Create a MovieAPI Class:
This class will handle HTTP requests to the OMDb API.
