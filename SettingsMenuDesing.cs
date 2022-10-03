
namespace _3x_1UI
{
    partial class SettingsMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.lightThemeBtn = new System.Windows.Forms.Button();
            this.darkThemeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Theme";
            // 
            // lightThemeBtn
            // 
            this.lightThemeBtn.Location = new System.Drawing.Point(16, 48);
            this.lightThemeBtn.Name = "lightThemeBtn";
            this.lightThemeBtn.Size = new System.Drawing.Size(75, 23);
            this.lightThemeBtn.TabIndex = 5;
            this.lightThemeBtn.Text = "Light Theme";
            this.lightThemeBtn.UseVisualStyleBackColor = true;
            this.lightThemeBtn.Click += new System.EventHandler(this.lightThemeBtn_Click);
            // 
            // darkThemeBtn
            // 
            this.darkThemeBtn.Location = new System.Drawing.Point(16, 86);
            this.darkThemeBtn.Name = "darkThemeBtn";
            this.darkThemeBtn.Size = new System.Drawing.Size(75, 23);
            this.darkThemeBtn.TabIndex = 6;
            this.darkThemeBtn.Text = "Dark Theme";
            this.darkThemeBtn.UseVisualStyleBackColor = true;
            this.darkThemeBtn.Click += new System.EventHandler(this.darkThemeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(178, 61);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 204);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.darkThemeBtn);
            this.Controls.Add(this.lightThemeBtn);
            this.Controls.Add(this.label2);
            this.Name = "SettingsMenu";
            this.Text = "SettingsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lightThemeBtn;
        private System.Windows.Forms.Button darkThemeBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}
