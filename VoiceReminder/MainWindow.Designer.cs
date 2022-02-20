namespace VoiceReminder
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
            this.chooseDateTime = new System.Windows.Forms.Label();
            this.playVoice = new System.Windows.Forms.Button();
            this.deleteVoice = new System.Windows.Forms.Button();
            this.chooseName = new System.Windows.Forms.Label();
            this.doRecord = new System.Windows.Forms.Label();
            this.createReminder = new System.Windows.Forms.Button();
            this.showReminders = new System.Windows.Forms.Button();
            this.recordIcon = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.даТыЗаебалСтопБлятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daysCount = new System.Windows.Forms.TextBox();
            this.hoursCount = new System.Windows.Forms.TextBox();
            this.whenNotify = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker.Location = new System.Drawing.Point(7, 58);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timePicker.Location = new System.Drawing.Point(228, 58);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(57, 20);
            this.timePicker.TabIndex = 1;
            // 
            // recordVoice
            // 
            this.recordVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordVoice.Location = new System.Drawing.Point(308, 64);
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
            this.reminderName.Location = new System.Drawing.Point(7, 119);
            this.reminderName.Name = "reminderName";
            this.reminderName.Size = new System.Drawing.Size(258, 29);
            this.reminderName.TabIndex = 3;
            // 
            // chooseDateTime
            // 
            this.chooseDateTime.AutoSize = true;
            this.chooseDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateTime.Location = new System.Drawing.Point(7, 30);
            this.chooseDateTime.Name = "chooseDateTime";
            this.chooseDateTime.Size = new System.Drawing.Size(258, 21);
            this.chooseDateTime.TabIndex = 5;
            this.chooseDateTime.Text = "Оберіть дату і час нагадування";
            // 
            // playVoice
            // 
            this.playVoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playVoice.Location = new System.Drawing.Point(471, 64);
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
            this.deleteVoice.Location = new System.Drawing.Point(390, 101);
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
            this.chooseName.Location = new System.Drawing.Point(7, 95);
            this.chooseName.Name = "chooseName";
            this.chooseName.Size = new System.Drawing.Size(224, 21);
            this.chooseName.TabIndex = 8;
            this.chooseName.Text = "Укажіть назву нагадування";
            // 
            // doRecord
            // 
            this.doRecord.AutoSize = true;
            this.doRecord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doRecord.Location = new System.Drawing.Point(335, 30);
            this.doRecord.Name = "doRecord";
            this.doRecord.Size = new System.Drawing.Size(277, 21);
            this.doRecord.TabIndex = 10;
            this.doRecord.Text = "Запишіть голосове повідомлення";
            // 
            // createReminder
            // 
            this.createReminder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReminder.Location = new System.Drawing.Point(65, 154);
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
            this.showReminders.Location = new System.Drawing.Point(390, 154);
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
            this.recordIcon.Location = new System.Drawing.Point(441, 67);
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
            this.showApplication,
            this.exitApplication});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // showApplication
            // 
            this.showApplication.Name = "showApplication";
            this.showApplication.Size = new System.Drawing.Size(125, 22);
            this.showApplication.Text = "Показати";
            this.showApplication.Click += new System.EventHandler(this.showApplication_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(125, 22);
            this.exitApplication.Text = "Вихід";
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewStrip
            // 
            this.viewStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLanguageStrip});
            this.viewStrip.Name = "viewStrip";
            this.viewStrip.Size = new System.Drawing.Size(39, 20);
            this.viewStrip.Text = "Вид";
            // 
            // changeLanguageStrip
            // 
            this.changeLanguageStrip.Name = "changeLanguageStrip";
            this.changeLanguageStrip.Size = new System.Drawing.Size(150, 22);
            this.changeLanguageStrip.Text = "Змінити мову";
            this.changeLanguageStrip.Click += new System.EventHandler(this.changeLanguageStrip_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.даТыЗаебалСтопБлятьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 26);
            // 
            // даТыЗаебалСтопБлятьToolStripMenuItem
            // 
            this.даТыЗаебалСтопБлятьToolStripMenuItem.Name = "даТыЗаебалСтопБлятьToolStripMenuItem";
            this.даТыЗаебалСтопБлятьToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.даТыЗаебалСтопБлятьToolStripMenuItem.Text = "Да ты заебал, стоп блять";
            // 
            // daysCount
            // 
            this.daysCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysCount.Location = new System.Drawing.Point(12, 255);
            this.daysCount.Name = "daysCount";
            this.daysCount.Size = new System.Drawing.Size(64, 29);
            this.daysCount.TabIndex = 15;
            // 
            // hoursCount
            // 
            this.hoursCount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursCount.Location = new System.Drawing.Point(143, 255);
            this.hoursCount.Name = "hoursCount";
            this.hoursCount.Size = new System.Drawing.Size(64, 29);
            this.hoursCount.TabIndex = 16;
            // 
            // whenNotify
            // 
            this.whenNotify.AutoSize = true;
            this.whenNotify.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whenNotify.Location = new System.Drawing.Point(8, 231);
            this.whenNotify.Name = "whenNotify";
            this.whenNotify.Size = new System.Drawing.Size(258, 21);
            this.whenNotify.TabIndex = 17;
            this.whenNotify.Text = "Оберіть дату і час нагадування";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.days.Location = new System.Drawing.Point(12, 289);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(19, 21);
            this.days.TabIndex = 18;
            this.days.Text = "1";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hours.Location = new System.Drawing.Point(139, 289);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(19, 21);
            this.hours.TabIndex = 19;
            this.hours.Text = "2";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.createReminder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 319);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.days);
            this.Controls.Add(this.whenNotify);
            this.Controls.Add(this.hoursCount);
            this.Controls.Add(this.daysCount);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.showReminders);
            this.Controls.Add(this.recordIcon);
            this.Controls.Add(this.createReminder);
            this.Controls.Add(this.doRecord);
            this.Controls.Add(this.chooseName);
            this.Controls.Add(this.deleteVoice);
            this.Controls.Add(this.playVoice);
            this.Controls.Add(this.chooseDateTime);
            this.Controls.Add(this.reminderName);
            this.Controls.Add(this.recordVoice);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoiceReminder";
            ((System.ComponentModel.ISupportInitialize)(this.recordIcon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label chooseDateTime;
        private System.Windows.Forms.Button playVoice;
        private System.Windows.Forms.Button deleteVoice;
        private System.Windows.Forms.Label chooseName;
        private System.Windows.Forms.Label doRecord;
        private System.Windows.Forms.Button createReminder;
        private System.Windows.Forms.PictureBox recordIcon;
        private System.Windows.Forms.Button showReminders;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplication;
        private System.Windows.Forms.ToolStripMenuItem exitApplication;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewStrip;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem даТыЗаебалСтопБлятьToolStripMenuItem;
        private System.Windows.Forms.TextBox daysCount;
        private System.Windows.Forms.TextBox hoursCount;
        private System.Windows.Forms.Label whenNotify;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label hours;
    }
}

