using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CustomerProperty
    {
        int _Custid;
        bool _Status;
        string _Cname;
        double _Balance;
        public CustomerProperty(int Custid,bool Status, string Cname, double Balance)
        {
            _Custid = Custid; 
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
        }
        public int Custid { 
            get { return _Custid; } 
            set{ _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set { 
                if (_Status==true)
                    _Cname = value; 
                }
        }
        public double Balance
        {
            get { return _Balance; }
            set {
                if (_Status == true)
                {if (value >=500)
                    _Balance = value;
                }
                }
        }
    }
}
