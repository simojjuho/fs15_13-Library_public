using LibraryManagement.LibraryUI.cs;

namespace LibraryManagement;

class Program
{
    static void Main()
    {
        BookUi bookUi = new BookUi();
        var book = bookUi.MakeABook();
        Console.WriteLine(book);
    }
}