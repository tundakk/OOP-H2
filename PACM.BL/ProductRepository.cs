using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PACM.BL
{
    public class ProductRepository
    {
        public ProductRepository() { }

        string connectionString = "Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=pacm3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public Product RetrieveDB(int productId)
        {
            Product product = new Product();//instansierer Product Object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM product WHERE productId={productId}"; // productId er argumentet der er indsat
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read(); // tjekker om der er data i reader og return bool hvis der er
                               // det der sker er den "læser 1 linje i et array og sætter markøren klar til at læse
                               // næste linje fra arrayet
                               //customer.firstname = "bo";
                product.ProductName = reader["productName"].ToString();
                product.ProductDescription = reader["productDescription"].ToString();
                product.CurrentPrice = Convert.ToInt32(reader["currentPrice"]);
                product.DateCreated = Convert.ToDateTime(reader["created"]);


                connection.Close();
            }
            return product;

        }
        public bool Save(Product product)
        {
            //Code that saves the defined product
            return true;
        }
    }
    
}
