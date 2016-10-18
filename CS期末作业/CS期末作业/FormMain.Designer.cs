namespace CS期末作业
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxM = new System.Windows.Forms.TextBox();
            this.txtBoxT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butnOK = new System.Windows.Forms.Button();
            this.butnCancle = new System.Windows.Forms.Button();
            this.txtBoxAns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxM
            // 
            this.txtBoxM.Location = new System.Drawing.Point(161, 27);
            this.txtBoxM.Name = "txtBoxM";
            this.txtBoxM.Size = new System.Drawing.Size(136, 21);
            this.txtBoxM.TabIndex = 1;
            this.txtBoxM.Text = "80";
            // 
            // txtBoxT
            // 
            this.txtBoxT.Location = new System.Drawing.Point(161, 60);
            this.txtBoxT.Name = "txtBoxT";
            this.txtBoxT.Size = new System.Drawing.Size(136, 21);
            this.txtBoxT.TabIndex = 3;
            this.txtBoxT.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进化代数T（100~500）";
            // 
            // txtBoxPc
            // 
            this.txtBoxPc.Location = new System.Drawing.Point(161, 94);
            this.txtBoxPc.Name = "txtBoxPc";
            this.txtBoxPc.Size = new System.Drawing.Size(136, 21);
            this.txtBoxPc.TabIndex = 5;
            this.txtBoxPc.Text = "0.6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "交叉概率Pc（0.4~0.99）";
            // 
            // txtBoxPm
            // 
            this.txtBoxPm.Location = new System.Drawing.Point(161, 124);
            this.txtBoxPm.Name = "txtBoxPm";
            this.txtBoxPm.Size = new System.Drawing.Size(136, 21);
            this.txtBoxPm.TabIndex = 7;
            this.txtBoxPm.Text = "0.01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "变异概率Pm（0.0001~0.1）";
            // 
            // butnOK
            // 
            this.butnOK.Location = new System.Drawing.Point(32, 222);
            this.butnOK.Name = "butnOK";
            this.butnOK.Size = new System.Drawing.Size(75, 23);
            this.butnOK.TabIndex = 8;
            this.butnOK.Text = "开始";
            this.butnOK.UseVisualStyleBackColor = true;
            this.butnOK.Click += new System.EventHandler(this.butnOK_Click);
            // 
            // butnCancle
            // 
            this.butnCancle.Location = new System.Drawing.Point(172, 222);
            this.butnCancle.Name = "butnCancle";
            this.butnCancle.Size = new System.Drawing.Size(75, 23);
            this.butnCancle.TabIndex = 9;
            this.butnCancle.Text = "取消";
            this.butnCancle.UseVisualStyleBackColor = true;
            this.butnCancle.Click += new System.EventHandler(this.butnCancle_Click);
            // 
            // txtBoxAns
            // 
            this.txtBoxAns.Location = new System.Drawing.Point(59, 192);
            this.txtBoxAns.Name = "txtBoxAns";
            this.txtBoxAns.ReadOnly = true;
            this.txtBoxAns.Size = new System.Drawing.Size(238, 21);
            this.txtBoxAns.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "满意解";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "尚无选择的理论依据，一般取推荐值里 ";
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(46, 156);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.ReadOnly = true;
            this.txtBoxX1.Size = new System.Drawing.Size(109, 21);
            this.txtBoxX1.TabIndex = 13;
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(188, 156);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.ReadOnly = true;
            this.txtBoxX2.Size = new System.Drawing.Size(109, 21);
            this.txtBoxX2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "x1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "x2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "群体大小M（20~100）";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 254);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxX2);
            this.Controls.Add(this.txtBoxX1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAns);
            this.Controls.Add(this.butnCancle);
            this.Controls.Add(this.butnOK);
            this.Controls.Add(this.txtBoxPm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "模拟基因演算法";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxM;
        private System.Windows.Forms.TextBox txtBoxT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butnOK;
        private System.Windows.Forms.Button butnCancle;
        private System.Windows.Forms.TextBox txtBoxAns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

