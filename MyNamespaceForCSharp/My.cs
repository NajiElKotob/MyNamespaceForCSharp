using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class My
    {
    static ComputerInfo computerInfo = new Microsoft.VisualBasic.Devices.ComputerInfo();

    public static class Computer
    {
        public static class Info
        {
            public static ulong AvailablePhysicalMemory { get { return computerInfo.AvailablePhysicalMemory; } }
            
        }
    }
    

}

