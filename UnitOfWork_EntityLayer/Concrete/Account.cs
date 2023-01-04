using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork_EntityLayer.Concrete
{
    public class Account
    {
        public int ID { get; set; }

        //Account Name
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
