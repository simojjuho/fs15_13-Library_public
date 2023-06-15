using System.ComponentModel;
using LibraryManagement.BaseClasses;
using LibraryManagement.Enums;

namespace LibraryManagement.Library;

public class LibraryMember : PersonBase
{
    private LibraryMemberPrivilege _privilege;

    public LibraryMemberPrivilege Privilege => _privilege;
    
    public LibraryMember(string name) : base(name) { }
}