using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reflex;

namespace TestReflext
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Header()
            {
                CorporateID = "123123",
                CorporateName="PTPK",
                DebitingAccountNumber="fgdssfdsfds",
                PaymentDate = DateTime.Now,
                FileBatchNo=12312312,
                TotalDebitingAmount=20000
            };

            Console.Write(data.ToString());
            Console.ReadLine();
        }
    }
}
