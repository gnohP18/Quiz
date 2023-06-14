## About this solution

This is a minimalist, non-layered startup solution with the ABP Framework. All the fundamental ABP modules are already installed.

## How to run
Change your `server`, `port`, `username`, `password` from your MySql

The application needs to connect to a database. Run the following command in the `gnohp18.quiz` directory:

````bash
dotnet run --migrate-database
````

After run database. To run API of project, following CLI: 

````bash
dotnet watch run
````

There are 5 table in this project (continue update)
- Player
- TypeOfQuestion
- Question
- Answer
- Result

This will create and seed the initial database. Then you can run the application with any IDE that supports .NET.

Happy coding..!



