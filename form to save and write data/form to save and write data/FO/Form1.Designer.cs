
namespace FO
{
    partial class Form1
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
            this.Fname = new System.Windows.Forms.Label();
            this.FnameValue = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btDisplay = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Fname.ForeColor = System.Drawing.Color.PeachPuff;
            this.Fname.Location = new System.Drawing.Point(27, 28);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(145, 37);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "File Name";
            // 
            // FnameValue
            // 
            this.FnameValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FnameValue.Location = new System.Drawing.Point(178, 26);
            this.FnameValue.Name = "FnameValue";
            this.FnameValue.Size = new System.Drawing.Size(272, 39);
            this.FnameValue.TabIndex = 1;
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.Tan;
            this.btCreate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCreate.ForeColor = System.Drawing.Color.Black;
            this.btCreate.Location = new System.Drawing.Point(39, 98);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(133, 47);
            this.btCreate.TabIndex = 2;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Tan;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.Location = new System.Drawing.Point(178, 98);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(133, 47);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btDisplay
            // 
            this.btDisplay.BackColor = System.Drawing.Color.Tan;
            this.btDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDisplay.ForeColor = System.Drawing.Color.Black;
            this.btDisplay.Location = new System.Drawing.Point(178, 161);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(133, 47);
            this.btDisplay.TabIndex = 4;
            this.btDisplay.Text = "Display";
            this.btDisplay.UseVisualStyleBackColor = false;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.Tan;
            this.btInsert.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInsert.ForeColor = System.Drawing.Color.Black;
            this.btInsert.Location = new System.Drawing.Point(39, 161);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(133, 47);
            this.btInsert.TabIndex = 5;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Tan;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(317, 161);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(133, 47);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Tan;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(317, 98);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(133, 47);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(489, 247);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.FnameValue);
            this.Controls.Add(this.Fname);
            this.Name = "Form1";
            this.Text = "File Organization App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox FnameValue;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSearch;
    }
}

