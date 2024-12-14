using System.Windows.Forms;
using System;

namespace Singleton_1262774
{
    partial class Form1
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
            this.btnMortgageApproval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMortgageApproval
            // 
            this.btnMortgageApproval.Location = new System.Drawing.Point(213, 167);
            this.btnMortgageApproval.Name = "btnMortgageApproval";
            this.btnMortgageApproval.Size = new System.Drawing.Size(199, 23);
            this.btnMortgageApproval.TabIndex = 0;
            this.btnMortgageApproval.Text = "btnMortgageApproval";
            this.btnMortgageApproval.UseVisualStyleBackColor = true;
            this.btnMortgageApproval.Click += new System.EventHandler(this.btnMortgageApproval_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMortgageApproval);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private Button btnMortgageApproval;
    }
}

