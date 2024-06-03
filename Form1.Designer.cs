namespace CS_GiaiPtBac1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnKQ = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(135, 21);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 21);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(135, 58);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 21);
            this.txtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(135, 96);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 21);
            this.txtKQ.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(53, 137);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(77, 23);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "Kết Quả";
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(135, 175);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 23);
            this.btnKQ.TabIndex = 6;
            this.btnKQ.Text = "Result";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(38, 297);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(246, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(38, 349);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(246, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

