
namespace GamertagSearcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.GamertagInput = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Gamertag without quotes and click search to check the Gamertag in your " +
    "default browser";
            // 
            // GamertagInput
            // 
            this.GamertagInput.Location = new System.Drawing.Point(12, 63);
            this.GamertagInput.Name = "GamertagInput";
            this.GamertagInput.Size = new System.Drawing.Size(249, 23);
            this.GamertagInput.TabIndex = 1;
            this.GamertagInput.TextChanged += new System.EventHandler(this.GamertagInput_TextChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(186, 92);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 120);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.GamertagInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Search Gamertag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GamertagInput;
        private System.Windows.Forms.Button Search;
    }
}

