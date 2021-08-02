using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //agregar
using OperasWebSite.Data; //agregar
using OperasWebSite.Models; //agregar

namespace OperasWebSite.Inicializer
{
    //se usa para realizar una carga de datos en las tablas cuando creamos la base de datos
    public class OperaDBInitializer: DropCreateDatabaseAlways<OperaDbContext>
    {
        protected override void Seed(OperaDbContext context)
        {
            // base.Seed(context);

            var operas = new List<Opera>()
            {
                new Opera()
                {
                    Title="Cosi Fan Tutte", Year=1790, Composer="Mozart"
                }
            };

            operas.ForEach(s => context.Operas.Add(s));
            context.SaveChanges();
        }
    }
}