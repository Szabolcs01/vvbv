namespace HarcosokApplication
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
            this.btn_Létrehozás = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_Módosít = new System.Windows.Forms.Button();
            this.btn_Törlés = new System.Windows.Forms.Button();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.képességekListBox = new System.Windows.Forms.ListBox();
            this.harcosTextBox = new System.Windows.Forms.TextBox();
            this.leírásTextBox = new System.Windows.Forms.TextBox();
            this.kepessegekNeveTextBox = new System.Windows.Forms.TextBox();
            this.képesLeírásTextBox = new System.Windows.Forms.TextBox();
            this.Harcos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hasznalComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Létrehozás
            // 
            this.btn_Létrehozás.Location = new System.Drawing.Point(255, 38);
            this.btn_Létrehozás.Name = "btn_Létrehozás";
            this.btn_Létrehozás.Size = new System.Drawing.Size(75, 23);
            this.btn_Létrehozás.TabIndex = 0;
            this.btn_Létrehozás.Text = "Létrehozás";
            this.btn_Létrehozás.UseVisualStyleBackColor = true;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(12, 202);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 1;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            // 
            // btn_Módosít
            // 
            this.btn_Módosít.Location = new System.Drawing.Point(343, 293);
            this.btn_Módosít.Name = "btn_Módosít";
            this.btn_Módosít.Size = new System.Drawing.Size(75, 23);
            this.btn_Módosít.TabIndex = 2;
            this.btn_Módosít.Text = "Módosít";
            this.btn_Módosít.UseVisualStyleBackColor = true;
            // 
            // btn_Törlés
            // 
            this.btn_Törlés.Location = new System.Drawing.Point(160, 452);
            this.btn_Törlés.Name = "btn_Törlés";
            this.btn_Törlés.Size = new System.Drawing.Size(75, 23);
            this.btn_Törlés.TabIndex = 3;
            this.btn_Törlés.Text = "Törlés";
            this.btn_Törlés.UseVisualStyleBackColor = true;
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(12, 255);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 186);
            this.harcosokListBox.TabIndex = 4;
            // 
            // képességekListBox
            // 
            this.képességekListBox.FormattingEnabled = true;
            this.képességekListBox.Location = new System.Drawing.Point(160, 255);
            this.képességekListBox.Name = "képességekListBox";
            this.képességekListBox.Size = new System.Drawing.Size(120, 186);
            this.képességekListBox.TabIndex = 5;
            // 
            // harcosTextBox
            // 
            this.harcosTextBox.Location = new System.Drawing.Point(64, 40);
            this.harcosTextBox.Name = "harcosTextBox";
            this.harcosTextBox.Size = new System.Drawing.Size(156, 20);
            this.harcosTextBox.TabIndex = 6;
            this.harcosTextBox.Text = "harcosNeve";
            // 
            // leírásTextBox
            // 
            this.leírásTextBox.Location = new System.Drawing.Point(296, 143);
            this.leírásTextBox.Name = "leírásTextBox";
            this.leírásTextBox.Size = new System.Drawing.Size(217, 20);
            this.leírásTextBox.TabIndex = 7;
            this.leírásTextBox.Text = "leírásTextbox";
            // 
            // kepessegekNeveTextBox
            // 
            this.kepessegekNeveTextBox.Location = new System.Drawing.Point(72, 160);
            this.kepessegekNeveTextBox.Name = "kepessegekNeveTextBox";
            this.kepessegekNeveTextBox.Size = new System.Drawing.Size(156, 20);
            this.kepessegekNeveTextBox.TabIndex = 8;
            this.kepessegekNeveTextBox.Text = "kepessegekNeve";
            // 
            // képesLeírásTextBox
            // 
            this.képesLeírásTextBox.Location = new System.Drawing.Point(343, 255);
            this.képesLeírásTextBox.Name = "képesLeírásTextBox";
            this.képesLeírásTextBox.Size = new System.Drawing.Size(156, 20);
            this.képesLeírásTextBox.TabIndex = 9;
            this.képesLeírásTextBox.Text = "képességLeírás";
            // 
            // Harcos
            // 
            this.Harcos.AutoSize = true;
            this.Harcos.Location = new System.Drawing.Point(12, 9);
            this.Harcos.Name = "Harcos";
            this.Harcos.Size = new System.Drawing.Size(103, 13);
            this.Harcos.TabIndex = 10;
            this.Harcos.Text = "Harcos létrehozzása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Képességek hozzáadásaa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Leírás";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Képességek:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Képességek Leírása";
            // 
            // hasznalComboBox
            // 
            this.hasznalComboBox.FormattingEnabled = true;
            this.hasznalComboBox.Location = new System.Drawing.Point(72, 127);
            this.hasznalComboBox.Name = "hasznalComboBox";
            this.hasznalComboBox.Size = new System.Drawing.Size(121, 21);
            this.hasznalComboBox.TabIndex = 18;
            this.hasznalComboBox.Text = "használoCombobox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Harcosok:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasznalComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Harcos);
            this.Controls.Add(this.képesLeírásTextBox);
            this.Controls.Add(this.kepessegekNeveTextBox);
            this.Controls.Add(this.leírásTextBox);
            this.Controls.Add(this.harcosTextBox);
            this.Controls.Add(this.képességekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.btn_Törlés);
            this.Controls.Add(this.btn_Módosít);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_Létrehozás);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Létrehozás;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_Módosít;
        private System.Windows.Forms.Button btn_Törlés;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox képességekListBox;
        private System.Windows.Forms.TextBox harcosTextBox;
        private System.Windows.Forms.TextBox leírásTextBox;
        private System.Windows.Forms.TextBox kepessegekNeveTextBox;
        private System.Windows.Forms.TextBox képesLeírásTextBox;
        private System.Windows.Forms.Label Harcos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox hasznalComboBox;
        private System.Windows.Forms.Label label1;
    }
}

