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
            this.button0321 = new System.Windows.Forms.Button();
            this.label0321 = new System.Windows.Forms.Label();
            this.labcount = new System.Windows.Forms.Label();
            this.btncount = new System.Windows.Forms.Button();
            this.labcount1 = new System.Windows.Forms.Label();
            this.btncount1 = new System.Windows.Forms.Button();
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
            // button0321
            // 
            this.button0321.Location = new System.Drawing.Point(149, 240);
            this.button0321.Name = "button0321";
            this.button0321.Size = new System.Drawing.Size(75, 23);
            this.button0321.TabIndex = 1;
            this.button0321.Text = "button0321";
            this.button0321.UseVisualStyleBackColor = true;
            this.button0321.Click += new System.EventHandler(this.button0321_Click);
            // 
            // label0321
            // 
            this.label0321.AutoSize = true;
            this.label0321.Location = new System.Drawing.Point(172, 172);
            this.label0321.Name = "label0321";
            this.label0321.Size = new System.Drawing.Size(51, 12);
            this.label0321.TabIndex = 2;
            this.label0321.Text = "label0321";
            // 
            // labcount
            // 
            this.labcount.AutoSize = true;
            this.labcount.Location = new System.Drawing.Point(601, 184);
            this.labcount.Name = "labcount";
            this.labcount.Size = new System.Drawing.Size(11, 12);
            this.labcount.TabIndex = 4;
            this.labcount.Text = "0";
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(578, 252);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 3;
            this.btncount.Text = "加一";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // labcount1
            // 
            this.labcount1.AutoSize = true;
            this.labcount1.Location = new System.Drawing.Point(386, 180);
            this.labcount1.Name = "labcount1";
            this.labcount1.Size = new System.Drawing.Size(23, 12);
            this.labcount1.TabIndex = 6;
            this.labcount1.Text = "100";
            // 
            // btncount1
            // 
            this.btncount1.Location = new System.Drawing.Point(363, 248);
            this.btncount1.Name = "btncount1";
            this.btncount1.Size = new System.Drawing.Size(75, 23);
            this.btncount1.TabIndex = 5;
            this.btncount1.Text = "減一";
            this.btncount1.UseVisualStyleBackColor = true;
            this.btncount1.Click += new System.EventHandler(this.btncount1_Click);
            // 
            // Formbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labcount1);
            this.Controls.Add(this.btncount1);
            this.Controls.Add(this.labcount);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.label0321);
            this.Controls.Add(this.button0321);
            this.Controls.Add(this.buttonclick);
            this.Name = "Formbutton";
            this.Text = "按鈕教學";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclick;
        private System.Windows.Forms.Button button0321;
        private System.Windows.Forms.Label label0321;
        private System.Windows.Forms.Label labcount;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Label labcount1;
        private System.Windows.Forms.Button btncount1;
    }
}