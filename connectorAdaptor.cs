using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class connectorAdaptor : plugInterface
    {

        plugInterface plug;
        public connectorAdaptor(plugInterface plug)
        {

            this.plug = plug;

        }
        public string getType()
        {

            return plug.getType();
        }

        public string charge()
        {

            return plug.charge();
        }

    }
}
