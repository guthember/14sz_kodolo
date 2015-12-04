namespace kodolas
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
            this.btnMegnyit = new System.Windows.Forms.Button();
            this.ofdMegnyit = new System.Windows.Forms.OpenFileDialog();
            this.lbSzoveg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKodolas = new System.Windows.Forms.Button();
            this.lbKodolt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKiiras = new System.Windows.Forms.Button();
            this.sfdKiiras = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnMegnyit
            // 
            this.btnMegnyit.Location = new System.Drawing.Point(98, 297);
            this.btnMegnyit.Name = "btnMegnyit";
            this.btnMegnyit.Size = new System.Drawing.Size(75, 23);
            this.btnMegnyit.TabIndex = 0;
            this.btnMegnyit.Text = "Megnyit";
            this.btnMegnyit.UseVisualStyleBackColor = true;
            this.btnMegnyit.Click += new System.EventHandler(this.btnMegnyit_Click);
            // 
            // ofdMegnyit
            // 
            this.ofdMegnyit.FileName = "szoveg.txt";
            this.ofdMegnyit.Filter = "Text fájlok (*.txt)| *.txt";
            this.ofdMegnyit.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMegnyit_FileOk);
            // 
            // lbSzoveg
            // 
            this.lbSzoveg.FormattingEnabled = true;
            this.lbSzoveg.Location = new System.Drawing.Point(28, 31);
            this.lbSzoveg.Name = "lbSzoveg";
            this.lbSzoveg.Size = new System.Drawing.Size(236, 238);
            this.lbSzoveg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A fájl tartalma";
            // 
            // btnKodolas
            // 
            this.btnKodolas.Enabled = false;
            this.btnKodolas.Location = new System.Drawing.Point(324, 297);
            this.btnKodolas.Name = "btnKodolas";
            this.btnKodolas.Size = new System.Drawing.Size(75, 23);
            this.btnKodolas.TabIndex = 3;
            this.btnKodolas.Text = "Kódolás";
            this.btnKodolas.UseVisualStyleBackColor = true;
            this.btnKodolas.Click += new System.EventHandler(this.btnKodolas_Click);
            // 
            // lbKodolt
            // 
            this.lbKodolt.FormattingEnabled = true;
            this.lbKodolt.Location = new System.Drawing.Point(311, 32);
            this.lbKodolt.Name = "lbKodolt";
            this.lbKodolt.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbKodolt.Size = new System.Drawing.Size(243, 238);
            this.lbKodolt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kódolt szöveg:";
            // 
            // btnKiiras
            // 
            this.btnKiiras.Enabled = false;
            this.btnKiiras.Location = new System.Drawing.Point(453, 297);
            this.btnKiiras.Name = "btnKiiras";
            this.btnKiiras.Size = new System.Drawing.Size(75, 23);
            this.btnKiiras.TabIndex = 6;
            this.btnKiiras.Text = "Fájlba írás";
            this.btnKiiras.UseVisualStyleBackColor = true;
            this.btnKiiras.Click += new System.EventHandler(this.btnKiiras_Click);
            // 
            // sfdKiiras
            // 
            this.sfdKiiras.FileName = "kodolt.txt";
            this.sfdKiiras.Filter = "Text fájlok (*.txt) | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 343);
            this.Controls.Add(this.btnKiiras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbKodolt);
            this.Controls.Add(this.btnKodolas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSzoveg);
            this.Controls.Add(this.btnMegnyit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kódoló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMegnyit;
        private System.Windows.Forms.OpenFileDialog ofdMegnyit;
        private System.Windows.Forms.ListBox lbSzoveg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKodolas;
        private System.Windows.Forms.ListBox lbKodolt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKiiras;
        private System.Windows.Forms.SaveFileDialog sfdKiiras;
    }
}

