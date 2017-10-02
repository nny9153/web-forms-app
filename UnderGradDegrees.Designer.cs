namespace Project3
{
    partial class UnderGradDegrees
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
            this.lbl_undergradtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_undergradtitle
            // 
            this.lbl_undergradtitle.AutoSize = true;
            this.lbl_undergradtitle.Location = new System.Drawing.Point(153, 31);
            this.lbl_undergradtitle.Name = "lbl_undergradtitle";
            this.lbl_undergradtitle.Size = new System.Drawing.Size(23, 13);
            this.lbl_undergradtitle.TabIndex = 0;
            this.lbl_undergradtitle.Text = "title";
            // 
            // UnderGradDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 404);
            this.Controls.Add(this.lbl_undergradtitle);
            this.Name = "UnderGradDegrees";
            this.Text = "UnderGradDegrees";
            this.Load += new System.EventHandler(this.UnderGradDegrees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_undergradtitle;
    }
}