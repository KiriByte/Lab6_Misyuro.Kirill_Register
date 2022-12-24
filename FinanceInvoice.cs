using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Register
{
    internal class FinanceInvoice : Document
    {
        public int sumMonth;
        public int departmentCode;
        public FinanceInvoice(int numberDoc, DateTime dateDocument, int sumMonth, int departmentCode)
        {
            this.numberDoc = numberDoc;
            this.dateDocument = dateDocument;
            this.sumMonth = sumMonth;
            this.departmentCode = departmentCode;
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Document Number: ").AppendLine(numberDoc.ToString());
            sb.Append("Date Document: ").AppendLine(dateDocument.ToString());
            sb.Append("Month sum: ").AppendLine(sumMonth.ToString());
            sb.Append("Department Code: ").AppendLine(departmentCode.ToString());
            return sb.ToString();
        }
    }
}
