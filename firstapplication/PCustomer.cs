using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class PCustomer
    {
        int _Custid;
        bool _Status;
        string _CName, _Pradesh;
        double _Balance;
        Cities _City;//enum is used named cities.cs

        public PCustomer(int Custid, bool Status, string CName, double Balance, Cities City, string Pradesh, string Country)
        {
            _Custid = Custid;
            _Status = Status;
            _CName = CName;
            _Balance = Balance;
            _City = City;//enum is used
            _Pradesh = Pradesh;
            this.Country = Country;
        }
        public int Custid
        {
            get { return _Custid; }
            set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string CName
        {
            get { return _CName; }
            set
            {
                if (_Status == true)
                    _CName = value;
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)
                        _Balance = value;
                }
            }
        }

        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                    _City = value;//enum is used
            }
        }
        public string Pradesh
        {
            get { return _Pradesh; }
            set
            {
                if (Status == true)
                {
                    _Pradesh = value;
                }
            }
        }
        public string Country // Auto-implemented or automatic property.
        {
            get;
            set;
        } = "Nepal";//Auto-property iniializer. Only can be used when there is no extra condition or statement present in get and set accessor.

        
    }
}

