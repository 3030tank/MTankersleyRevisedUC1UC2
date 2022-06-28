namespace MTankersleyRevisedUC1UC2
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
            this.ucb1 = new System.Windows.Forms.Button();
            this.ucb2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucb1
            // 
            this.ucb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ucb1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucb1.Location = new System.Drawing.Point(129, 340);
            this.ucb1.Name = "ucb1";
            this.ucb1.Size = new System.Drawing.Size(162, 51);
            this.ucb1.TabIndex = 0;
            this.ucb1.Text = "Add UC1";
            this.ucb1.UseVisualStyleBackColor = true;
            this.ucb1.Click += new System.EventHandler(this.ucb1_Click);
            // 
            // ucb2
            // 
            this.ucb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ucb2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucb2.Location = new System.Drawing.Point(694, 340);
            this.ucb2.Name = "ucb2";
            this.ucb2.Size = new System.Drawing.Size(162, 51);
            this.ucb2.TabIndex = 1;
            this.ucb2.Text = "Add UC2";
            this.ucb2.UseVisualStyleBackColor = true;
            this.ucb2.Click += new System.EventHandler(this.ucb2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 522);
            this.Controls.Add(this.ucb2);
            this.Controls.Add(this.ucb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ucb2;
        public System.Windows.Forms.Button ucb1;
    }
}
