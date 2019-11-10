using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationHW5.DataAccess
{
    public class WallInitializer : CreateDatabaseIfNotExists<RecordContext>
    {
        protected override void Seed(RecordContext context)
        {
            context.Wall.Add(new Models.Record
            {
                Nickname = "FirstMan",
                Text = "It's my first record) I'm first!!!"
            });
        }
    }
}