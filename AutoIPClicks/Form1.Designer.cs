
namespace AutoIPClicks
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
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nbrTimes = new System.Windows.Forms.NumericUpDown();
            this.ckbShopacc = new System.Windows.Forms.CheckBox();
            this.ckbHttp = new System.Windows.Forms.CheckBox();
            this.ckb3w = new System.Windows.Forms.CheckBox();
            this.ckbcom = new System.Windows.Forms.CheckBox();
            this.ckbnet = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbrTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(350, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto IP - Clicks ";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(240, 94);
            this.txbUrl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(546, 33);
            this.txbUrl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your website: ";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(356, 252);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(164, 44);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the number of times:";
            // 
            // nbrTimes
            // 
            this.nbrTimes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrTimes.Location = new System.Drawing.Point(335, 192);
            this.nbrTimes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nbrTimes.Name = "nbrTimes";
            this.nbrTimes.Size = new System.Drawing.Size(96, 33);
            this.nbrTimes.TabIndex = 5;
            // 
            // ckbShopacc
            // 
            this.ckbShopacc.AutoSize = true;
            this.ckbShopacc.Location = new System.Drawing.Point(549, 194);
            this.ckbShopacc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ckbShopacc.Name = "ckbShopacc";
            this.ckbShopacc.Size = new System.Drawing.Size(237, 31);
            this.ckbShopacc.TabIndex = 6;
            this.ckbShopacc.Text = "Check ShopAccGame";
            this.ckbShopacc.UseVisualStyleBackColor = true;
            this.ckbShopacc.CheckedChanged += new System.EventHandler(this.ckbShopacc_CheckedChanged);
            // 
            // ckbHttp
            // 
            this.ckbHttp.AutoSize = true;
            this.ckbHttp.Location = new System.Drawing.Point(240, 139);
            this.ckbHttp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ckbHttp.Name = "ckbHttp";
            this.ckbHttp.Size = new System.Drawing.Size(96, 31);
            this.ckbHttp.TabIndex = 7;
            this.ckbHttp.Text = "http://";
            this.ckbHttp.UseVisualStyleBackColor = true;
            this.ckbHttp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckb3w
            // 
            this.ckb3w.AutoSize = true;
            this.ckb3w.Location = new System.Drawing.Point(344, 139);
            this.ckb3w.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ckb3w.Name = "ckb3w";
            this.ckb3w.Size = new System.Drawing.Size(87, 31);
            this.ckb3w.TabIndex = 8;
            this.ckb3w.Text = "www.";
            this.ckb3w.UseVisualStyleBackColor = true;
            this.ckb3w.CheckedChanged += new System.EventHandler(this.ckb3w_CheckedChanged);
            // 
            // ckbcom
            // 
            this.ckbcom.AutoSize = true;
            this.ckbcom.Location = new System.Drawing.Point(585, 139);
            this.ckbcom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ckbcom.Name = "ckbcom";
            this.ckbcom.Size = new System.Drawing.Size(81, 31);
            this.ckbcom.TabIndex = 9;
            this.ckbcom.Text = ".com";
            this.ckbcom.UseVisualStyleBackColor = true;
            this.ckbcom.CheckedChanged += new System.EventHandler(this.ckbcom_CheckedChanged);
            // 
            // ckbnet
            // 
            this.ckbnet.AutoSize = true;
            this.ckbnet.Location = new System.Drawing.Point(717, 139);
            this.ckbnet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ckbnet.Name = "ckbnet";
            this.ckbnet.Size = new System.Drawing.Size(69, 31);
            this.ckbnet.TabIndex = 10;
            this.ckbnet.Text = ".net";
            this.ckbnet.UseVisualStyleBackColor = true;
            this.ckbnet.CheckedChanged += new System.EventHandler(this.cknnet_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 338);
            this.Controls.Add(this.ckbnet);
            this.Controls.Add(this.ckbcom);
            this.Controls.Add(this.ckb3w);
            this.Controls.Add(this.ckbHttp);
            this.Controls.Add(this.ckbShopacc);
            this.Controls.Add(this.nbrTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoIP - Clicks ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbrTimes;
        private System.Windows.Forms.CheckBox ckbShopacc;
        private System.Windows.Forms.CheckBox ckbHttp;
        private System.Windows.Forms.CheckBox ckb3w;
        private System.Windows.Forms.CheckBox ckbcom;
        private System.Windows.Forms.CheckBox ckbnet;
    }
}

