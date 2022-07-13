
namespace FO
{
    partial class Form3
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
            this.displayField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btDisplay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sFile = new System.Windows.Forms.Label();
            this.noRec = new System.Windows.Forms.Label();
            this.disFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayField
            // 
            this.displayField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayField.Location = new System.Drawing.Point(33, 87);
            this.displayField.Name = "displayField";
            this.displayField.Size = new System.Drawing.Size(425, 262);
            this.displayField.TabIndex = 1;
            this.displayField.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name : ";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Tan;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.Location = new System.Drawing.Point(669, 300);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(118, 49);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btDisplay
            // 
            this.btDisplay.BackColor = System.Drawing.Color.Tan;
            this.btDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDisplay.Location = new System.Drawing.Point(532, 300);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(118, 49);
            this.btDisplay.TabIndex = 4;
            this.btDisplay.Text = "Display";
            this.btDisplay.UseVisualStyleBackColor = false;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(500, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "No, records : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(500, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size : ";
            // 
            // sFile
            // 
            this.sFile.AutoSize = true;
            this.sFile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sFile.ForeColor = System.Drawing.Color.PeachPuff;
            this.sFile.Location = new System.Drawing.Point(675, 195);
            this.sFile.Name = "sFile";
            this.sFile.Size = new System.Drawing.Size(0, 32);
            this.sFile.TabIndex = 8;
            // 
            // noRec
            // 
            this.noRec.AutoSize = true;
            this.noRec.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.noRec.ForeColor = System.Drawing.Color.PeachPuff;
            this.noRec.Location = new System.Drawing.Point(675, 148);
            this.noRec.Name = "noRec";
            this.noRec.Size = new System.Drawing.Size(0, 32);
            this.noRec.TabIndex = 7;
            // 
            // disFileName
            // 
            this.disFileName.AutoSize = true;
            this.disFileName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disFileName.ForeColor = System.Drawing.Color.PeachPuff;
            this.disFileName.Location = new System.Drawing.Point(191, 30);
            this.disFileName.Name = "disFileName";
            this.disFileName.Size = new System.Drawing.Size(0, 32);
            this.disFileName.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(821, 375);
            this.Controls.Add(this.disFileName);
            this.Controls.Add(this.sFile);
            this.Controls.Add(this.noRec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayField);
            this.Name = "Form3";
            this.Text = "Dislplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox displayField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sFile;
        private System.Windows.Forms.Label noRec;
        private System.Windows.Forms.Label disFileName;
    }
}