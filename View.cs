using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class View : Form
    {
        /// <summary>
        /// References the controller, which we will generate upon startup.
        /// </summary>
        Controller controller;
        public View()
        {
            InitializeComponent();
        }

        public void setController(Controller c)
        {
            this.controller = c;
            //uXAlarmContainer.DataSource = c.Alarms;
        }

        private void uXAddButton_Click(object sender, EventArgs e)
        {
            if (controller.Size < 10)
            {
                TimeSelectionWindow ts = new TimeSelectionWindow(uXAlarmContainer, controller);
                ts.Show();
            }            
        }

        private void uXSleepButton_Click(object sender, EventArgs e)
        {
            controller.UpdateState(AlarmStates.Off);
        }

        private void uXStopButton_Click(object sender, EventArgs e)
        {
            controller.UpdateState(AlarmStates.Off);
        }

        private void uXEditButton_Click(object sender, EventArgs e)
        {
           if(uXAlarmContainer.SelectedIndex != -1)
           {
                TimeSelectionWindow ts = new TimeSelectionWindow(uXAlarmContainer, uXAlarmContainer.SelectedIndex, controller);
                ts.Show();
            }
        }

        /// <summary>
        /// Updates the text box based on the current state
        /// </summary>
        /// <param name="s">The current state of the alarm clock</param>
        public void UpdateTextBox(AlarmStates s)
        {
            switch (s)
            {
                case AlarmStates.Off:
                {
                        uXStatusBox.Text = "Alarm stopped";
                        uXStopButton.Enabled = false;
                        uXSleepButton.Enabled = false;
                        break;
                }
                case AlarmStates.Running:
                {
                        uXStatusBox.Text = "Alarm activated";
                        uXStopButton.Enabled = true;
                        uXSleepButton.Enabled = false;
                        break;
                    }
                case AlarmStates.Snoozing:
                {
                        uXStatusBox.Text = "Snoozing for 30 seconds";
                        uXStopButton.Enabled = true;
                        uXSleepButton.Enabled = false;
                        break;
                }
                case AlarmStates.Beeping:
                {
                    uXStatusBox.Text = "Alarm went off";
                        uXStopButton.Enabled = true;
                        uXSleepButton.Enabled = true;
                        break;
                }
            }
        }
    }
}
