using System;

public abstract class Document
{
    public abstract void print();

    public void prepare_for_printing()
    {
        print();
    }
}

public class PDFDocument : Document
{
    public override void print()
    {
        Console.WriteLine("Друк PDF документа...");
    }
}

public class WordDocument : Document
{
    public override void print()
    {
        Console.WriteLine("Друк Word документа...");
    }
}

public class ExcelDocument : Document
{
    public override void print()
    {
        Console.WriteLine("Друк Excel документа...");
    }
}

public class DocumentFactory
{
    public Document CreateDocument(string type)
    {
        switch (type.ToLower())
        {
            case "pdf":
                return new PDFDocument();
            case "word":
                return new WordDocument();
            case "excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException("Невідомий тип документа");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory = new DocumentFactory();

        Document doc1 = factory.CreateDocument("pdf");
        doc1.prepare_for_printing();

        Document doc2 = factory.CreateDocument("word");
        doc2.prepare_for_printing();

        Document doc3 = factory.CreateDocument("excel");
        doc3.prepare_for_printing();
    }
}
