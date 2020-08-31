namespace Alarm501
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uXAddButton = new System.Windows.Forms.Button();
            this.uXSleepButton = new System.Windows.Forms.Button();
            this.uXStopButton = new System.Windows.Forms.Button();
            this.uXEditButton = new System.Windows.Forms.Button();
            this.uXAlarmContainer = new System.Windows.Forms.ListBox();
            this.uXStatusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uXAddButton
            // 
            this.uXAddButton.Location = new System.Drawing.Point(259, 31);
            this.uXAddButton.Name = "uXAddButton";
            this.uXAddButton.Size = new System.Drawing.Size(75, 23);
            this.uXAddButton.TabIndex = 0;
            this.uXAddButton.Text = "+";
            this.uXAddButton.UseVisualStyleBackColor = true;
            this.uXAddButton.Click += new System.EventHandler(this.uXAddButton_Click);
            // 
            // uXSleepButton
            // 
            this.uXSleepButton.Enabled = false;
            this.uXSleepButton.Location = new System.Drawing.Point(70, 358);
            this.uXSleepButton.Name = "uXSleepButton";
            this.uXSleepButton.Size = new System.Drawing.Size(75, 23);
            this.uXSleepButton.TabIndex = 1;
            this.uXSleepButton.Text = "Sleep";
            this.uXSleepButton.UseVisualStyleBackColor = true;
            this.uXSleepButton.Click += new System.EventHandler(this.uXSleepButton_Click);
            // 
            // uXStopButton
            // 
            this.uXStopButton.Enabled = false;
            this.uXStopButton.Location = new System.Drawing.Point(259, 358);
            this.uXStopButton.Name = "uXStopButton";
            this.uXStopButton.Size = new System.Drawing.Size(75, 23);
            this.uXStopButton.TabIndex = 2;
            this.uXStopButton.Text = "Stop";
            this.uXStopButton.UseVisualStyleBackColor = true;
            this.uXStopButton.Click += new System.EventHandler(this.uXStopButton_Click);
            // 
            // uXEditButton
            // 
            this.uXEditButton.Location = new System.Drawing.Point(70, 31);
            this.uXEditButton.Name = "uXEditButton";
            this.uXEditButton.Size = new System.Drawing.Size(75, 23);
            this.uXEditButton.TabIndex = 3;
            this.uXEditButton.Text = "Edit";
            this.uXEditButton.UseVisualStyleBackColor = true;
            this.uXEditButton.Click += new System.EventHandler(this.uXEditButton_Click);
            // 
            // uXAlarmContainer
            // 
            this.uXAlarmContainer.FormattingEnabled = true;
            this.uXAlarmContainer.Location = new System.Drawing.Point(70, 84);
            this.uXAlarmContainer.Name = "uXAlarmContainer";
            this.uXAlarmContainer.ScrollAlwaysVisible = true;
            this.uXAlarmContainer.Size = new System.Drawing.Size(264, 199);
            this.uXAlarmContainer.TabIndex = 4;
            // 
            // uXStatusBox
            // 
            this.uXStatusBox.Location = new System.Drawing.Point(136, 332);
            this.uXStatusBox.Name = "uXStatusBox";
            this.uXStatusBox.Size = new System.Drawing.Size(133, 20);
            this.uXStatusBox.TabIndex = 5;
            this.uXStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // View
            // 
            this.ClientSize = new System.Drawing.Size(422, 413);
            this.Controls.Add(this.uXStatusBox);
            this.Controls.Add(this.uXAlarmContainer);
            this.Controls.Add(this.uXEditButton);
            this.Controls.Add(this.uXStopButton);
            this.Controls.Add(this.uXSleepButton);
            this.Controls.Add(this.uXAddButton);
            this.Name = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uXAddAlarmButton;
        private System.Windows.Forms.Button uXAddButton;
        private System.Windows.Forms.Button uXSleepButton;
        private System.Windows.Forms.Button uXStopButton;
        private System.Windows.Forms.Button uXEditButton;
        private System.Windows.Forms.ListBox uXAlarmContainer;
        private System.Windows.Forms.TextBox uXStatusBox;
    }
}

