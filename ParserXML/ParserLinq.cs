// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserXML
{
    #region Usings

    using System;
    using System.Linq;
    using System.Xml.Linq;

    #endregion

    /// <summary>
    /// Parsing XML using LINQ
    /// </summary>

    class ParserLinq
    {
        #region Fields and Constants

        static String XML = @"<Contacts>
                <Contact>
                    <Name> Patrick Hines </Name>
                    <Phone Type = ""home"" > 206 - 555 - 0144 </Phone>
                    <Phone Type = ""work"" > 425 - 555 - 0145 </Phone>
                    <Address>
                        <Street1> 123 Main St </Street1>
                        <City> Mercer Island </City>
                        <State> WA </State>
                        <Postal> 68042 </Postal>
                    </Address>
                    <NetWorth> 10 </NetWorth>
                </Contact>
                <Contact>
                    <Name> Gretchen Rivas </Name>
                    <Phone Type = ""mobile"" > 206 - 555 - 0163 </Phone>
                    <Address>
                        <Street1> 199 Main St </Street1>
                        <City> Dnipro </City>
                        <Postal> 60002 </Postal>
                    </Address>
                    <NetWorth> 11 </NetWorth>
                </Contact>
                <Contact>
                    <Name> Mike Black </Name>
                    <Phone Type = ""private"" > 999 - 555 - 9999 </Phone>
                    <Address>
                        <Street1> 001 Main St </Street1>
                        <City> Ternopil </City>
                        <Postal> 00001 </Postal>
                    </Address>
                    <NetWorth> 30 </NetWorth>
                </Contact>
                <Contact>
                    <Name> Anton Mailin </Name>
                    <Phone Type = ""mobile"" > 380 - 937 - 9992 </Phone>
                    <Address>
                        <Street1> 432 Main St </Street1>
                        <City> Khrystinivka </City>
                        <Postal> 20001 </Postal>
                    </Address>
                    <NetWorth> None </NetWorth>
                </Contact>
            </Contacts>";

        #endregion

        #region Methods

        public static void FindAndPrint(string namePart) {
                      
            XDocument ob = XDocument.Parse(XML);
            int found = 0;

            /// <summary>
            /// Create a list of Contact entities and fill fields Name & NetWorth for each
            /// </summary>
            var contacts = from x in ob.Descendants("Contact")
                           select new
                           {
                               Name = x.Descendants("Name").First().Value,
                               NetWorth = x.Descendants("NetWorth").First().Value,
                               Phone = x.Descendants("Phone").First().Value
                           };

            /// <summary>
            /// Find & print matching results
            /// </summary>
            foreach (var contact in contacts) {
                string[] name = contact.Name.Split(" ");

                if (name[1].ToLower().StartsWith(namePart.ToLower()) || name[2].ToLower().StartsWith(namePart.ToLower()))
                {
                    Console.WriteLine("Name:" + contact.Name + "\n" + "NetWorth:" + contact.NetWorth + "\n" + "Phone:" + contact.Phone + "\n\n");
                    found++;
                }
            }
            if (found == 0) Console.WriteLine("Sorry, nothing was found\n");
        }

        #endregion
    }
}
