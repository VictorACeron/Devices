using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class Samsung : phoneInterface
    {
        private string phoneName = "Samsung";
        private float phoneCost = 300;
        private videoCamera camera;
        private plugInterface plug;

        public Samsung(plugInterface plugI, videoCamera cameraI)
        {
            this.camera = cameraI;
            this.plug = plugI;
        }

        public string getName()
        {

            return phoneName;
        }

        public  float getCost()
        {

            return phoneCost;

        }
    }
}
