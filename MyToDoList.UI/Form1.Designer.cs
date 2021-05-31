
namespace MyToDoList.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.cbYildiz = new System.Windows.Forms.CheckBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYildiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(66, 47);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(440, 41);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ne yaptığını not al ";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(12, 12);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(490, 32);
            this.txtNot.TabIndex = 2;
            this.txtNot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNot_KeyDown);
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 25;
            this.lstNotlar.Location = new System.Drawing.Point(12, 94);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(494, 304);
            this.lstNotlar.TabIndex = 3;
            this.lstNotlar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstNotlar_KeyDown);
            // 
            // btnArama
            // 
            this.btnArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArama.BackgroundImage")));
            this.btnArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArama.Location = new System.Drawing.Point(315, 495);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(191, 33);
            this.btnArama.TabIndex = 4;
            this.btnArama.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 404);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(245, 62);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Notu Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // cbYildiz
            // 
            this.cbYildiz.AutoSize = true;
            this.cbYildiz.Location = new System.Drawing.Point(261, 499);
            this.cbYildiz.Name = "cbYildiz";
            this.cbYildiz.Size = new System.Drawing.Size(48, 29);
            this.cbYildiz.TabIndex = 6;
            this.cbYildiz.Text = "★";
            this.cbYildiz.UseVisualStyleBackColor = true;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(12, 496);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(245, 32);
            this.txtArama.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(261, 404);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(245, 62);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Notu Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yıldızlı Notları Aramak İçin ★\'ın Yanındaki Kutucuğu İşaretleyiniz";
            // 
            // btnYildiz
            // 
            this.btnYildiz.Location = new System.Drawing.Point(13, 47);
            this.btnYildiz.Name = "btnYildiz";
            this.btnYildiz.Size = new System.Drawing.Size(47, 41);
            this.btnYildiz.TabIndex = 10;
            this.btnYildiz.Text = "★";
            this.btnYildiz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 534);
            this.Controls.Add(this.btnYildiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cbYildiz);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.btnEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "My ToDo List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.CheckBox cbYildiz;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYildiz;
    }
}

