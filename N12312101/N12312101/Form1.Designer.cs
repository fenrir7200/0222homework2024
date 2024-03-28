namespace N12312101
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbmi = new System.Windows.Forms.Button();
            this.btm = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "多遊2甲";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(196, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "N12312101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(409, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "邱新雅";
            // 
            // btnbmi
            // 
            this.btnbmi.Location = new System.Drawing.Point(177, 215);
            this.btnbmi.Name = "btnbmi";
            this.btnbmi.Size = new System.Drawing.Size(75, 23);
            this.btnbmi.TabIndex = 3;
            this.btnbmi.Text = "bmi";
            this.btnbmi.UseVisualStyleBackColor = true;
            // 
            // btm
            // 
            this.btm.Location = new System.Drawing.Point(177, 308);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(75, 23);
            this.btm.TabIndex = 4;
            this.btm.Text = "按鈕";
            this.btm.UseVisualStyleBackColor = true;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // btnTextBox
            // 
            this.btnTextBox.Location = new System.Drawing.Point(363, 214);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnTextBox.TabIndex = 5;
            this.btnTextBox.Text = "輸入框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.btnbmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbmi;
        private System.Windows.Forms.Button btm;
        private System.Windows.Forms.Button btnTextBox;
    }
}

