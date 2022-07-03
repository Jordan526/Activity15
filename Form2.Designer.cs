namespace Activity15_1
{
    partial class Form2
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
            this.LuckyNumberLabel = new System.Windows.Forms.Label();
            this.luckyNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LuckyNumberLabel
            // 
            this.LuckyNumberLabel.AutoSize = true;
            this.LuckyNumberLabel.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyNumberLabel.Location = new System.Drawing.Point(54, 60);
            this.LuckyNumberLabel.Name = "LuckyNumberLabel";
            this.LuckyNumberLabel.Size = new System.Drawing.Size(629, 48);
            this.LuckyNumberLabel.TabIndex = 0;
            this.LuckyNumberLabel.Text = "Your Luckiest of Lucky Number Is!!!!";
            // 
            // luckyNumber
            // 
            this.luckyNumber.AutoSize = true;
            this.luckyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumber.Location = new System.Drawing.Point(362, 245);
            this.luckyNumber.Name = "luckyNumber";
            this.luckyNumber.Size = new System.Drawing.Size(0, 55);
            this.luckyNumber.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 405);
            this.Controls.Add(this.luckyNumber);
            this.Controls.Add(this.LuckyNumberLabel);
            this.Name = "Form2";
            this.Text = "Your Special Lucky Number!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LuckyNumberLabel;
        private System.Windows.Forms.Label luckyNumber;
    }
}