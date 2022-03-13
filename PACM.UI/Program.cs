using PACM.BL;

namespace PACM.UI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer = new Customer();

            CustomerRepository repository = new CustomerRepository();


            customer = repository.RetrieveDB(1);
            Console.WriteLine(customer.FirstName);

            customer = repository.RetrieveDB(2);
            Console.WriteLine(customer.FirstName);
            customer = repository.RetrieveDB(1);
            Console.WriteLine(customer.FullName);
            //ask fpr a product
            ProductRepository repo = new ProductRepository();

            Product product = new Product();

            product = repo.RetrieveDB(1);
            Console.WriteLine(product.ProductName + "\n" + product.ProductDescription);
            Console.WriteLine(product.DateCreated);

            //ask for all orders
            //OrderRepository repo2 = new OrderRepository();
            //Order order = new Order();
            //Console.WriteLine(repo2.RetrieveAllOrders(); 


            
            
        }
    }
}