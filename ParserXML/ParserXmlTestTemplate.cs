using System;

namespace ParserXML
{
    /// <summary>
    /// ParserXmlTestTemplate class contains all the methods that are used in ParserXmlProgram class
    /// </summary>
    class ParserXmlTestTemplate
    {
        #region Methods

        /// <summary>
        /// Setup method
        /// </summary>
        public static void Setup() {
            Console.Title = "XML Parser Program";
        }

        /// <summary>
        /// GetSearchCriteria method to get search criteria/exit command from the User 
        /// </summary>
        public static string GetSearchCriteria()
        {
            Console.WriteLine("Please, type the first letter(s) of the First/Last name and press Enter\n" +
                "(or enter \"*\" - asterisk, to exit)");

            return Console.ReadLine();
        }

        /// <summary>
        /// Exit method
        /// </summary>
        public static void Exit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Search method that checks search criteria type and triggers corresponding search
        /// </summary>
        public static void Search(string name)
        {
            // If User enters no criteria - all the DB info is proposed as a search result
            if (name == "") 
            {
                Console.WriteLine("Are you sure that you want to return all the results from DB?\n" +
                    "Enter \"y\" if you do, anything else otherwise");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Print("");
                    return;
                }
                else return;
            }

            // User enters valid criteria
            Print(name);
        }

        private static void Print(string name) {
            Console.WriteLine("\nSearch Results for \"" + name + "\":\n");
            ParserLinq.FindAndPrint(name);
        }

        #endregion

    }
}
