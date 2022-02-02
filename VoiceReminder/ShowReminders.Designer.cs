namespace VoiceReminder
{
    partial class ShowReminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowReminders));
            this.deleteReminder = new System.Windows.Forms.Button();
            this.reminderText = new System.Windows.Forms.RichTextBox();
            this.reminderName = new System.Windows.Forms.TextBox();
            this.playVoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nextReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteReminder
            // 
            this.deleteReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteReminder.Location = new System.Drawing.Point(103, 188);
            this.deleteReminder.Name = "deleteReminder";
            this.deleteReminder.Size = new System.Drawing.Size(127, 62);
            this.deleteReminder.TabIndex = 16;
            this.deleteReminder.Text = "Видалити нагадування";
            this.deleteReminder.UseVisualStyleBackColor = true;
            this.deleteReminder.Click += new System.EventHandler(this.deleteReminder_Click);
            // 
            // reminderText
            // 
            this.reminderText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderText.Location = new System.Drawing.Point(12, 47);
            this.reminderText.Name = "reminderText";
            this.reminderText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.reminderText.Size = new System.Drawing.Size(314, 96);
            this.reminderText.TabIndex = 13;
            this.reminderText.Text = "";
            // 
            // reminderName
            // 
            this.reminderName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderName.Location = new System.Drawing.Point(37, 12);
            this.reminderName.Name = "reminderName";
            this.reminderName.Size = new System.Drawing.Size(258, 29);
            this.reminderName.TabIndex = 12;
            // 
            // playVoice
            // 
            this.playVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playVoice.Location = new System.Drawing.Point(103, 149);
            this.playVoice.Name = "playVoice";
            this.playVoice.Size = new System.Drawing.Size(127, 31);
            this.playVoice.TabIndex = 17;
            this.playVoice.Text = "Прослухати";
            this.playVoice.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::VoiceReminder.Properties.Resources.LeftArrow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nextReminder
            // 
            this.nextReminder.BackgroundImage = global::VoiceReminder.Properties.Resources.RightArrow;
            this.nextReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextReminder.Location = new System.Drawing.Point(273, 220);
            this.nextReminder.Name = "nextReminder";
            this.nextReminder.Size = new System.Drawing.Size(53, 30);
            this.nextReminder.TabIndex = 18;
            this.nextReminder.UseVisualStyleBackColor = true;
            // 
            // ShowReminders
            // 
            this.AcceptButton = this.playVoice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextReminder);
            this.Controls.Add(this.playVoice);
            this.Controls.Add(this.deleteReminder);
            this.Controls.Add(this.reminderText);
            this.Controls.Add(this.reminderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowReminders";
            this.Text = "VoiceReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteReminder;
        private System.Windows.Forms.RichTextBox reminderText;
        private System.Windows.Forms.TextBox reminderName;
        private System.Windows.Forms.Button playVoice;
        private System.Windows.Forms.Button nextReminder;
        private System.Windows.Forms.Button button1;
    }
}