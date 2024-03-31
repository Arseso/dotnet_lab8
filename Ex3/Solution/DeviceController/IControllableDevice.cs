using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceControl
{
    interface IControllableDevice
    {
        void StartDevice();
        void StopDevice();
        int GetLatestMeasure();
    }
}
