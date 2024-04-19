using Examen.ApplicationCore.Domain;
using Examen.Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen.Infra
{
    public class Context : DbContext
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Personne> Personnes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                                        @"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=LocationMecherguiEyatDB;
                                        Integrated Security=true"
                                    );
            base.OnConfiguring(optionsBuilder);

        }

        //appel des classe de config FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new LocataireConfiguration());




        }


    }

}
