## Factory

By Gurshan Kaile

## Description 

This web app is an application using many to many relationships between engineers and the machines they will use. A user can view a list of both machines and engineers, as well as their shared relationships. 

## Technologies 

* C#
* ASP.NET 5.0
* MVC MySQL database
* Migrations 
* NuGet
* Razor Pages
* Entity Framework

## Installation/Setup

* Download and install ``` .NET 5 SDK ``` for your device

* Download MySQL WorkBench 

* Clone this repo to your local machine

* Navigate to ``` Factory.Solutions ``` directory and open in your preferred text editor

* Create an ``` appsettings.json ``` file in the ``` Factory ``` directory 

* Copy and past the following code in ``` appsettings.json ``` file. 
``` 
 {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={first_last};uid=root;pwd={Your Password};"
  }
}  
```
* Replace ``` first_last ``` and ``` your password ``` with the correct information

* In the factory directory, run the terminal command ``` dotnet restore ``` 

* Run ``` dotnet ef migrations add Initial ``` to build migrations Folder

* Run ``` dotnet database update ``` to implement the database structure

* Run ``` dotnet watch run ``` to open live broswer 

## Future Goals 

* Update UI with styling

## License 

__MIT__ 

## Contact Information 

gurshankaile206@gmail.com

