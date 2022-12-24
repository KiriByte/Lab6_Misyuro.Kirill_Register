using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Misyuro.Kirill_Register
{
    abstract internal class Document
    {
        public int numberDoc;
        public DateTime dateDocument;

        abstract public string GetInfo();
    }
}
