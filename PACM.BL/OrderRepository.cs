using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PACM.BL
{
    public class OrderRepository
    {
        

        string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=pacm3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //vis all ordrer
        //public Order RetrieveAllOrders()
        //{
        //    Order order = new Order(); //skal laves til en liste
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
               
        //        string query = $"select * from order";
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        reader.Read(); 
        //        customer.FirstName = reader["firstname"].ToString();
        //        customer.LastName = reader["lastname"].ToString();
                
        //        connection.Close();
        //            }
        //     return order;
        //}
        public Order Retrieve()
        {
            //get customer
            //get address
            //get orderitem 
        }
        public bool Save(Order order)
        {
            //Code that saves the defined product
            return true;
        }
    }
}
