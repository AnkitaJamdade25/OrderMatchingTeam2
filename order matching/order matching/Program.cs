using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace order_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread slave = new Thread(selectFakeSell);
            slave.Start();
           // List<Orders> fakesellOrders= selectFakeSell();
            List<Orders> fakebuyOrders = selectFakeBuy();
            //foreach(var item in fakesellOrders ) Console.WriteLine(item.ToString());

        }
        public static void selectFakeSell()
        {
            //List<Orders> l = new List<Orders>(); 
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                    @"Data Source= NKS\SQLEXPRESS;Integrated Security=SSPI;" +
                    "Initial Catalog=OrderMatching";
                connection.Open();
                //create a sql command object
                string sql = "Select * from Sell_orders";
                SqlCommand mycommand = new SqlCommand(sql, connection);
                //obtain a data reader a la ExecuteReader().
                SqlDataReader sellReader = mycommand.ExecuteReader();
                
                {

                    //loop over the result
                    while (sellReader.Read())
                    {
                        Orders o = new Orders();
                        
                        o.setId((int)sellReader["sell_id"]);
                        o.setISIN((string)sellReader["isin"]);
                        o.setType((string)sellReader["type"]);
                        o.setDatetime(DateTime.Now);
                        o.setQuantity((int)sellReader["Quantity"]);
                        o.setPrice((float)sellReader["price"]);
                        o.setBrokerage((float)sellReader["Brokerage"]);
                        o.setMin_Quantity((float)sellReader["Min_Quantity"]);
                        Console.WriteLine(o.ToString());
                        Thread.Sleep(1000);

                       // l.Insert(l.Count,o);
                    }
                }


            }
           // return l;
        }

        public static List<Orders> selectFakeBuy()
        {
            List<Orders> l = new List<Orders>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString =
                    @"Data Source= NKS\SQLEXPRESS;Integrated Security=SSPI;" +
                    "Initial Catalog=OrderMatching";
                connection.Open();
                //create a sql command object
                string sql = "Select * from buy_orders";
                SqlCommand mycommand = new SqlCommand(sql, connection);
                //obtain a data reader a la ExecuteReader().
                SqlDataReader buyReader = mycommand.ExecuteReader();

                {
                    //loop over the result
                    while (buyReader.Read())
                    {
                        Orders o = new Orders();

                        o.setId((int)buyReader["buy_id"]);
                        o.setISIN((string)buyReader["isin"]);
                        o.setType((string)buyReader["type"]);
                        o.setDatetime(DateTime.Now);
                        o.setQuantity((int)buyReader["Quantity"]);
                        o.setPrice((float)buyReader["price"]);
                        o.setBrokerage((float)buyReader["Brokerage"]);
                        o.setMin_Quantity((float)buyReader["Min_Quantity"]);

                        l.Insert(l.Count, o);
                    }
                }


            }
            return l;
        }
    }
}
