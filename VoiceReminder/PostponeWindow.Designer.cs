namespace VoiceReminder
{
    partial class PostponeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostponeWindow));
            this.chooseDateTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.postponeReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseDateTime
            // 
            this.chooseDateTime.AutoSize = true;
            this.chooseDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateTime.Location = new System.Drawing.Point(12, 9);
            this.chooseDateTime.Name = "chooseDateTime";
            this.chooseDateTime.Size = new System.Drawing.Size(258, 21);
            this.chooseDateTime.TabIndex = 8;
            this.chooseDateTime.Text = "Оберіть дату і час нагадування";
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker.Location = new System.Drawing.Point(233, 37);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(57, 20);
            this.timePicker.TabIndex = 7;
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(12, 37);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 6;
            // 
            // postponeReminder
            // 
            this.postponeReminder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.postponeReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postponeReminder.Location = new System.Drawing.Point(90, 66);
            this.postponeReminder.Name = "postponeReminder";
            this.postponeReminder.Size = new System.Drawing.Size(122, 62);
            this.postponeReminder.TabIndex = 13;
            this.postponeReminder.Text = "Відкласти нагадування";
            this.postponeReminder.UseVisualStyleBackColor = true;
            this.postponeReminder.Click += new System.EventHandler(this.postponeReminder_Click_1);
            // 
            // PostponeWindow
            // 
            this.AcceptButton = this.postponeReminder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 137);
            this.Controls.Add(this.postponeReminder);
            this.Controls.Add(this.chooseDateTime);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostponeWindow";
            this.Text = "VoiceReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseDateTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button postponeReminder;
    }
}