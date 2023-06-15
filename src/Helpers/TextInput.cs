namespace LibraryManagement.Helpers;

public static class TextInputHelper
{
    public static string GetInput(string instruction)
    {
        while(true)
        {
            Console.Write(instruction);
            var Input = Console.ReadLine();
            if(Input != null)
            {
                return Input;
            }
            else
            {
                Console.WriteLine("Please give a proper input.");
            }
        }
    }
}