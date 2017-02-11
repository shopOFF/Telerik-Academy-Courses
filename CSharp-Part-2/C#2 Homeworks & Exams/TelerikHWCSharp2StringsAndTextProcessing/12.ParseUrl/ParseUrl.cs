using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseUrl
{
    static void ExtractElements(string input )
    {
        int protocolIndex = input.IndexOf(":");  // form 0 to serverIndex
        int serverIndex = input.IndexOf("//") + 2;  // from protocolIndex to resourceIndex
        int resourceIndex = input.IndexOf("/", serverIndex); // from resourceIndex to input.length-1

        string protocol = input.Substring(0, protocolIndex);
        string server = input.Substring(serverIndex, resourceIndex - serverIndex);
        string resource = input.Substring(resourceIndex, input.Length -  resourceIndex);

        Console.WriteLine("[protocol] = {0}",protocol);
        Console.WriteLine("[server] = {0}",server);
        Console.WriteLine("[resource] = {0}",resource);
    }
    static void Main()
    {
        string input = Console.ReadLine();
        ExtractElements(input);
    }
}