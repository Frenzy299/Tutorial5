using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    public enum Mode { Conference, Journal, Other};
    class TrainingSession
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public DateTime Certified { get; set; }
        public Mode Mode { get; set; }

        public int Freshness
        {
            get
            {
                return Convert.ToInt32(
                  (DateTime.Today.Subtract(Certified).TotalDays)
              );
            }
        }

        public override string ToString()
        {
            return Title + " in " + Year + " " + Certified + " completed by " + Mode;
        }

        
    }
}
