using System.Drawing;

namespace EtaxInvoice
{
    partial class frmEmailConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "กรุณายืนยันอีเมล์ที่รับใบกำกับภาษีเต็มรูป";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(75, 90);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(196, 20);
            this.textBox_email.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::EtaxInvoice.Properties.Resources.icons8_folder_98;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(75, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // frmEmailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 181);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label1);
            this.Name = "frmEmailConfirm";
            this.Text = "frmEmailConfirm";
            this.Load += new System.EventHandler(this.frmEmailConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}