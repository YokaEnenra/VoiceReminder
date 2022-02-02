namespace VoiceReminder
{
    partial class LanguageChooseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageChooseWindow));
            this.languagesBox = new System.Windows.Forms.ComboBox();
            this.chooseLanguageLabel = new System.Windows.Forms.Label();
            this.choiceOk = new System.Windows.Forms.Button();
            this.choiseCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languagesBox
            // 
            this.languagesBox.FormattingEnabled = true;
            this.languagesBox.Location = new System.Drawing.Point(16, 47);
            this.languagesBox.Name = "languagesBox";
            this.languagesBox.Size = new System.Drawing.Size(206, 21);
            this.languagesBox.TabIndex = 0;
            // 
            // chooseLanguageLabel
            // 
            this.chooseLanguageLabel.AutoSize = true;
            this.chooseLanguageLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLanguageLabel.Location = new System.Drawing.Point(12, 9);
            this.chooseLanguageLabel.Name = "chooseLanguageLabel";
            this.chooseLanguageLabel.Size = new System.Drawing.Size(210, 21);
            this.chooseLanguageLabel.TabIndex = 1;
            this.chooseLanguageLabel.Text = "Choose preferred language";
            // 
            // choiceOk
            // 
            this.choiceOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiceOk.Location = new System.Drawing.Point(16, 94);
            this.choiceOk.Name = "choiceOk";
            this.choiceOk.Size = new System.Drawing.Size(90, 40);
            this.choiceOk.TabIndex = 2;
            this.choiceOk.Text = "Ok";
            this.choiceOk.UseVisualStyleBackColor = true;
            this.choiceOk.Click += new System.EventHandler(this.choiceOk_Click);
            // 
            // choiseCancel
            // 
            this.choiseCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.choiseCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiseCancel.Location = new System.Drawing.Point(132, 94);
            this.choiseCancel.Name = "choiseCancel";
            this.choiseCancel.Size = new System.Drawing.Size(90, 40);
            this.choiseCancel.TabIndex = 3;
            this.choiseCancel.Text = "Cancel";
            this.choiseCancel.UseVisualStyleBackColor = true;
            this.choiseCancel.Click += new System.EventHandler(this.choiseCancel_Click);
            // 
            // LanguageChooseWindow
            // 
            this.AcceptButton = this.choiceOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.choiseCancel;
            this.ClientSize = new System.Drawing.Size(237, 146);
            this.Controls.Add(this.choiseCancel);
            this.Controls.Add(this.choiceOk);
            this.Controls.Add(this.chooseLanguageLabel);
            this.Controls.Add(this.languagesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LanguageChooseWindow";
            this.Text = "VoiceReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languagesBox;
        private System.Windows.Forms.Label chooseLanguageLabel;
        private System.Windows.Forms.Button choiceOk;
        private System.Windows.Forms.Button choiseCancel;
    }
}