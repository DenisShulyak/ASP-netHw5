namespace WebApplicationHW5.DataAccess
{
    using System.Data.Entity;
    using WebApplicationHW5.Models;

    public class RecordContext : DbContext
    {
        
        public RecordContext()
            : base("name=RecordContext")
        {
            Database.SetInitializer(new WallInitializer());
        }

        public DbSet<Record> Wall { get; set; }
    }

}