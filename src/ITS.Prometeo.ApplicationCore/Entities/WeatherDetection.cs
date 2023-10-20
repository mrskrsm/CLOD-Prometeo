using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Prometeo.ApplicationCore.Entities
{
    internal class WeatherDetection
    {
        public long Id { get; set; }
        public int WeatherStationId { get; set; }
        public byte DetectionType { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

    }
}
