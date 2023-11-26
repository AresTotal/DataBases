using System;
using System.Data.Entity;

namespace DataBases
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnectionString")
        {

        }

        public DbSet<CryptoToken> CryptoTokens { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
    }
}
