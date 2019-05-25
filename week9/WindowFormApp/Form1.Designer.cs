namespace WindowFormApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnnone = new System.Windows.Forms.RadioButton();
            this.rbtnsingle = new System.Windows.Forms.RadioButton();
            this.rbtntool = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtop = new System.Windows.Forms.TextBox();
            this.btnform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "window title";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(152, 28);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(456, 21);
            this.txttitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "window location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(166, 87);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(70, 21);
            this.txtx.TabIndex = 4;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(257, 87);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(70, 21);
            this.txty.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "window size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "height";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(538, 87);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(70, 21);
            this.txtheight.TabIndex = 10;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(447, 87);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(70, 21);
            this.txtwidth.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "FoormBorderStyle";
            // 
            // rbtnnone
            // 
            this.rbtnnone.AutoSize = true;
            this.rbtnnone.Location = new System.Drawing.Point(181, 138);
            this.rbtnnone.Name = "rbtnnone";
            this.rbtnnone.Size = new System.Drawing.Size(53, 16);
            this.rbtnnone.TabIndex = 14;
            this.rbtnnone.TabStop = true;
            this.rbtnnone.Text = "None";
            this.rbtnnone.UseVisualStyleBackColor = true;
            // 
            // rbtnsingle
            // 
            this.rbtnsingle.AutoSize = true;
            this.rbtnsingle.Location = new System.Drawing.Point(181, 160);
            this.rbtnsingle.Name = "rbtnsingle";
            this.rbtnsingle.Size = new System.Drawing.Size(89, 16);
            this.rbtnsingle.TabIndex = 15;
            this.rbtnsingle.TabStop = true;
            this.rbtnsingle.Text = "FixedSingle";
            this.rbtnsingle.UseVisualStyleBackColor = true;
            // 
            // rbtntool
            // 
            this.rbtntool.AutoSize = true;
            this.rbtntool.Location = new System.Drawing.Point(181, 182);
            this.rbtntool.Name = "rbtntool";
            this.rbtntool.Size = new System.Drawing.Size(123, 16);
            this.rbtntool.TabIndex = 16;
            this.rbtntool.TabStop = true;
            this.rbtntool.Text = "FixedToolWindow";
            this.rbtntool.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Opacity";
            // 
            // txtop
            // 
            this.txtop.Location = new System.Drawing.Point(128, 225);
            this.txtop.Name = "txtop";
            this.txtop.Size = new System.Drawing.Size(130, 21);
            this.txtop.TabIndex = 18;
            // 
            // btnform
            // 
            this.btnform.Location = new System.Drawing.Point(279, 271);
            this.btnform.Name = "btnform";
            this.btnform.Size = new System.Drawing.Size(162, 35);
            this.btnform.TabIndex = 19;
            this.btnform.Text = "Create Form";
            this.btnform.UseVisualStyleBackColor = true;
            this.btnform.Click += new System.EventHandler(this.btnform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 339);
            this.Controls.Add(this.btnform);
            this.Controls.Add(this.txtop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rbtntool);
            this.Controls.Add(this.rbtnsingle);
            this.Controls.Add(this.rbtnnone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnnone;
        private System.Windows.Forms.RadioButton rbtnsingle;
        private System.Windows.Forms.RadioButton rbtntool;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtop;
        private System.Windows.Forms.Button btnform;
    }
}

