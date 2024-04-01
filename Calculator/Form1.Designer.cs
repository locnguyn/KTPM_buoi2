namespace Calculator
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.MaskedTextBox();
            this.txtKq = new System.Windows.Forms.MaskedTextBox();
            this.g = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCong = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(188, 67);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(188, 147);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(188, 227);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 20);
            this.txtKq.TabIndex = 2;
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(101, 70);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(27, 13);
            this.g.TabIndex = 3;
            this.g.Text = "số 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KQ";
            // 
            // buttonCong
            // 
            this.buttonCong.Location = new System.Drawing.Point(48, 304);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(75, 23);
            this.buttonCong.TabIndex = 6;
            this.buttonCong.Text = "Cộng";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.buttonCong_Click);
            // 
            // buttonTru
            // 
            this.buttonTru.Location = new System.Drawing.Point(129, 304);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(75, 23);
            this.buttonTru.TabIndex = 6;
            this.buttonTru.Text = "Trừ";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.buttonTru_Click);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Location = new System.Drawing.Point(210, 304);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(75, 23);
            this.buttonNhan.TabIndex = 6;
            this.buttonNhan.Text = "Nhân";
            this.buttonNhan.UseMnemonic = false;
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.buttonNhan_Click);
            // 
            // buttonChia
            // 
            this.buttonChia.Location = new System.Drawing.Point(291, 304);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(75, 23);
            this.buttonChia.TabIndex = 6;
            this.buttonChia.Text = "Chia";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.buttonChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 363);
            this.Controls.Add(this.buttonChia);
            this.Controls.Add(this.buttonNhan);
            this.Controls.Add(this.buttonTru);
            this.Controls.Add(this.buttonCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.g);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.MaskedTextBox txtB;
        private System.Windows.Forms.MaskedTextBox txtKq;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button buttonChia;
    }
}

