using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class USAplug : plugInterface
    {
   
        string type = "USA";

    public  string getType()
        {

            return type;
        }
     public  string charge()
        {
            return "Charging" + type;
        }
    }
}
