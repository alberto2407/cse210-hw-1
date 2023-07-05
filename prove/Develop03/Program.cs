using System;

class Program
{
    static void Main(string[] args)
    {
        string UserInput = "";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo Unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna.");

        while(UserInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            UserInput = Console.ReadLine();
        }    
    }
}