using Microsoft.EntityFrameworkCore;
using PaymentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentData.Data
{
    public class PaymentDbContext:DbContext //database
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { }
        public DbSet<Transactions> transactions { get; set; }  //table
    }
}
