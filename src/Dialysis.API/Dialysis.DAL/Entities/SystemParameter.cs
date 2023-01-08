using System;
namespace Dialysis.DAL.Entities
{
    public class SystemParameter
    {
        public int DiastolicPressureThreshold { get; set; }
        public int SystolicPressureThreshold { get; set; }
        public double TurbidityUpperLimit { get; set; }
        public double TurbidityLowerLimit { get; set; }
    }
}

