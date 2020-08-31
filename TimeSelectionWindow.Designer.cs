namespace Alarm501
{
    partial class TimeSelectionWindow
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
            this.uXSetButton = new System.Windows.Forms.Button();
            this.uXCancelButton = new System.Windows.Forms.Button();
            this.uXOnButton = new System.Windows.Forms.RadioButton();
            this.uXTimeSelector = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uXSetButton
            // 
            this.uXSetButton.Location = new System.Drawing.Point(213, 86);
            this.uXSetButton.Name = "uXSetButton";
            this.uXSetButton.Size = new System.Drawing.Size(75, 23);
            this.uXSetButton.TabIndex = 0;
            this.uXSetButton.Text = "Set";
            this.uXSetButton.UseVisualStyleBackColor = true;
            this.uXSetButton.Click += new System.EventHandler(this.uXSetButton_Click);
            // 
            // uXCancelButton
            // 
            this.uXCancelButton.Location = new System.Drawing.Point(31, 86);
            this.uXCancelButton.Name = "uXCancelButton";
            this.uXCancelButton.Size = new System.Drawing.Size(75, 23);
            this.uXCancelButton.TabIndex = 1;
            this.uXCancelButton.Text = "Cancel";
            this.uXCancelButton.UseVisualStyleBackColor = true;
            this.uXCancelButton.Click += new System.EventHandler(this.uXCancelButton_Click);
            // 
            // uXOnButton
            // 
            this.uXOnButton.AutoSize = true;
            this.uXOnButton.Location = new System.Drawing.Point(249, 38);
            this.uXOnButton.Name = "uXOnButton";
            this.uXOnButton.Size = new System.Drawing.Size(39, 17);
            this.uXOnButton.TabIndex = 2;
            this.uXOnButton.Text = "On";
            this.uXOnButton.UseVisualStyleBackColor = true;
            // 
            // uXTimeSelector
            // 
            this.uXTimeSelector.CustomFormat = "";
            this.uXTimeSelector.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uXTimeSelector.Location = new System.Drawing.Point(31, 38);
            this.uXTimeSelector.Name = "uXTimeSelector";
            this.uXTimeSelector.Size = new System.Drawing.Size(200, 20);
            this.uXTimeSelector.TabIndex = 3;
            this.uXTimeSelector.Value = new System.DateTime(2020, 8, 30, 23, 13, 53, 0);
            // 
            // TimeSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 137);
            this.Controls.Add(this.uXTimeSelector);
            this.Controls.Add(this.uXOnButton);
            this.Controls.Add(this.uXCancelButton);
            this.Controls.Add(this.uXSetButton);
            this.Name = "TimeSelectionWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uXSetButton;
        private System.Windows.Forms.Button uXCancelButton;
        private System.Windows.Forms.RadioButton uXOnButton;
        private System.Windows.Forms.DateTimePicker uXTimeSelector;
    }
}