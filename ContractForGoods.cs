using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Register
{
    internal class ContractForGoods : Document
    {
        public string typeGoods;
        public int amountGoods;
        public ContractForGoods(int numberDoc, DateTime dateDocument, string typeGoods, int amountGoods)
        {
            this.numberDoc = numberDoc;
            this.dateDocument = dateDocument;
            this.typeGoods = typeGoods;
            this.amountGoods = amountGoods;
        }

        public override string GetInfo()
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Document Number: ").AppendLine(numberDoc.ToString());
            sb.Append("Date Document: ").AppendLine(dateDocument.ToString());
            sb.Append("Type Goods: ").AppendLine(typeGoods);
            sb.Append("Amount Goods: ").AppendLine(amountGoods.ToString());
            return sb.ToString();
        }
    }
}
