using PaymentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentData.Repository
{
    public interface ITransactions
    {
        void Create(Transactions transactions);
        void Delete(int id);
        void Update(Transactions transactions);
        Transactions Get(int id);
        List<Transactions> GetAll();
    }
}
