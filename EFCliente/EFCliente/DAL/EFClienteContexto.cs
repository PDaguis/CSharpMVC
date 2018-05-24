using EFCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EFCliente.DAL
{
    public class EFClienteContexto : DbContext
    {
        public EFClienteContexto() : base("ClienteConnectionString") { }

        //SERVE PARA REMOVER O PLURAL NA HORA DE CRIAR AS TABELAS
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}