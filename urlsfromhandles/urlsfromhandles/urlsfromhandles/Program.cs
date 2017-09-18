using System;
using System.Collections.Generic;

namespace UrlsFromHandles
{
    class Program
    {
        static List<string> UrlsFromHandles(List<string> list)
        {
            for (int i = 0; i < list.Count; i++ )
            {
                list[i] = "https://github.com/greenfox-academy/" + list[i];
            }
            return list;
        }

        static void Main(string[] args)
        {
            // Create a function that takes a list of GitHub handles as input and returns a list of strings that represents
            // GitHub url's under Green Fox Academy organization in the following format: "https://github.com/greenfox-academy/teststudent"

            // example:
            // input: ["ghhandle1", "ghhandle2"]
            // output: ["https://github.com/greenfox-academy/ghhandle1", "https://github.com/greenfox-academy/ghhandle2"]
            List<string> gitHubUrls = UrlsFromHandles(new List<string> { "ghhandle1", "ghhandle2" });

            for (int i = 0; i < gitHubUrls.Count; i++)
            {
                Console.WriteLine(gitHubUrls[i]);
            }
            Console.ReadLine();
        }
    }
}