using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DeviceControl;

namespace Fabrikam.Devices.MeasuringDevices
{
    class LengthMeasuringDevice : IControllableDevice
    {
        Random random;
        public LengthMeasuringDevice()
        {
            random = new Random();
        }

        public void StartDevice()
        {
            // Start the device.           
        }

        public void StopDevice()
        {
            // Stop the device.
        }

        public int GetLatestMeasure()
        {
            return random.Next(1000);
        }
    }
}
