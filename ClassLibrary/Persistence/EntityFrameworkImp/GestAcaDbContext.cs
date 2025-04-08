using System;
using System.Data.Entity;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using GestAca.Entities;

namespace GestAca.Persistence
{
    public class GestAcaDbContext : DbContextISW
    {
        public GestAcaDbContext() : base("Name=GestAcaDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static GestAcaDbContext()
        {
            //Database.SetInitializer<BikeClubDbContext>(new CreateDatabaseIfNotExists<BikeClubDbContext>());
            Database.SetInitializer<GestAcaDbContext>(new DropCreateDatabaseIfModelChanges<GestAcaDbContext>());
            //Database.SetInitializer<BikeClubDbContext>(new DropCreateDatabaseAlways<BikeClubDbContext>());
            //Database.SetInitializer<BikeClubDbContext>(new BikeClubDbContextInitializer());
            //Database.SetInitializer(new NullDatabaseInitializer<BikeClubDbContext>());
        }

        // DbSets for persistent classes in your case study
        // To Do:


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Con fluentAPI evita el problema de borrado en cascada por el Required en la propiedad Owner de Content

        }

        // Generic method to clear all the data (except some relations if needed)
         public override void RemoveAllData()
        {
            clearSomeRelationships();

            base.RemoveAllData(); 
        }

        // Sometimes it is needed to clear some relationships explicitly 
        private void clearSomeRelationships()
        {
//            SaveChanges();
        }


    }

}
