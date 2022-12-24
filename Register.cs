using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Register
{
    internal class Register
    {
        List<Document> documents = new List<Document>(10);

        public bool AddDocument(Document document)
        {
            if (documents.Count >= 10) { return false; }
            documents.Add(document);
            return true;
        }

        public string GetInfo(int numberDoc)
        {
            List<Document> results = documents.FindAll(item => item.numberDoc == numberDoc);
            StringBuilder sb = new StringBuilder();
            foreach (var document in results)
            {
                sb.AppendLine(document.GetInfo());
            }
            return sb.ToString();
        }
        public string GetInfo(DateTime dt)
        {
            List<Document> results = documents.FindAll(item => item.dateDocument == dt);
            StringBuilder sb = new StringBuilder();
            foreach (var document in results)
            {
                sb.AppendLine(document.GetInfo());
            }
            return sb.ToString();
        }


    }
}
