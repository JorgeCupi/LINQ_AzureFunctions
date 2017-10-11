#r "System.Data.Linq"
#r "System.Data"
#r "System.Configuration"
#load "mappedClasses.cs"

using System.Configuration;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;


public static void Run(string input, TraceWriter log)
{
    string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
    
    DataContext db = new DataContext(connString);
    Table<SalesLT_Product> products = db.GetTable<SalesLT_Product>();

    IQueryable<SimpleProduct> results = 
    from product 
    in products 
    where (product.Color == "Black") 
    && (product.SalesLT_ProductCategory.Name == "Mountain Frames")
    select new SimpleProduct
    {
        name = product.Name,
        color = product.Color,
        category = product.SalesLT_ProductCategory.Name
    };

    int count =1; 
    foreach (SimpleProduct item in results)
    {
        log.Info($"{count} - {item.name} - {item.color} - {item.category}");
        count++;
    }
    log.Info($"{results.Count()} products");
}

public class SimpleProduct
{
    public string name{get;set;}
    public string color{get;set;}
    public string category{get;set;}
}