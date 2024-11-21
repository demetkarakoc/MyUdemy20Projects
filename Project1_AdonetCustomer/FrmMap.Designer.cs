namespace Project1_AdonetCustomer
{
    partial class FrmMap
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
            this.btnOpenCityForm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCityForm
            // 
            this.btnOpenCityForm.Location = new System.Drawing.Point(84, 60);
            this.btnOpenCityForm.Name = "btnOpenCityForm";
            this.btnOpenCityForm.Size = new System.Drawing.Size(138, 44);
            this.btnOpenCityForm.TabIndex = 0;
            this.btnOpenCityForm.Text = "Şehir İşlemleri";
            this.btnOpenCityForm.UseVisualStyleBackColor = true;
            this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(84, 110);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(138, 44);
            this.btnOpenCustomerForm.TabIndex = 1;
            this.btnOpenCustomerForm.Text = "Müşteri İşlemleri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(84, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Controls.Add(this.btnOpenCityForm);
            this.Name = "FrmMap";
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCityForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnExit;
    }
}