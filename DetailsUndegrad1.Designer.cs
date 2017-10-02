namespace Project3
{
    partial class DetailsUndegrad1
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
            this.titleUndergrad1 = new System.Windows.Forms.Label();
            this.descriptionUndergrad1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.concentrationsUndergrad1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleUndergrad1
            // 
            this.titleUndergrad1.AutoSize = true;
            this.titleUndergrad1.Location = new System.Drawing.Point(138, 45);
            this.titleUndergrad1.Name = "titleUndergrad1";
            this.titleUndergrad1.Size = new System.Drawing.Size(35, 13);
            this.titleUndergrad1.TabIndex = 0;
            this.titleUndergrad1.Text = "label1";
            // 
            // descriptionUndergrad1
            // 
            this.descriptionUndergrad1.AutoSize = true;
            this.descriptionUndergrad1.Location = new System.Drawing.Point(180, 100);
            this.descriptionUndergrad1.Name = "descriptionUndergrad1";
            this.descriptionUndergrad1.Size = new System.Drawing.Size(35, 13);
            this.descriptionUndergrad1.TabIndex = 1;
            this.descriptionUndergrad1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concentrations:";
            // 
            // concentrationsUndergrad1
            // 
            this.concentrationsUndergrad1.FormattingEnabled = true;
            this.concentrationsUndergrad1.Location = new System.Drawing.Point(204, 148);
            this.concentrationsUndergrad1.Name = "concentrationsUndergrad1";
            this.concentrationsUndergrad1.Size = new System.Drawing.Size(263, 173);
            this.concentrationsUndergrad1.TabIndex = 5;
            // 
            // DetailsUndegrad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 427);
            this.Controls.Add(this.concentrationsUndergrad1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionUndergrad1);
            this.Controls.Add(this.titleUndergrad1);
            this.Name = "DetailsUndegrad1";
            this.Text = "Undergraduate Degree Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleUndergrad1;
        private System.Windows.Forms.Label descriptionUndergrad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox concentrationsUndergrad1;
    }
}