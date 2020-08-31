using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class TimeSelectionWindow : Form
    {
        /// <summary>
        /// Reference to the parent listBox
        /// </summary>
        private ListBox listBox;


        /// <summary>
        /// References the alarm we are editing
        /// </summary>
        Alarm alarmToEdit;

        bool newAlarm = true;
        Controller controller;
        /// <summary>
        /// This constructor is used if we are editing an existing alarm
        /// </summary>
        /// <param name="lb"></param>
        public TimeSelectionWindow(ListBox lb, int i, Controller c)
        {
            InitializeComponent();
            this.controller = c;
            this.listBox = lb;
            newAlarm = false;
            /*
            if(listBox.DataSource is List<Alarm>)
            {
                alarmToEdit = (listBox.DataSource as List<Alarm>).ElementAt(i);
            }
            */
            alarmToEdit = controller.Alarms[i];
            
        }

        /// <summary>
        /// And this is for if adding a new instance
        /// </summary>
        /// <param name="lb"></param>
        public TimeSelectionWindow(ListBox lb, Controller c)
        {
            InitializeComponent();
            this.controller = c;
            this.listBox = lb;
            alarmToEdit = new Alarm();
            uXTimeSelector.Value = DateTime.Now;
        }



        private void uXCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uXSetButton_Click(object sender, EventArgs e)
        {
            
            if (newAlarm)
            {
                
                controller.Alarms.Add(alarmToEdit);
            }
            
            alarmToEdit.Hours = uXTimeSelector.Value.Hour % 12;
            alarmToEdit.Minutes = uXTimeSelector.Value.Minute;
            alarmToEdit.Seconds = uXTimeSelector.Value.Second;
            if(uXTimeSelector.Value.Hour > 12)
            {
                alarmToEdit.Pm = true;
            }
            else
            {
                alarmToEdit.Pm = false;
            }

            if (uXOnButton.Checked == true)
            { 
                alarmToEdit.Active = true;
                controller.UpdateState(AlarmStates.Running);
            }
            else
            {
                alarmToEdit.Active = false;
            }
            

            controller.UpdateListBox(listBox);
            Close();
        }
    }
}
