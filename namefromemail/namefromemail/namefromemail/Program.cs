using System;

namespace NameFromEmail
{
    class Program
    {
        static string NameFromEmail (string email)
        {
            var emailchar = email.ToCharArray();
            int i;
            int j;

            for (i = 0; email[i] != '.'; i++) ;

            string firstName = new string(emailchar, 0, i);
            char[] letters = firstName.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            firstName = new string(letters);

            for (j = 0; email[j + i] != '@'; j++) ;

            string lastName = new string(emailchar, i + 1, j - 1);
            letters = lastName.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            lastName = new string(letters);

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