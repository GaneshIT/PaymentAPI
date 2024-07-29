using PaymentData.Data;
using PaymentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentData.Repository
{
    public class TransactionReposity : ITransactions
    {
        private readonly PaymentDbContext _context;
        public TransactionReposity(PaymentDbContext context)
        {
            _context = context;
        }
        public void Create(Transactions t)
        {
            _context.transactions.Add(t); //it will generate insert statment
            _context.SaveChanges();//it will execute/commit insert statement
        }
        public void Delete(int id)
        {
            var t = _context.transactions.Find(id);//it will generate sql statement with where condition PK
            _context.transactions.Remove(t);
            _context.SaveChanges();

        }
        public Transactions Get(int id)
        {
            var t = _context.transactions.Find(id);
            return t;
        }
        public List<Transactions> GetAll()
        {
            return _context.transactions.ToList();
        }
        public void Update(Transactions t)
        {
            _context.transactions.Update(t);
            _context.SaveChanges();
        }
    }
}
