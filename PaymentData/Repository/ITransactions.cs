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
    
    //DI Pattern
    //interface IA
    //{

    //}
    //class Account : IA 
    //{
    //    IA _obj;
    //    public Account(IA obj) 
    //    { 
    //        _obj = obj;
    //    }
    //}
    //class ABCBank : IA { }
    //class XYZBank : IA { }
    //main()
    //{
    //    IA obj1 = new Account(new ABCBank());
    //    IA obj2 = new Account(new XYZBank());
    //}

}
