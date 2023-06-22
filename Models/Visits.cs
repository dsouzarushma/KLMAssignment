using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace KLMAssignment.Models
{
    public class VisitsTemp
    {
       [Index(0)]
       public string? LegId { get; set; }
        [Index(1)]
        public string? AirlineCode { get; set; }
        [Index(2)]
        public string? AircraftRegistration { get; set; }
        [Index(3)]
        public string? FlightNumber { get; set; }
        [Index(4)]
        public string? Suffix { get; set; }
        [Index(5)]
        public string? DepartureStation { get; set; }
        [Index(6)]
        public string? ArrivalStation { get; set; }
        [Index(7)]
        public string? STDDate { get; set; }
        [Index(8)]
        public string? STDTime { get; set; }
        [Index(9)]
        public string? ATDDate { get; set; }
        [Index(10)]
        public string? ATDTime { get; set; }
        [Index(11)]
        public string? STDDateLocal { get; set; }
        [Index(12)]
        public string? STDTimeLocal { get; set; }
        [Index(13)]
        public string? ATDDateLocal { get; set; }
        [Index(14)]
        public string? ATDTimeLocal { get; set; }
        [Index(15)]
        public string? STADate { get; set; }
        [Index(16)]
        public string? STATime { get; set; }
        [Index(17)]
        public string? ATADate { get; set; }
        [Index(18)]
        public string? ATATime { get; set; }
        [Index(19)]
        public string? STADateLocal { get; set; }
        [Index(20)]
        public string? STATimeLocal { get; set; }
        [Index(21)]
        public string? ATADateLocal { get; set; }
        [Index(22)]
        public string? ATATimeLocal { get; set; }

    }
}
