/* Author: Max Maus
 * Controller.cs
 * 8/30/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Alarm501
{
    /// <summary>
    /// This class handles much of the backend code for the program, including state changes, timers, and various other things
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// This array of Alarms will store each alarm entered by the user. Maximum size is 10 because the app is supposed
        /// to manage at most 10 alarms at a time.
        /// </summary>
        public List<Alarm> Alarms = new List<Alarm>();

        /// <summary>
        /// An enum representing the current state of the clock, defaults to off.
        /// </summary>
        public AlarmStates state = AlarmStates.Off;

        private int snoozeTime;
        /// <summary>
        /// An integer which denotes the number of alarms created so far.
        /// </summary>
        public int Size
        {
            get
            {
                return Alarms.Count;
            }
        }

        /// <summary>
        /// References the View object through which the user interaction occurs
        /// </summary>
        private View view;

        private System.Timers.Timer timer;

        // Just a divider to help separate the methods and constructor from the properties

        /// <summary>
        /// Initializes the controller, setting its view as well as starting the timer.
        /// </summary>
        /// <param name="v"></param>
        public Controller(View v)
        {
            view = v;
            timer = CreateTimer();
            timer.Elapsed += SecondsTimer_Elapsed;
        }

        /// <summary>
        /// This method edits the contents of the Alarm Box to be up to date with the Alarms list. We
        /// do this by iterating through every alarm currently in the database and printing it into the box.
        /// </summary>
        /// <param name="listBox">The ListBox to edit</param>
        public void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            while(listBox.Items.Count < Alarms.Count) // We create additional text boxes until there are as many boxes as alarms
            {
                TextBox tb = new TextBox();
                tb.Width = listBox.Width;
                listBox.Items.Add(tb);
            }
            
            for (int i = 0; i < Alarms.Count; i++)
            {
                if(listBox.Items[i] is TextBox)
                {
                    listBox.Items[i] = Alarms[i].ToString();
                }
                
            }           
            
        }


        /// <summary>
        /// Changes the program's state from the current one to the input, if possible.
        /// </summary>
        /// <param name="s">A state to move to</param>
        public void UpdateState(AlarmStates s)
        {
            switch (state)
            {
                case AlarmStates.Off: // If the alarm is off, it can begin running
                    if (s == AlarmStates.Running)
                    {
                        state = AlarmStates.Running;
                    }
                    break;
                case AlarmStates.Running: // If the alarm is running, it can go off, and nothing else
                    if(s == AlarmStates.Beeping)
                    {
                        state = AlarmStates.Beeping;
                    }
                    break;
                case AlarmStates.Beeping: // If the alarm is currently going off, it can be snoozed, or cleared
                    if(s == AlarmStates.Snoozing)
                    {
                        state = AlarmStates.Snoozing;
                        snoozeTime = 30;
                    }
                    else if (s == AlarmStates.Off)
                    {
                        state = AlarmStates.Off;
                    }
                    break;
                default: // If the alarm is running, it can go off, or be turned off.
                    if(s == AlarmStates.Off)
                    {
                        state = AlarmStates.Off;
                    } else if (s == AlarmStates.Beeping)
                    {
                        state = AlarmStates.Beeping;
                    }
                    break;

            }
            view.UpdateTextBox(s);
        }



        /// <summary>
        /// Creates a timer for the alarm clock to run on
        /// </summary>
        private System.Timers.Timer CreateTimer()
        {
            System.Timers.Timer secondsTimer = new System.Timers.Timer(1000);            
            secondsTimer.AutoReset = true;
            secondsTimer.Enabled = true;
            return secondsTimer;
        }

        private void SecondsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(state == AlarmStates.Running)
            {

                string now = DateTime.Now.ToString("HH:mm:ss");
                foreach (Alarm a in Alarms)
                {
                    StringBuilder sb = new StringBuilder();
                    if (a.Active && now.Equals(a.FormattedTime))
                    {
                        UpdateState(AlarmStates.Beeping);
                        view.UpdateTextBox(AlarmStates.Beeping);
                    }
              
                }
            }

            else if (state == AlarmStates.Snoozing)
            {
                snoozeTime -= 1;
                if(snoozeTime <= 0)
                {
                    UpdateState(AlarmStates.Beeping);
                }
            }
        }
    }
}
