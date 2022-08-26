// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserXML
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// Main class for the program - Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method. Insert search creteria here
        /// </summary>
        static void Main(string[] args)
        {
            Console.Title = "XML Parser Program";

            m1:
            Console.WriteLine("Please, type the first letter(s) of the First/Last name and press Enter\n" +
                "(or enter \"*\" - asterisk, to quit)");
            string name = Console.ReadLine();

            // User wants to quit
            if (name == "*") Environment.Exit(0);

            // User enters no criteria
            if (name == "")
            {
                Console.WriteLine("Are You sure You want to return all the results from BD?\n" +
                    "Enter \"y\" if You do, anything else otherwise");
                string answer = Console.ReadLine();
                if (answer == "y") ParserLinq.FindAndPrint("");
                goto m1;
            }

            // User enters criteria
            Console.WriteLine("\nSearch Results for \"" + name + "\":\n");
            ParserLinq.FindAndPrint(name);

            goto m1;
        }
    }
}
