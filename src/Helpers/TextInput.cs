namespace Utilities;

public static class TextInputHelper
{
    public static string GetInput(string instruction)
    {
        while(true)
        {
            Console.Write(instruction);
            string? input = Console.ReadLine();
            if(input != null)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please give a proper input.");
            }
        }
    }
}