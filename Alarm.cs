/* Author: Max Maus
 * Alarm.cs
 * 8/30/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    /// <summary>
    /// The Alarm class stores the data for a single alarm, based on the user's input.
    /// </summary>
    public class Alarm
    {
        /// <summary>
        /// A property representing the hour at which the alarm triggers.
        /// </summary>
        private int hours;
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }
        private int minutes;
        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                minutes = value;
            }
        }
        private int seconds;
        public int Seconds
        {
            get
            {
                return seconds;
            }

            set
            {
                seconds = value;
            }
        }

        /// <summary>
        /// The time formatted in HH:mm:ss format
        /// </summary>
        public string FormattedTime
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if(pm == true)
                {
                    sb.Append((hours + 12).ToString());
                }
                else if(hours < 9)
                {
                    sb.Append("0" + hours.ToString());
                }
                else
                {
                    sb.Append(hours.ToString());
                }
                sb.Append(":");

                if (minutes < 9)
                {
                    sb.Append("0" + minutes.ToString());
                }
                else
                {
                    sb.Append(minutes.ToString());
                }
                sb.Append(":");

                if (seconds < 9)
                {
                    sb.Append("0" + seconds.ToString());
                }
                else
                {
                    sb.Append(seconds.ToString());
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// A boolean representing whether the alarm is set to trigger in AM (false) or PM (true)
        /// </summary>
        private bool pm;

        public bool Pm
        {
            get
            {
                return pm;
            }
            set
            {
                pm = value;
            }
        }

        /// <summary>
        /// A boolean representing whether the alarm is on or off. This defaults to on because my phone alarms are,
        /// and that seemed like an alright reason.
        /// </summary>
        private bool active = true;
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(hours.ToString());
            sb.Append(":"); 
            sb.Append(minutes.ToString());
            if(pm == true)
            {
                sb.Append(" PM");
            }
            else
            {
                sb.Append(" AM");
            }
            if (active == true)
            {
                sb.Append("   On");
            }
            else
            {
                sb.Append("   Off");
            }
            return sb.ToString();
        }
    }
}
