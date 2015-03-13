using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(String[] args)
    {
        Bob bob = new Bob();
       
        Console.WriteLine( bob.Hey("1,2"));

        Console.ReadKey();
    }
}

class Bob
{
   
    public string Hey(string bobsWords)
    {
        //check for silence
        bool allSpaces = true;
        foreach (Char c in bobsWords)
        {
            if (!Char.IsWhiteSpace(c))
            {
                allSpaces = false;
                break;
            }              
        }
        if (allSpaces || bobsWords.Length == 0)
        {
            return "Fine. Be that way!";
        }

        //chech for yelling string (only char uppercase)
        bool stringIsUpper = true;
        foreach (Char c in bobsWords)
        {
            if (!Char.IsUpper(c))
            {
                if (Char.IsLetter(c) || Char.IsDigit(c))
                {
                    stringIsUpper = false;
                    break;
                }               
            }
        }

        if (stringIsUpper)
            return "Whoa, chill out!";

        //check if it's a question
        if (bobsWords.Contains("?") && (bobsWords.IndexOf('?')==bobsWords.Length-1))
        {
            return "Sure.";
        }



        return "Whatever.";

    }
}



