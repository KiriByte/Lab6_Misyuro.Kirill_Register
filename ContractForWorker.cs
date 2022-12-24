using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Register
{
    internal class ContractForWorker : Document
    {
        public DateTime endDocument;
        public string nameWorker;
        public ContractForWorker(int numberDoc, DateTime dateDocument, DateTime endDocument, string nameWorker)
        {
            this.numberDoc = numberDoc;
            this.dateDocument = dateDocument;
            this.endDocument = endDocument;
            this.nameWorker = nameWorker;
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Document Number: ").AppendLine(numberDoc.ToString());
            sb.Append("Date Document: ").AppendLine(dateDocument.ToString());
            sb.Append("Date end Document: ").AppendLine(endDocument.ToString());
            sb.Append("Worker Name: ").AppendLine(nameWorker);
            return sb.ToString();
        }
    }
}
