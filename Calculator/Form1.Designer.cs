
namespace assinment1Calculator
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.by = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(12, 20);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(60, 15);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "Number 1";
            this.num1Label.UseWaitCursor = true;
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(12, 53);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(56, 15);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "Nunber 2";
            this.num2Label.UseWaitCursor = true;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(78, 17);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 23);
            this.num1.TabIndex = 2;
            this.num1.UseWaitCursor = true;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(78, 49);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(90, 23);
            this.num2.TabIndex = 3;
            this.num2.UseWaitCursor = true;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(12, 92);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 52);
            this.sum.TabIndex = 4;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.UseWaitCursor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // by
            // 
            this.by.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.by.Location = new System.Drawing.Point(93, 92);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(75, 52);
            this.by.TabIndex = 5;
            this.by.Text = "×";
            this.by.UseVisualStyleBackColor = true;
            this.by.UseWaitCursor = true;
            this.by.Click += new System.EventHandler(this.by_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub.Location = new System.Drawing.Point(12, 150);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 58);
            this.sub.TabIndex = 6;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.UseWaitCursor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(93, 150);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 58);
            this.div.TabIndex = 7;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.UseWaitCursor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "By : AbdelHady Saeed";
            this.label1.UseWaitCursor = true;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.by);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Name = "calculator";
            this.Text = "Calculator";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button by;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label label1;
    }
}

