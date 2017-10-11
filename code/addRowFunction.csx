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
    
    Functionsdb db = new Functionsdb(connString);

    SalesLT_Address address = new SalesLT_Address{
        AddressLine1 = "Cl 92 #11 51",
        City = "Bogota",
        StateProvince = "Bogota D.C.",
        CountryRegion = "Colombia",
        PostalCode = "110111",
        Rowguid = Guid.NewGuid(),
        ModifiedDate = DateTime.Now
    };

    try
    {
        db.SalesLT_Address.InsertOnSubmit(address);
        db.SubmitChanges();
        log.Info($"Your have successfully inserted a new row to your table.");
    }
    catch
    {
        log.Info($"Something went wrong. Please try again.");
    } 
    
}