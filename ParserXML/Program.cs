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
    /// Main method. Insert search creteria here
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XML Parser\n");

            Console.WriteLine("Parsing XML using XML Text Reader. Search Results:\n");
            ParserXTR.FindAndPrint("A");

            Console.WriteLine("Parsing XML using LINQ. Search Results:\n");
            ParserLinq.FindAndPrint("*");
        }
    }
}
