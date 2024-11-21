namespace Project16_MailRegister
{
    partial class FrmMailConfrim
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(198, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 28);
            this.txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email Adresi:";
            // 
            // txtConfirmCode
            // 
            this.txtConfirmCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirmCode.Location = new System.Drawing.Point(198, 141);
            this.txtConfirmCode.Name = "txtConfirmCode";
            this.txtConfirmCode.Size = new System.Drawing.Size(276, 28);
            this.txtConfirmCode.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "6 Haneli Kod:";
            // 
            // btnActivation
            // 
            this.btnActivation.BackColor = System.Drawing.Color.RosyBrown;
            this.btnActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnActivation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnActivation.Location = new System.Drawing.Point(280, 204);
            this.btnActivation.Name = "btnActivation";
            this.btnActivation.Size = new System.Drawing.Size(194, 37);
            this.btnActivation.TabIndex = 7;
            this.btnActivation.Text = "Aktivasyonu Tamamla";
            this.btnActivation.UseVisualStyleBackColor = false;
            this.btnActivation.Click += new System.EventHandler(this.btnActivation_Click);
            // 
            // FrmMailConfrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActivation);
            this.Controls.Add(this.txtConfirmCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "FrmMailConfrim";
            this.Text = "Mail Aktivasyon Formu";
            this.Load += new System.EventHandler(this.FrmMailConfrim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActivation;
    }
}