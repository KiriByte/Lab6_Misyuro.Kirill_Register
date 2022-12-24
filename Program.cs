namespace Lab6_Misyuro.Kirill_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reg = new Register();

            reg.AddDocument(new ContractForGoods(123, DateTime.Now, "Clothes", 50));
            reg.AddDocument(new ContractForGoods(342, new DateTime(1992, 6, 3), "Guns", 30));
            reg.AddDocument(new ContractForGoods(5426, DateTime.Today, "Alcohol", 60));
            reg.AddDocument(new ContractForWorker(65323, DateTime.Today, DateTime.Today.AddDays(356), "Mike"));
            reg.AddDocument(new ContractForWorker(147, DateTime.Today, DateTime.Today.AddDays(125), "Artem"));
            reg.AddDocument(new ContractForWorker(32546, DateTime.Today, DateTime.Today.AddDays(356), "Noname"));
            reg.AddDocument(new FinanceInvoice(142563, DateTime.Today, 5555, 32546));
            reg.AddDocument(new FinanceInvoice(1245, DateTime.Today, 4444, 3455));
            reg.AddDocument(new FinanceInvoice(1234, DateTime.Today, 11111, 124));
            reg.AddDocument(new FinanceInvoice(35, DateTime.Today, 22222, 43));
            reg.AddDocument(new FinanceInvoice(52321, DateTime.Today, 33333, 55631));

            Console.WriteLine(reg.GetInfo(DateTime.Today));

            Console.WriteLine(reg.GetInfo(123));
        }
    }
}