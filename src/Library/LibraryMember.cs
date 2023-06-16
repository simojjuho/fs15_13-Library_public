using System.ComponentModel;
using LibraryManagement.BaseClasses;

namespace LibraryManagement.Library;

public abstract class LibraryMember : PersonBase
{
    public LibraryMember(string name) : base(name) { }
}