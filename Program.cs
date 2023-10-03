namespace Exercise4._4;

class Program
{
    static void Main(string[] args)
    {
        #nullable disable
        int numWords; 
        
        Console.WriteLine("Welcome to Exercise 4.4 Pre learning!");

        Console.WriteLine();
        Console.Write("Enter number of words: ");
        numWords = int.Parse(Console.ReadLine());
        Console.WriteLine();   
        
        string[] wordArray = new string[numWords];
        
        for (int i = 0; i < numWords; i++)
        {
            Console.Write("Enter a word: ");
            wordArray[i] = Console.ReadLine();
        }

        Console.Write("Your sentence is :");
        for (int i = 0; i < numWords; i++)
        {
            Console.Write("{0} ", wordArray[i]);           
        }
        
        Console.WriteLine();
        Console.WriteLine("Your reversed words are :");
        Array.Reverse(wordArray);

        for (int i = 0; i < numWords; i++)
        {
            Console.WriteLine("{0} ", wordArray[i]);           
        }
        
        //Console.WriteLine(wordArray.Length);
    }
}
