using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    class IphoneInterface : phoneInterface
    {
      

        private string phoneName = "Iphone";
        private float phoneCost = 500;
        private videoCamera camera;
        private plugInterface plug;

        public IphoneInterface(plugInterface plugI, videoCamera cameraI)
        {
            this.camera = cameraI;
            this.plug = plugI;
        }

        public string getName()
        {

            return phoneName;
        }

        public float getCost()
        {

            return phoneCost;

        }
    }
}
