using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    abstract class photoCamera : photoInterface
    {
        public  float megaPixels;
        public string photograph()
        {

            return "picture " + megaPixels + "MP";
        }
    }
}
