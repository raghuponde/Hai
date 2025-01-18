
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{


    class Customer
    {
        private int _Id;
        private string _CustomerName;
        public int ID
        {
            set
            {
                _Id = value;
            }
            get
            {
                return _Id;
            }
        }

        public string CustomerName1
        {
            set
            {
                _CustomerName = value;
            }
            get
            {
                return _CustomerName;
            }
        }


    }
     class Program
    {
        static void Main(string[] args)
        {
            Customer  cobj = new Customer();
            cobj.ID = 101;
            cobj.CustomerName1 = "ravi";
            Console.WriteLine($"{cobj.CustomerName1} {cobj.ID}");
            Console.ReadLine();
            
        }
    }
}

