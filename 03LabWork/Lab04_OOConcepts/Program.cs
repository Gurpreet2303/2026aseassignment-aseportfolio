using System;
using System.Collections.Generic;

namespace Lab04_OOConcepts
{
    public interface IStorable
    {
        void Save();
    }

    public abstract class Document : IStorable
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        
        public abstract void Display();
        public abstract void Save();
    }

    public class TextDocument : Document
    {
        public override void Display()
        {
            Console.WriteLine($"[Text Document] Title: '{Title}', Author: '{Author}'");
        }

        public override void Save()
        {
            Console.WriteLine($"-> Saving text document '{Title}' to secure cloud storage...");
        }
    }

    public class SpreadsheetDocument : Document
    {
        public int RowCount { get; set; }

        public override void Display()
        {
            Console.WriteLine($"[Spreadsheet] Title: '{Title}', Rows: {RowCount}, Author: '{Author}'");
        }

        public override void Save()
        {
            Console.WriteLine($"-> Saving spreadsheet '{Title}' database records...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine(" Leeds Beckett University - ASE Portfolio Lab 4");
            Console.WriteLine(" Topic: Interfaces, Abstract Classes & Polymorphism");
            Console.WriteLine("==================================================\n");

            List<Document> documents = new List<Document>
            {
                new TextDocument 
                { 
                    Title = "ASE Assignment Brief 2026", 
                    Author = "Dr. Smith" 
                },
                new SpreadsheetDocument 
                { 
                    Title = "Student Grade Tracker", 
                    Author = "Gurpreet Singh", 
                    RowCount = 150 
                },
                new TextDocument 
                { 
                    Title = "Weekly Reflection Log", 
                    Author = "Gurpreet Singh" 
                }
            };

            foreach (var doc in documents)
            {
                doc.Display();
                doc.Save();
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}