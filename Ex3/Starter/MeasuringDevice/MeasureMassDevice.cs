using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviceControl;

namespace MeasuringDevice
{
    public class MeasureMassDevice :  MeasureDataDevice, IMeasuringDevice
    {
        public MeasureMassDevice(Units deviceUnits)
        {
            unitsToUse = deviceUnits;
            measurementType = DeviceType.MASS;
        }

        public override decimal ImperialValue()
        {
            decimal imperialMostRecentMeasure;
            if (unitsToUse == Units.Imperial)
            {
                imperialMostRecentMeasure = Convert.ToDecimal(mostRecentMeasure);
            }
            else
            {
                // Metric measurements are in kilograms.
                // Multiply metric measurement by 2.2046 to convert from
                // kilograms to pounds.
                // Convert from an integer value to a decimal.
                decimal decimalMetricValue = Convert.ToDecimal(mostRecentMeasure);
                decimal conversionFactor = 2.2046M;
                imperialMostRecentMeasure = decimalMetricValue * conversionFactor;
            }
            return imperialMostRecentMeasure;
        }

        public override decimal MetricValue()
        {
            decimal metricMostRecentMeasure;
            if (unitsToUse == Units.Metric)
            {
                metricMostRecentMeasure = Convert.ToDecimal(mostRecentMeasure);
            }
            else
            {
                // Imperial measurements are in pounds.
                // Multiply imperial measurement by 0.4536 to convert from
                // pounds to kilograms.
                // Convert from an integer value to a decimal.
                decimal decimalImperialValue = Convert.ToDecimal(mostRecentMeasure);
                decimal conversionFactor = 0.4536M;
                metricMostRecentMeasure = decimalImperialValue * conversionFactor;
            }
            return metricMostRecentMeasure;
        }
    }
}
