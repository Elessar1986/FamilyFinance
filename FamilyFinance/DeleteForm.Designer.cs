namespace FamilyFinance
{
    partial class DeleteForm
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
            this.comboBox_fm = new System.Windows.Forms.ComboBox();
            this.button_del_ok = new System.Windows.Forms.Button();
            this.button_del_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_fm
            // 
            this.comboBox_fm.FormattingEnabled = true;
            this.comboBox_fm.Location = new System.Drawing.Point(12, 12);
            this.comboBox_fm.Name = "comboBox_fm";
            this.comboBox_fm.Size = new System.Drawing.Size(244, 21);
            this.comboBox_fm.TabIndex = 0;
            // 
            // button_del_ok
            // 
            this.button_del_ok.Location = new System.Drawing.Point(181, 46);
            this.button_del_ok.Name = "button_del_ok";
            this.button_del_ok.Size = new System.Drawing.Size(75, 23);
            this.button_del_ok.TabIndex = 1;
            this.button_del_ok.Text = "Удалить";
            this.button_del_ok.UseVisualStyleBackColor = true;
            this.button_del_ok.Click += new System.EventHandler(this.button_del_ok_Click);
            // 
            // button_del_cancel
            // 
            this.button_del_cancel.Location = new System.Drawing.Point(100, 46);
            this.button_del_cancel.Name = "button_del_cancel";
            this.button_del_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_del_cancel.TabIndex = 1;
            this.button_del_cancel.Text = "Отмена";
            this.button_del_cancel.UseVisualStyleBackColor = true;
            this.button_del_cancel.Click += new System.EventHandler(this.button_del_cancel_Click);
            // 
            // DeleteFamilyMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 76);
            this.Controls.Add(this.button_del_cancel);
            this.Controls.Add(this.button_del_ok);
            this.Controls.Add(this.comboBox_fm);
            this.Name = "DeleteFamilyMember";
            this.Text = "Удалить члена семьи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_fm;
        private System.Windows.Forms.Button button_del_ok;
        private System.Windows.Forms.Button button_del_cancel;
    }
}