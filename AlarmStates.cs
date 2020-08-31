/* Author: Max Maus
 * AlarmStates.cs
 * 8/30/20
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alarm501
{
    /// <summary>
    /// This is an enum representing the possible states of the clock
    /// </summary>
    public enum AlarmStates
    {
        Off,
        Running,
        Snoozing,
        Beeping
    }
}
