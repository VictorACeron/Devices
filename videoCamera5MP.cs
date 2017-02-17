using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class videoCamera5MP : videoCamera
    {
        public videoCamera5MP()
        {
            megaPixels = 5;
        }

        float getPixels()
        {

            return megaPixels;
        }
    }
}
