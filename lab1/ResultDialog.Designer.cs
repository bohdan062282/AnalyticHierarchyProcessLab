namespace lab1
{
    partial class ResultDialog
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
            this.resultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.Location = new System.Drawing.Point(13, 13);
            this.resultText.Margin = new System.Windows.Forms.Padding(3);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(60, 24);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "label1";
            // 
            // ResultDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.resultText);
            this.Name = "ResultDialog";
            this.Text = "ResultDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultText;
    }
}