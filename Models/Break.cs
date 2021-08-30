using Nine_Ali.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nine_Ali.Models
{
    public class Break
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DemographicTypes DemographicTypes { get; set; }
        public int Rating { get; set; }
    }
}
