namespace N12312101
{
    partial class Formbutton
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
            this.buttonclick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonclick
            // 
            this.buttonclick.Location = new System.Drawing.Point(398, 56);
            this.buttonclick.Name = "buttonclick";
            this.buttonclick.Size = new System.Drawing.Size(175, 59);
            this.buttonclick.TabIndex = 0;
            this.buttonclick.Text = "按我";
            this.buttonclick.UseVisualStyleBackColor = true;
            this.buttonclick.Click += new System.EventHandler(this.buttonclick_Click);
            // 
            // Formbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonclick);
            this.Name = "Formbutton";
            this.Text = "按鈕教學";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonclick;
    }
}