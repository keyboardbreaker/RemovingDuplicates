/* 
"Write a function that given a list of countries, returns the country(s) 
that occur the least times. 
i.e - [""Argentina"", ""Cuba"", ""Chile"", ""Argentina""] -> [""Cuba"", ""Chile""]"                      
*/
using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        List<string> output = new List<string>();
        string[] countries = new string[] { "Argentina", "Cuba", "Chile", "Argentina" };

        Console.WriteLine("List Before: ");
        for (int i = 0; i < countries.Length; i++)
        {
            Console.WriteLine(countries[i]);
            if (output.Contains(countries[i]))
            {
                //get index of first occurence and delete it
                output.RemoveAt(output.LastIndexOf(countries[i]));
            }
            else
            {
                output.Add(countries[i]);
            }
        }

        Console.WriteLine("List After: ");
        foreach (string item in output)
            Console.WriteLine(item);
        
    }

}
