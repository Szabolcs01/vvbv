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
            this.SuspendLayout();
            // 
            // btn_Létrehozás
            // 
            this.btn_Létrehozás.Location = new System.Drawing.Point(326, 321);
            this.btn_Létrehozás.Name = "btn_Létrehozás";
            this.btn_Létrehozás.Size = new System.Drawing.Size(75, 23);
            this.btn_Létrehozás.TabIndex = 0;
            this.btn_Létrehozás.Text = "Létrehozás";
            this.btn_Létrehozás.UseVisualStyleBackColor = true;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(407, 321);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 1;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            // 
            // btn_Módosít
            // 
            this.btn_Módosít.Location = new System.Drawing.Point(488, 321);
            this.btn_Módosít.Name = "btn_Módosít";
            this.btn_Módosít.Size = new System.Drawing.Size(75, 23);
            this.btn_Módosít.TabIndex = 2;
            this.btn_Módosít.Text = "Módosít";
            this.btn_Módosít.UseVisualStyleBackColor = true;
            // 
            // btn_Törlés
            // 
            this.btn_Törlés.Location = new System.Drawing.Point(569, 321);
            this.btn_Törlés.Name = "btn_Törlés";
            this.btn_Törlés.Size = new System.Drawing.Size(75, 23);
            this.btn_Törlés.TabIndex = 3;
            this.btn_Törlés.Text = "Törlés";
            this.btn_Törlés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 476);
            this.Controls.Add(this.btn_Törlés);
            this.Controls.Add(this.btn_Módosít);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_Létrehozás);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Létrehozás;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_Módosít;
        private System.Windows.Forms.Button btn_Törlés;
    }
}

