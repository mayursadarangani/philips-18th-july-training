using System;
using System.Collections.Generic;

namespace VisitorPatternExample1
{
    //Client code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// Element
    /// </summary>
    public interface IDocumentPart
    {
        void AcceptConvert(IDocConverter docConverter);
    }

    /// <summary>
    /// ConcreteElement 1
    /// </summary>
    public class Header : IDocumentPart
    {
        public void AcceptConvert(IDocConverter docConverter)
        {
            docConverter.Convert(this);
        }
    }

    /// <summary>
    /// ConcreteElement 2
    /// </summary>
    public class Footer : IDocumentPart
    {
        public void AcceptConvert(IDocConverter docConverter)
        {
            docConverter.Convert(this);
        }
    }

    /// <summary>
    /// Visitor
    /// </summary>
    public interface IDocConverter
    {
        void Convert(IDocumentPart documentPart);
    }

    /// <summary>
    /// Visitor 1
    /// </summary>
    public class HtmlDocConverter : IDocConverter
    {
        public void Convert(IDocumentPart documentPart)
        {
            Header docPart = documentPart as Header;
            Footer doc1Part = documentPart as Footer;
        }
    }

    /// <summary>
    /// Visitor 2
    /// </summary>
    public class PdfDocConverter : IDocConverter
    {
        public void Convert(IDocumentPart documentPart)
        {
            Header docPart = documentPart as Header;
            Footer doc1Part = documentPart as Footer;
        }
    }

    /// <summary>
    /// Create Object Structure
    /// </summary>
    public class MainDocument
    {
        private List<IDocumentPart> documentParts;

        public MainDocument()
        {
            documentParts = new List<IDocumentPart>
            {
                new Header(),
                new Footer()
            };
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Convert(IDocConverter docConverter)
        {
            foreach(var parts in documentParts)
            {
                parts.AcceptConvert(docConverter);
            }
        }
    }
}
