using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AggregationService.Models
{
    public class DriversDbInitializer : DropCreateDatabaseAlways<DriversContext>
    {
        protected override void Seed(DriversContext db)
        {
            db.Users.Add(new User { Surname = "Иванов", Name = "Иван", Patronymic = "Иванович", Id = 1 });
            db.Users.Add(new User { Surname = "Петров", Name = "Петр", Patronymic = "Петрович", Id = 2 });

            base.Seed(db);
        }
    }
}