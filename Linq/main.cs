using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello, World!");
        string[] names = {"Hans", "Peter", "Georg"};
        string name = names.Where(x => x == "Peter").FirstOrDefault();
        Console.WriteLine(name);
        
        List list = new List<string>();
        list.Add("Cat");
        list.Add("Mouse");
        list.Add("Dog");
        
    }
}
