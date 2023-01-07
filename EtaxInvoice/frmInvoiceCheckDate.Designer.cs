namespace EtaxInvoice
{
    partial class frmInvoiceCheckDate
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
            this.button_today = new System.Windows.Forms.Button();
            this.button_otherday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_today
            // 
            this.button_today.Location = new System.Drawing.Point(94, 106);
            this.button_today.Name = "button_today";
            this.button_today.Size = new System.Drawing.Size(75, 23);
            this.button_today.TabIndex = 0;
            this.button_today.Text = "วันนี้";
            this.button_today.UseVisualStyleBackColor = true;
            this.button_today.Click += new System.EventHandler(this.button_today_Click);
            // 
            // button_otherday
            // 
            this.button_otherday.Location = new System.Drawing.Point(203, 106);
            this.button_otherday.Name = "button_otherday";
            this.button_otherday.Size = new System.Drawing.Size(75, 23);
            this.button_otherday.TabIndex = 1;
            this.button_otherday.Text = "ก่อนหน้านี้";
            this.button_otherday.UseVisualStyleBackColor = true;
            this.button_otherday.Click += new System.EventHandler(this.button_otherday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ลูกค้าซื้อสินค้าวันนี้หรือก่อนหน้านี้\r\n(สามารถดูได้จากวันที่ใบกำกับภาษีอย่างย่อ)";
            // 
            // frmInvoiceCheckDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_otherday);
            this.Controls.Add(this.button_today);
            this.Name = "frmInvoiceCheckDate";
            this.Text = "frmInvoiceCheckDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_today;
        private System.Windows.Forms.Button button_otherday;
        private System.Windows.Forms.Label label1;
    }
}