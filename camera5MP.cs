using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class camera5MP : photoCamera
    {
        public camera5MP()
        {
            megaPixels = 5;

        }


        float getPixels()
        {

            return megaPixels;
        }
    }
}
