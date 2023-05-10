using CodeFirstApproach.Models;

namespace CodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Perform CRUD operations
             ProductDbContext db = new ProductDbContext();
            Product product = new Product()
            { Name = "Printer", Qty = 10, Description = "Printer Desx" };
            db.Products.Add(product);
            db.SaveChanges();

            List<Product> products = db.Products.ToList();
            Console.WriteLine(products.Count);

            foreach (var prod in products) {
                if(prod.Id== 1) { }
                db.Products.Remove(prod);
                db.SaveChanges();
            } 




        }
    }
}