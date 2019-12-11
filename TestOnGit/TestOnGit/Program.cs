using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add("PapaID", typeof(int));
            newDataTable.Columns.Add("ID", typeof(int));
            newDataTable.Columns.Add("Name", typeof(string));

            DataRow dr = newDataTable.NewRow();
            dr[0] = 0;
            dr[1] = 0;
            dr[2] = "--All--";
            newDataTable.Rows.Add(dr);

            for (int i = 1; i < 3; i++)
            {
                DataRow dr1 = newDataTable.NewRow();
                dr1[0] = i;
                dr1[1] = i;
                dr1[2] = i + " Val";
                newDataTable.Rows.Add(dr1);
            }

            var query = from r in newDataTable.AsEnumerable()
                        where r.Field<int>("PapaID") == 0 //|| r.Field<string>("Name") == "bar"
                        let objectArray = new object[]
                        {
                r.Field<string>("c_to"), r.Field<string>("p_to")
                        }
                        select objectArray;

            //List<Order> orders = new List<Order> {
            //new Order(31),
            //new Order(32),
            //new Order(33),
            //new Order(34)};

            //List<Payment> payments = new List<Payment>  {
            //new Payment(1, 30),
            //new Payment(2, 31),
            //new Payment(3, 32),
            //new Payment(4, 33),
            //new Payment(5, 34),
            //new Payment(6, 35)};

            //var qry = from o in orders
            //          join p in payments on o.OrderId equals p.OrderId
            //          select new { o.OrderId, p.PaymentId };

            //foreach (var op in qry)
            //{
            //    Console.WriteLine("OrderId={0}; PaymentId={1}", op.OrderId, op.PaymentId);
            //}

        }
    }
}
