// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserXML
{
    /// <summary>
    /// Main class for the program - ParserXmlProgram
    /// </summary>
    class ParserXmlProgram : ParserXmlTestTemplate
    {
        /// <summary>
        /// Main method. ParserLinq class is used for search
        /// </summary>
        static void Main()
        {
            Setup();

            string searchCriteria = GetSearchCriteria();

            // If User wants to quit, an "*" must be entered, otherwise the search results will be returned
            while (searchCriteria != "*") {
                Search(searchCriteria);
                searchCriteria = GetSearchCriteria();
            }

            Exit();
        }
    }
}
