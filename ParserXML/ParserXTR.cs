// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------


namespace ParserXML
{
    #region Usings

    using System;
    using System.Xml;

    #endregion

    /// <summary>
    /// Parsing XML using XML Text Reader
    /// </summary>

    class ParserXTR
    {
        /// <summary>
        /// Find & print matching results
        /// </summary>
        public static void FindAndPrint(string namePart)
        {
            string[,] db = ParseXML("C:\\Users\\user\\source\\repos\\ParserXML\\ParserXML\\Contacts.xml");
            int found = 0;

            for (int i = 0; i < 4; i++) {
                if (db[i, 0] != null && db[i, 0].Contains(namePart)) {
                    Console.WriteLine("Name: " + db[i, 0] + ";\n" + "NetWorth: " + db[i, 1] + ";\n\n");
                    found++;
                }
            }
            if (found == 0) Console.WriteLine("Sorry, nothing was found\n");
        }

        /// <summary>
        /// Get contact's Name & NetWorth and collect them into array 'contacts' and return this array
        /// </summary>
        private static string[,] ParseXML(string url) {
            XmlTextReader xtr = new XmlTextReader(url);
            string[,] contacts = new string[4, 2];
            int i = 0, j = 0;

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Name")
                {
                    contacts[i, 0] = xtr.ReadElementContentAsString();
                    i++;
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "NetWorth")
                {
                    contacts[j, 1] = xtr.ReadElementContentAsString();
                    j++;
                }
            }
            return contacts;
        }
    }
}
