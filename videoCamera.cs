using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
   abstract  class videoCamera : photoInterface, videoInterface
    {
        protected int megaPixels;

        public string record()
        {
            return "video" + megaPixels + "MP";
        }

        public string photograph()
        {
            return "picture " + megaPixels + "MP";
        }
    }
}
