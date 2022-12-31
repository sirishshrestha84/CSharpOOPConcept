using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class PUserReg
    {
        int _Userid;
        bool _Status;
        string _Cname;
        double _Balance;
        Town _City; // Program enum name is UserPradesh.
        public PUserReg(int Userid, bool Status, string Cname,double Balance, Town City)
        {
            _Userid = Userid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
        }
        public int Userid
        {
            get { return _Userid; }
            set
            {
                _Userid = value;
            }
        }
        public bool Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        public string Cname
        {
            get
            {
                return _Cname;
            }
            set
            {if (Status == true)
                _Cname = value;
            }
        }
        public double Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                if (Status == true)
                    if (value >= 500)
                        _Balance = value;
            }
        }
        public Town City
        {
            get
            {
                return _City;
            }
            set
            {
                if (Status == true)
                    _City = value;
            }
        }
        }
}
