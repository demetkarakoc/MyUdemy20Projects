namespace Project10_PostgreSQLToDoListApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbComplieted = new System.Windows.Forms.RadioButton();
            this.rdbContinue = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnCheckhedList = new System.Windows.Forms.Button();
            this.btnContinueList = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(518, 50);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(179, 38);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(159, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(303, 28);
            this.txtId.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(159, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(303, 28);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPriority.Location = new System.Drawing.Point(159, 197);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(303, 28);
            this.txtPriority.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(70, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öncelik:";
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textDescription.Location = new System.Drawing.Point(159, 244);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(303, 180);
            this.textDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama:";
            // 
            // rdbComplieted
            // 
            this.rdbComplieted.AutoSize = true;
            this.rdbComplieted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbComplieted.Location = new System.Drawing.Point(164, 454);
            this.rdbComplieted.Name = "rdbComplieted";
            this.rdbComplieted.Size = new System.Drawing.Size(129, 26);
            this.rdbComplieted.TabIndex = 13;
            this.rdbComplieted.TabStop = true;
            this.rdbComplieted.Text = "Tamamlandı";
            this.rdbComplieted.UseVisualStyleBackColor = true;
            // 
            // rdbContinue
            // 
            this.rdbContinue.AutoSize = true;
            this.rdbContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbContinue.Location = new System.Drawing.Point(303, 454);
            this.rdbContinue.Name = "rdbContinue";
            this.rdbContinue.Size = new System.Drawing.Size(141, 26);
            this.rdbContinue.TabIndex = 15;
            this.rdbContinue.TabStop = true;
            this.rdbContinue.Text = "Devem ediyor";
            this.rdbContinue.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(518, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(179, 38);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(518, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 38);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(518, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 38);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAllList
            // 
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllList.Location = new System.Drawing.Point(518, 239);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(179, 38);
            this.btnAllList.TabIndex = 19;
            this.btnAllList.Text = "Tüm Liste";
            this.btnAllList.UseVisualStyleBackColor = true;
            // 
            // btnCheckhedList
            // 
            this.btnCheckhedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckhedList.Location = new System.Drawing.Point(518, 283);
            this.btnCheckhedList.Name = "btnCheckhedList";
            this.btnCheckhedList.Size = new System.Drawing.Size(179, 38);
            this.btnCheckhedList.TabIndex = 20;
            this.btnCheckhedList.Text = "Tamamlananlar";
            this.btnCheckhedList.UseVisualStyleBackColor = true;
            // 
            // btnContinueList
            // 
            this.btnContinueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinueList.Location = new System.Drawing.Point(518, 327);
            this.btnContinueList.Name = "btnContinueList";
            this.btnContinueList.Size = new System.Drawing.Size(179, 38);
            this.btnContinueList.TabIndex = 21;
            this.btnContinueList.Text = "Devem Edenler";
            this.btnContinueList.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(159, 156);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(303, 30);
            this.cmbCategory.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 555);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnContinueList);
            this.Controls.Add(this.btnCheckhedList);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdbContinue);
            this.Controls.Add(this.rdbComplieted);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Yapılacaklar Listesi/ ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbComplieted;
        private System.Windows.Forms.RadioButton rdbContinue;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Button btnCheckhedList;
        private System.Windows.Forms.Button btnContinueList;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}

