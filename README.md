# Learn C#

A collection of C# console projects I built while working through Codecademy exercises. These projects cover object-oriented programming, generic collections, interfaces, and enums.

## Featured project: Library Management System

The [Library Management System](LibraryManagementSystem/) is a console demo that adds books to a catalog, lists them by category, and checks them out and returns them by ISBN. It uses a `LinkedList<Book>` for the catalog, a `Dictionary<string, List<Book>>` for category lookup, and a `Stack<Book>` for returned books awaiting reshelving.

With the .NET 10 SDK installed, run this from the repository root:

```sh
dotnet run --project LibraryManagementSystem/LibraryManagementSystem/LibraryManagementSystem.csproj
```

The demo uses sample books and prints the results to the console.

## Other exercises

- [BiblioInheritance](BiblioInheritance/) models books, periodicals, and videos with a shared base class.
- [CorporatePolymorphism](CorporatePolymorphism/) explores polymorphism through different employee roles.
- [RoverControlCenter](RoverControlCenter/) uses a shared interface for directing different types of spacecraft.
- [ExpenseTrackerApp](ExpenseTrackerApp/) explores enums and flags using expense categories and approval stages.

## Acknowledgments

The exercises in this repository come from Codecademy.
