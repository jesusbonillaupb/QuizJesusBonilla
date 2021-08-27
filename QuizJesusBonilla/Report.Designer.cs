
namespace QuizJesusBonilla
{
    partial class Report
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
            this.lblReport = new System.Windows.Forms.Label();
            this.rtbReport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(309, 66);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(140, 39);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Reporte";
            // 
            // rtbReport
            // 
            this.rtbReport.Location = new System.Drawing.Point(118, 151);
            this.rtbReport.Name = "rtbReport";
            this.rtbReport.Size = new System.Drawing.Size(532, 142);
            this.rtbReport.TabIndex = 1;
            this.rtbReport.Text = "";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbReport);
            this.Controls.Add(this.lblReport);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblReport;
        public System.Windows.Forms.RichTextBox rtbReport;
    }
}