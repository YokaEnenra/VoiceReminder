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
            this.reminderName = new System.Windows.Forms.TextBox();
            this.playVoice = new System.Windows.Forms.Button();
            this.previousReminder = new System.Windows.Forms.Button();
            this.nextReminder = new System.Windows.Forms.Button();
            this.postponeReminder = new System.Windows.Forms.Button();
            this.reminderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deleteReminder
            // 
            this.deleteReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteReminder.Location = new System.Drawing.Point(103, 189);
            this.deleteReminder.Name = "deleteReminder";
            this.deleteReminder.Size = new System.Drawing.Size(127, 62);
            this.deleteReminder.TabIndex = 16;
            this.deleteReminder.Text = "Видалити нагадування";
            this.deleteReminder.UseVisualStyleBackColor = true;
            this.deleteReminder.Click += new System.EventHandler(this.deleteReminder_Click);
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
            this.playVoice.Location = new System.Drawing.Point(103, 84);
            this.playVoice.Name = "playVoice";
            this.playVoice.Size = new System.Drawing.Size(127, 31);
            this.playVoice.TabIndex = 17;
            this.playVoice.Text = "Прослухати";
            this.playVoice.UseVisualStyleBackColor = true;
            this.playVoice.Click += new System.EventHandler(this.playVoice_Click);
            // 
            // previousReminder
            // 
            this.previousReminder.BackgroundImage = global::VoiceReminder.Properties.Resources.LeftArrow;
            this.previousReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previousReminder.Location = new System.Drawing.Point(12, 155);
            this.previousReminder.Name = "previousReminder";
            this.previousReminder.Size = new System.Drawing.Size(53, 30);
            this.previousReminder.TabIndex = 19;
            this.previousReminder.UseVisualStyleBackColor = true;
            this.previousReminder.Click += new System.EventHandler(this.previousReminder_Click);
            // 
            // nextReminder
            // 
            this.nextReminder.BackgroundImage = global::VoiceReminder.Properties.Resources.RightArrow;
            this.nextReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextReminder.Location = new System.Drawing.Point(273, 155);
            this.nextReminder.Name = "nextReminder";
            this.nextReminder.Size = new System.Drawing.Size(53, 30);
            this.nextReminder.TabIndex = 18;
            this.nextReminder.UseVisualStyleBackColor = true;
            this.nextReminder.Click += new System.EventHandler(this.nextReminder_Click);
            // 
            // postponeReminder
            // 
            this.postponeReminder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.postponeReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postponeReminder.Location = new System.Drawing.Point(103, 121);
            this.postponeReminder.Name = "postponeReminder";
            this.postponeReminder.Size = new System.Drawing.Size(127, 62);
            this.postponeReminder.TabIndex = 20;
            this.postponeReminder.Text = "Відкласти нагадування";
            this.postponeReminder.UseVisualStyleBackColor = true;
            this.postponeReminder.Click += new System.EventHandler(this.postponeReminder_Click);
            // 
            // reminderText
            // 
            this.reminderText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderText.Location = new System.Drawing.Point(12, 47);
            this.reminderText.Name = "reminderText";
            this.reminderText.Size = new System.Drawing.Size(314, 29);
            this.reminderText.TabIndex = 21;
            // 
            // ShowReminders
            // 
            this.AcceptButton = this.playVoice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.reminderText);
            this.Controls.Add(this.postponeReminder);
            this.Controls.Add(this.previousReminder);
            this.Controls.Add(this.nextReminder);
            this.Controls.Add(this.playVoice);
            this.Controls.Add(this.deleteReminder);
            this.Controls.Add(this.reminderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoiceReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteReminder;
        private System.Windows.Forms.TextBox reminderName;
        private System.Windows.Forms.Button playVoice;
        private System.Windows.Forms.Button nextReminder;
        private System.Windows.Forms.Button previousReminder;
        private System.Windows.Forms.Button postponeReminder;
        private System.Windows.Forms.TextBox reminderText;
    }
}