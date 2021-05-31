
namespace MyToDoList.UI
{
    partial class Duzenle
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
            this.txtYapilan = new System.Windows.Forms.TextBox();
            this.dtpZaman = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYapilan
            // 
            this.txtYapilan.Location = new System.Drawing.Point(12, 37);
            this.txtYapilan.Name = "txtYapilan";
            this.txtYapilan.Size = new System.Drawing.Size(301, 32);
            this.txtYapilan.TabIndex = 0;
            // 
            // dtpZaman
            // 
            this.dtpZaman.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpZaman.Location = new System.Drawing.Point(78, 87);
            this.dtpZaman.Name = "dtpZaman";
            this.dtpZaman.Size = new System.Drawing.Size(235, 32);
            this.dtpZaman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notunuz:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 137);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 50);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(174, 137);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(139, 50);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "İptal";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 200);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpZaman);
            this.Controls.Add(this.txtYapilan);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Duzenle";
            this.Text = "Duzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYapilan;
        private System.Windows.Forms.DateTimePicker dtpZaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}