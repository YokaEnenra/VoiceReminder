﻿namespace VoiceReminder
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.recordVoice = new System.Windows.Forms.Button();
            this.reminderName = new System.Windows.Forms.TextBox();
            this.reminderText = new System.Windows.Forms.RichTextBox();
            this.chooseDateTime = new System.Windows.Forms.Label();
            this.playVoice = new System.Windows.Forms.Button();
            this.deleteVoice = new System.Windows.Forms.Button();
            this.chooseName = new System.Windows.Forms.Label();
            this.writeTopic = new System.Windows.Forms.Label();
            this.doRecord = new System.Windows.Forms.Label();
            this.createReminder = new System.Windows.Forms.Button();
            this.showReminders = new System.Windows.Forms.Button();
            this.recordIcon = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиМовуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(7, 95);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker.Location = new System.Drawing.Point(228, 95);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(57, 20);
            this.timePicker.TabIndex = 1;
            // 
            // recordVoice
            // 
            this.recordVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordVoice.Location = new System.Drawing.Point(308, 101);
            this.recordVoice.Name = "recordVoice";
            this.recordVoice.Size = new System.Drawing.Size(127, 31);
            this.recordVoice.TabIndex = 2;
            this.recordVoice.Text = "Записати";
            this.recordVoice.UseVisualStyleBackColor = true;
            this.recordVoice.Click += new System.EventHandler(this.RecordVoice_Click);
            // 
            // reminderName
            // 
            this.reminderName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderName.Location = new System.Drawing.Point(7, 156);
            this.reminderName.Name = "reminderName";
            this.reminderName.Size = new System.Drawing.Size(258, 29);
            this.reminderName.TabIndex = 3;
            // 
            // reminderText
            // 
            this.reminderText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reminderText.Location = new System.Drawing.Point(7, 219);
            this.reminderText.Name = "reminderText";
            this.reminderText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.reminderText.Size = new System.Drawing.Size(314, 96);
            this.reminderText.TabIndex = 4;
            this.reminderText.Text = "";
            // 
            // chooseDateTime
            // 
            this.chooseDateTime.AutoSize = true;
            this.chooseDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateTime.Location = new System.Drawing.Point(7, 67);
            this.chooseDateTime.Name = "chooseDateTime";
            this.chooseDateTime.Size = new System.Drawing.Size(258, 21);
            this.chooseDateTime.TabIndex = 5;
            this.chooseDateTime.Text = "Оберіть дату і час нагадування";
            // 
            // playVoice
            // 
            this.playVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playVoice.Location = new System.Drawing.Point(471, 101);
            this.playVoice.Name = "playVoice";
            this.playVoice.Size = new System.Drawing.Size(127, 31);
            this.playVoice.TabIndex = 6;
            this.playVoice.Text = "Прослухати";
            this.playVoice.UseVisualStyleBackColor = true;
            this.playVoice.Click += new System.EventHandler(this.PlayVoice_Click);
            // 
            // deleteVoice
            // 
            this.deleteVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVoice.Location = new System.Drawing.Point(390, 138);
            this.deleteVoice.Name = "deleteVoice";
            this.deleteVoice.Size = new System.Drawing.Size(127, 31);
            this.deleteVoice.TabIndex = 7;
            this.deleteVoice.Text = "Видалити";
            this.deleteVoice.UseVisualStyleBackColor = true;
            this.deleteVoice.Click += new System.EventHandler(this.DeleteVoice_Click);
            // 
            // chooseName
            // 
            this.chooseName.AutoSize = true;
            this.chooseName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseName.Location = new System.Drawing.Point(7, 132);
            this.chooseName.Name = "chooseName";
            this.chooseName.Size = new System.Drawing.Size(224, 21);
            this.chooseName.TabIndex = 8;
            this.chooseName.Text = "Укажіть назву нагадування";
            // 
            // writeTopic
            // 
            this.writeTopic.AutoSize = true;
            this.writeTopic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeTopic.Location = new System.Drawing.Point(7, 188);
            this.writeTopic.Name = "writeTopic";
            this.writeTopic.Size = new System.Drawing.Size(314, 21);
            this.writeTopic.TabIndex = 9;
            this.writeTopic.Text = "Запишіть короткий текст нагадування";
            // 
            // doRecord
            // 
            this.doRecord.AutoSize = true;
            this.doRecord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doRecord.Location = new System.Drawing.Point(335, 67);
            this.doRecord.Name = "doRecord";
            this.doRecord.Size = new System.Drawing.Size(277, 21);
            this.doRecord.TabIndex = 10;
            this.doRecord.Text = "Запишіть голосове повідомлення";
            // 
            // createReminder
            // 
            this.createReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReminder.Location = new System.Drawing.Point(390, 188);
            this.createReminder.Name = "createReminder";
            this.createReminder.Size = new System.Drawing.Size(127, 62);
            this.createReminder.TabIndex = 11;
            this.createReminder.Text = "Створити нагадування";
            this.createReminder.UseVisualStyleBackColor = true;
            this.createReminder.Click += new System.EventHandler(this.CreateReminder_Click);
            // 
            // showReminders
            // 
            this.showReminders.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showReminders.Location = new System.Drawing.Point(390, 256);
            this.showReminders.Name = "showReminders";
            this.showReminders.Size = new System.Drawing.Size(127, 62);
            this.showReminders.TabIndex = 13;
            this.showReminders.Text = "Переглянути нагадування";
            this.showReminders.UseVisualStyleBackColor = true;
            this.showReminders.Click += new System.EventHandler(this.ShowReminders_Click);
            // 
            // recordIcon
            // 
            this.recordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recordIcon.Image = global::VoiceReminder.Properties.Resources.Record;
            this.recordIcon.InitialImage = null;
            this.recordIcon.Location = new System.Drawing.Point(441, 104);
            this.recordIcon.Name = "recordIcon";
            this.recordIcon.Size = new System.Drawing.Size(24, 24);
            this.recordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recordIcon.TabIndex = 12;
            this.recordIcon.TabStop = false;
            this.recordIcon.WaitOnLoad = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "VoiceReminder";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // показатиToolStripMenuItem
            // 
            this.показатиToolStripMenuItem.Name = "показатиToolStripMenuItem";
            this.показатиToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.показатиToolStripMenuItem.Text = "Показати";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 26);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиМовуToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // змінитиМовуToolStripMenuItem
            // 
            this.змінитиМовуToolStripMenuItem.Name = "змінитиМовуToolStripMenuItem";
            this.змінитиМовуToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.змінитиМовуToolStripMenuItem.Text = "Змінити мову";
            this.змінитиМовуToolStripMenuItem.Click += new System.EventHandler(this.змінитиМовуToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.createReminder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 333);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.showReminders);
            this.Controls.Add(this.recordIcon);
            this.Controls.Add(this.createReminder);
            this.Controls.Add(this.doRecord);
            this.Controls.Add(this.writeTopic);
            this.Controls.Add(this.chooseName);
            this.Controls.Add(this.deleteVoice);
            this.Controls.Add(this.playVoice);
            this.Controls.Add(this.chooseDateTime);
            this.Controls.Add(this.reminderText);
            this.Controls.Add(this.reminderName);
            this.Controls.Add(this.recordVoice);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoiceReminder";
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NotifyIcon1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button recordVoice;
        private System.Windows.Forms.TextBox reminderName;
        private System.Windows.Forms.RichTextBox reminderText;
        private System.Windows.Forms.Label chooseDateTime;
        private System.Windows.Forms.Button playVoice;
        private System.Windows.Forms.Button deleteVoice;
        private System.Windows.Forms.Label chooseName;
        private System.Windows.Forms.Label writeTopic;
        private System.Windows.Forms.Label doRecord;
        private System.Windows.Forms.Button createReminder;
        private System.Windows.Forms.PictureBox recordIcon;
        private System.Windows.Forms.Button showReminders;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиМовуToolStripMenuItem;
    }
}

