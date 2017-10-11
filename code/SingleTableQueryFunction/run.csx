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

    IQueryable<SalesLT_Product> results = from product in products where product.Color == "Black" select product;

    int count =1; 
    foreach (SalesLT_Product item in results)
    {
        log.Info($"{count}-{item.Name}");
        count++;
    }
    log.Info($"{results.Count()} products");
}