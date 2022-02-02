namespace VoiceReminder
{
    partial class RemindWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindWindow));
            this.reminderName = new System.Windows.Forms.Label();
            this.reminderText = new System.Windows.Forms.RichTextBox();
            this.playVoice = new System.Windows.Forms.Button();
            this.postponeReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reminderName
            // 
            this.reminderName.AutoSize = true;
            this.reminderName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderName.Location = new System.Drawing.Point(12, 13);
            this.reminderName.Name = "reminderName";
            this.reminderName.Size = new System.Drawing.Size(53, 21);
            this.reminderName.TabIndex = 0;
            this.reminderName.Text = "label1";
            // 
            // reminderText
            // 
            this.reminderText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderText.Location = new System.Drawing.Point(12, 48);
            this.reminderText.Name = "reminderText";
            this.reminderText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.reminderText.Size = new System.Drawing.Size(314, 96);
            this.reminderText.TabIndex = 5;
            this.reminderText.Text = "";
            // 
            // playVoice
            // 
            this.playVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playVoice.Location = new System.Drawing.Point(16, 150);
            this.playVoice.Name = "playVoice";
            this.playVoice.Size = new System.Drawing.Size(122, 31);
            this.playVoice.TabIndex = 7;
            this.playVoice.Text = "Прослухати";
            this.playVoice.UseVisualStyleBackColor = true;
            // 
            // postponeReminder
            // 
            this.postponeReminder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.postponeReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postponeReminder.Location = new System.Drawing.Point(204, 150);
            this.postponeReminder.Name = "postponeReminder";
            this.postponeReminder.Size = new System.Drawing.Size(122, 62);
            this.postponeReminder.TabIndex = 12;
            this.postponeReminder.Text = "Відкласти нагадування";
            this.postponeReminder.UseVisualStyleBackColor = true;
            this.postponeReminder.Click += new System.EventHandler(this.postponeReminder_Click);
            // 
            // RemindWindow
            // 
            this.AcceptButton = this.playVoice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.postponeReminder;
            this.ClientSize = new System.Drawing.Size(340, 222);
            this.Controls.Add(this.postponeReminder);
            this.Controls.Add(this.playVoice);
            this.Controls.Add(this.reminderText);
            this.Controls.Add(this.reminderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemindWindow";
            this.Text = "VoiceReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reminderName;
        private System.Windows.Forms.RichTextBox reminderText;
        private System.Windows.Forms.Button playVoice;
        private System.Windows.Forms.Button postponeReminder;
    }
}