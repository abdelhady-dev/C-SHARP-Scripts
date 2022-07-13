
namespace FO
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.idSearchValue = new System.Windows.Forms.TextBox();
            this.searchDisplay = new System.Windows.Forms.RichTextBox();
            this.btIdSearch = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(25, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter ID : ";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fName.ForeColor = System.Drawing.Color.PeachPuff;
            this.fName.Location = new System.Drawing.Point(170, 19);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(0, 32);
            this.fName.TabIndex = 3;
            // 
            // idSearchValue
            // 
            this.idSearchValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idSearchValue.Location = new System.Drawing.Point(170, 76);
            this.idSearchValue.Name = "idSearchValue";
            this.idSearchValue.Size = new System.Drawing.Size(258, 39);
            this.idSearchValue.TabIndex = 4;
            // 
            // searchDisplay
            // 
            this.searchDisplay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDisplay.Location = new System.Drawing.Point(170, 131);
            this.searchDisplay.Name = "searchDisplay";
            this.searchDisplay.Size = new System.Drawing.Size(258, 186);
            this.searchDisplay.TabIndex = 5;
            this.searchDisplay.Text = "";
            // 
            // btIdSearch
            // 
            this.btIdSearch.BackColor = System.Drawing.Color.Tan;
            this.btIdSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btIdSearch.Location = new System.Drawing.Point(445, 76);
            this.btIdSearch.Name = "btIdSearch";
            this.btIdSearch.Size = new System.Drawing.Size(124, 39);
            this.btIdSearch.TabIndex = 6;
            this.btIdSearch.Text = "Search";
            this.btIdSearch.UseVisualStyleBackColor = false;
            this.btIdSearch.Click += new System.EventHandler(this.btIdSearch_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Tan;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBack.Location = new System.Drawing.Point(445, 131);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(124, 39);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(594, 344);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btIdSearch);
            this.Controls.Add(this.searchDisplay);
            this.Controls.Add(this.idSearchValue);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Search by ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox idSearchValue;
        private System.Windows.Forms.RichTextBox searchDisplay;
        private System.Windows.Forms.Button btIdSearch;
        private System.Windows.Forms.Button btBack;
    }
}