# Assignment: Library Management System
made by: Juho Simojoki

The goal of this assignment is to implement a basic Library Management System as a C# console application. This application will help you practice key principles of Object-Oriented Programming: Encapsulation, Abstraction, Inheritance, and Polymorphism.

## Description

This project does not have an interactive UI, but rather it's got some statements with which to demonstrate how the program works.

The projet wasn't very easy, as I find the lack of proper planning slowing down the development drastically. And at the same time it also might have brought some illogicalities into the project

What I am really proud of in this project is the use of generic classes instead of making just the library class, LoanServiceBase, that I could use in any other similar services with very little changes. It's not perfect, but I believe this gives me a lot more comfort to use abstraction later on as well.

## Required features

1. `Library` should manage the collection of Book objects, and `Person` objects. This class should have following methods:
   - Add, Remove, Borrow, and Return books
   - Add, Remove, Edit `Person` objects
2. `Person` has properties such as Name and ID. `Customer` and `Librarian` should inherit from this class and have additional properties/features:
   - `Customer` can Borrow and Return books.
   - `Librarian` can Add, Remove, Edit books.
3. `Book` has properties like Title, Author, ISBN, PublicationYear, CanBorrow, and CanPrint. To simplify the logic, we can consider each book an unique record with unique ISBN in the `Library`. In addition, `Book` has `PrintInfo()` method to print information about each book (uses `Console.WriteLine`). `Comic`, `Novel`, `TextBook`, and `ResearchPaper`should inherit properties from `Book` and have additional properties/features:
   - `Comic` has `Artist`, `Novel` has `Genre`
   - `Comic`, `Novel`, `TextBook` can be borrowed, but `ResearchPaper` cannot. If books are borrowable, they should have both `Borrow()` and `Return()` method
   - `TextBook`, and `ResearchPaper` can be printed (to certain amount of pages), but `Comic`, `Novel` cannot. The `PrintPages(int startPage, endPage)`method uses `Console.WriteLine` to inform the start page and end page to be printed, in case the amount of to-be-printed pages do not exceed the maximum allowed pages.
   - `Comic`and `Novel` should have different implementations of `PrintInfo()` with extra information about the extra properties, while `TextBook`, and `ResearchPaper` have default implementation.

## Further fields of learning

There are some things identified, that require me to learn more of them in the future.

1. Proper planning of the project and class structure.
2. More of abstraction. Some classes should be abstracted even more and made generic classes.
3. Single Responsibility principle has not been implemented enough at all.
4. Also Open / Close principle, which would benefit greatly oof better planning.

## Project tree

```
├── Folder.DotSettings.user
├── LibraryManagement.csproj
├── README.md
└── src
    ├── BaseClasses
    │   ├── ItemBase.cs
    │   ├── LoanBase.cs
    │   ├── LoanServiceBase.cs
    │   └── PersonBase.cs
    ├── Helpers
    │   └── TextInput.cs
    ├── Interfaces
    │   └── IPrintable.cs
    ├── Library
    │   ├── Book.cs
    │   ├── BookLoan.cs
    │   ├── Borrowable.cs
    │   ├── Comic.cs
    │   ├── Customer.cs
    │   ├── Librarian.cs
    │   ├── Library.cs
    │   ├── LibraryMember.cs
    │   ├── Novel.cs
    │   ├── ResearchPaper.cs
    │   └── TextBook.cs
    └── Program.cs

```