using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Threading;

namespace ConsoleApp1
{
    //public class Product
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Category { get; set; }
    //    public decimal Price { get; set; }
    //}

        public class EMPController:ApiController
    {
        private readonly DBTask_Reposit rep;
        public EMPController()
        {
            rep = new DBTask_Reposit();
        }

        public async Task<IEnumerable<t_Emp>> Get()
        {

            return await rep.GetT_Emps();


        }
    }
    public class DepController : ApiController
    {
        private readonly DBTask_Reposit rep;
        public DepController()

        {
            rep = new DBTask_Reposit();
        }
        public async Task<IEnumerable<t_Department>> Get()
        {

            return await rep.GetT_Departments();


        }
    }
        public class DBTaskController : ApiController
    {

        private readonly DBTask_Reposit rep;
        public DBTaskController()
        {
            rep = new DBTask_Reposit();
        }

        public async Task<IEnumerable<TaskTable>> Get()
        {
            return await rep.GetData();
        }


    }
    //public class ProductsController : ApiController
    //{
    //    Timer timer;

    //    static List<Product> productsList = new List<Product>();
    //    int i = 1;
    //    void Timerup(object value)
    //    {
    //        productsList.Add(new Product { Id = 1, Name = "Tomato Soup", Category = DateTime.Now.ToString(), Price = i++ });
    //    }
    //    void start_timer()
    //    {
    //        timer = new Timer(new TimerCallback(Timerup), null, Timeout.Infinite, 1000);
    //    }

    //    public IEnumerable<List<Product>> GetAllProducts()
    //    {

    //        productsList.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
    //        productsList.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
    //        productsList.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
    //        yield return productsList;
    //    }

    //    public Product GetProductById(int id)
    //    {
    //        productsList.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
    //        productsList.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
    //        productsList.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });

    //        return productsList[id];
    //    }

        //public List<Product> GetProductsByCategory(string category)
        //{
        //    start_timer();
        //    timer.Change(0, 1000);
        //    Console.WriteLine("timer start");
        //    productsList.Add(new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 });
        //    productsList.Add(new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M });
        //    productsList.Add(new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });

        //    List<Product> res = productsList.Where(s => s.Category == category).ToList();
        //    return res;

        //    //return products.Where(p => string.Equals(p.Category, category,
        //    //        StringComparison.OrdinalIgnoreCase));
        //}
    
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
          
        

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }

        }
    }
}
