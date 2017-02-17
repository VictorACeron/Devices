using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class Decorator : phoneInterface
    {
        phoneInterface tmp_phone = null;

        protected string name = "undefined";
        protected float cost = 0;


        protected Decorator(phoneInterface phone)
        {

            tmp_phone = phone;
        }


        string phoneInterface.getName()
        {
            return string.Format("{0}, {1}", tmp_phone.getName(), name);
        }

        float phoneInterface.getCost()
        {
            return cost + tmp_phone.getCost();
        }
    }
}
