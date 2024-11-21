namespace Project8_RapidApiCurrency
{
    partial class Form1
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
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbSterlin = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.Location = new System.Drawing.Point(104, 57);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(58, 22);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuro.Location = new System.Drawing.Point(302, 57);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(58, 22);
            this.lblEuro.TabIndex = 3;
            this.lblEuro.Text = "label3";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPrice.Location = new System.Drawing.Point(208, 247);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(346, 34);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birim Tutar: ";
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDolar.Location = new System.Drawing.Point(145, 152);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(71, 24);
            this.rdbDolar.TabIndex = 7;
            this.rdbDolar.TabStop = true;
            this.rdbDolar.Text = "Dolar";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbEuro.Location = new System.Drawing.Point(254, 152);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(65, 24);
            this.rdbEuro.TabIndex = 8;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbSterlin
            // 
            this.rdbSterlin.AutoSize = true;
            this.rdbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSterlin.Location = new System.Drawing.Point(346, 152);
            this.rdbSterlin.Name = "rdbSterlin";
            this.rdbSterlin.Size = new System.Drawing.Size(78, 24);
            this.rdbSterlin.TabIndex = 9;
            this.rdbSterlin.TabStop = true;
            this.rdbSterlin.Text = "Sterlin";
            this.rdbSterlin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(208, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "İşlemi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ödenecek Tutar: ";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalPrice.Location = new System.Drawing.Point(208, 309);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(346, 34);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSterlin.Location = new System.Drawing.Point(511, 57);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(58, 22);
            this.lblSterlin.TabIndex = 13;
            this.lblSterlin.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 509);
            this.Controls.Add(this.lblSterlin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbSterlin);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbSterlin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblSterlin;
    }
}

