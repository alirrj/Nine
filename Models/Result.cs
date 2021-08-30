using Nine_Ali.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nine_Ali.Models
{
    public class Result
    {
        public List<Commercial> CommercialList { get; set; } = new List<Commercial>();
        public int TotalRating { get; set; }
    }
}
