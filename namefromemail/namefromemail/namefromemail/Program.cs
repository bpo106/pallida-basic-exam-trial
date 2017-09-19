using System;

namespace NameFromEmail
{
    class Program
    {
        static string Subname (string email, int from, int to)
        {
            char[] letters = (email.Substring(from, to)).ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }

        static string NameFromEmail (string email)
        {
            string firstName = Subname(email, 0, email.IndexOf('.'));

            string lastName = Subname(email, email.IndexOf('.') + 1, email.IndexOf('@') - email.IndexOf('.') - 1);

            email = string.Concat(lastName, " ", firstName);

            return email;
        }

        static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }
    }

    internal class StringBuilder
    {
    }
}