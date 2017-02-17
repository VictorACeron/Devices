using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class redColor : Decorator
    {
        public redColor(phoneInterface phone) : base(phone)
        {

            this.name = "Red Phone";
            this.cost = 5;
        }
    }
}
