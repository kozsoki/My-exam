namespace Licenta
{
    partial class Select
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SELECT_DOMENIU = new System.Windows.Forms.Button();
            this.SELCT_ALL = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ACCEPT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.REMOVE_ALL = new System.Windows.Forms.Button();
            this.RES_START = new System.Windows.Forms.Button();
            this.INFO_START = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 340);
            this.listBox1.TabIndex = 0;
            // 
            // SELECT_DOMENIU
            // 
            this.SELECT_DOMENIU.Location = new System.Drawing.Point(290, 81);
            this.SELECT_DOMENIU.Name = "SELECT_DOMENIU";
            this.SELECT_DOMENIU.Size = new System.Drawing.Size(126, 58);
            this.SELECT_DOMENIU.TabIndex = 1;
            this.SELECT_DOMENIU.Text = "SELECTEAZA DOMENIU";
            this.SELECT_DOMENIU.UseVisualStyleBackColor = true;
            this.SELECT_DOMENIU.Click += new System.EventHandler(this.SELECT_DOMENIU_Click);
            // 
            // SELCT_ALL
            // 
            this.SELCT_ALL.Location = new System.Drawing.Point(290, 145);
            this.SELCT_ALL.Name = "SELCT_ALL";
            this.SELCT_ALL.Size = new System.Drawing.Size(126, 58);
            this.SELCT_ALL.TabIndex = 3;
            this.SELCT_ALL.Text = "ADAUGA TOATE";
            this.SELCT_ALL.UseVisualStyleBackColor = true;
            this.SELCT_ALL.Click += new System.EventHandler(this.SELECT_ALL_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(422, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(257, 340);
            this.listBox2.TabIndex = 4;
            // 
            // ACCEPT
            // 
            this.ACCEPT.Location = new System.Drawing.Point(553, 393);
            this.ACCEPT.Name = "ACCEPT";
            this.ACCEPT.Size = new System.Drawing.Size(126, 58);
            this.ACCEPT.TabIndex = 6;
            this.ACCEPT.Text = "ACCEPTA";
            this.ACCEPT.UseVisualStyleBackColor = true;
            this.ACCEPT.Click += new System.EventHandler(this.ACCEPT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Criterii de selectie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Intrebari selectate";
            // 
            // REMOVE_ALL
            // 
            this.REMOVE_ALL.Location = new System.Drawing.Point(290, 209);
            this.REMOVE_ALL.Name = "REMOVE_ALL";
            this.REMOVE_ALL.Size = new System.Drawing.Size(126, 30);
            this.REMOVE_ALL.TabIndex = 20;
            this.REMOVE_ALL.Text = "REMOVE";
            this.REMOVE_ALL.UseVisualStyleBackColor = true;
            this.REMOVE_ALL.Click += new System.EventHandler(this.REMOVE_ALL_Click);
            // 
            // RES_START
            // 
            this.RES_START.Location = new System.Drawing.Point(27, 393);
            this.RES_START.Name = "RES_START";
            this.RES_START.Size = new System.Drawing.Size(126, 58);
            this.RES_START.TabIndex = 21;
            this.RES_START.Text = "CREEAZA INTREBARE";
            this.RES_START.UseVisualStyleBackColor = true;
            this.RES_START.Click += new System.EventHandler(this.RES_START_Click);
            // 
            // INFO_START
            // 
            this.INFO_START.Location = new System.Drawing.Point(158, 393);
            this.INFO_START.Name = "INFO_START";
            this.INFO_START.Size = new System.Drawing.Size(126, 58);
            this.INFO_START.TabIndex = 22;
            this.INFO_START.Text = "INFORMATII";
            this.INFO_START.UseVisualStyleBackColor = true;
            this.INFO_START.Click += new System.EventHandler(this.INFO_START_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(691, 509);
            this.Controls.Add(this.INFO_START);
            this.Controls.Add(this.RES_START);
            this.Controls.Add(this.REMOVE_ALL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ACCEPT);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.SELCT_ALL);
            this.Controls.Add(this.SELECT_DOMENIU);
            this.Controls.Add(this.listBox1);
            this.Name = "Select";
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SELECT_DOMENIU;
        private System.Windows.Forms.Button SELCT_ALL;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ACCEPT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button REMOVE_ALL;
        private System.Windows.Forms.Button RES_START;
        private System.Windows.Forms.Button INFO_START;
    }
}