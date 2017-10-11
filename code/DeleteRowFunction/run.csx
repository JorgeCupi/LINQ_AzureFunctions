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

        SalesLT_Address address = (from c in db.SalesLT_Address
                    where c.AddressID == 11389
                    select c).First();

        try
        {
            db.SalesLT_Address.DeleteOnSubmit(address);
            db.SubmitChanges();
            log.Info($"Your have successfully deleted your row.");
        }
        catch
        {
            log.Info($"Something went wrong. Please try again.");
        } 
        
    }