using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class videoCamera10MP : videoCamera
    {
        public videoCamera10MP()
        {
            megaPixels = 10;
        }

        float getPixels()
        {

            return megaPixels;
        }
    }
}
