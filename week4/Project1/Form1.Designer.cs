namespace Project1
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
            this.lblfrac1 = new System.Windows.Forms.Label();
            this.lblj1 = new System.Windows.Forms.Label();
            this.lblm1 = new System.Windows.Forms.Label();
            this.lblplus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblj2 = new System.Windows.Forms.Label();
            this.lblm2 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.lblrj = new System.Windows.Forms.Label();
            this.lblrm = new System.Windows.Forms.Label();
            this.btnres = new System.Windows.Forms.Button();
            this.txtj1 = new System.Windows.Forms.TextBox();
            this.txtm1 = new System.Windows.Forms.TextBox();
            this.txtj2 = new System.Windows.Forms.TextBox();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.txtrj = new System.Windows.Forms.TextBox();
            this.txtrm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfrac1
            // 
            this.lblfrac1.AutoSize = true;
            this.lblfrac1.Location = new System.Drawing.Point(54, 59);
            this.lblfrac1.Name = "lblfrac1";
            this.lblfrac1.Size = new System.Drawing.Size(39, 12);
            this.lblfrac1.TabIndex = 0;
            this.lblfrac1.Text = "분수 1";
            // 
            // lblj1
            // 
            this.lblj1.AutoSize = true;
            this.lblj1.Location = new System.Drawing.Point(144, 59);
            this.lblj1.Name = "lblj1";
            this.lblj1.Size = new System.Drawing.Size(29, 12);
            this.lblj1.TabIndex = 1;
            this.lblj1.Text = "분자";
            // 
            // lblm1
            // 
            this.lblm1.AutoSize = true;
            this.lblm1.Location = new System.Drawing.Point(144, 106);
            this.lblm1.Name = "lblm1";
            this.lblm1.Size = new System.Drawing.Size(29, 12);
            this.lblm1.TabIndex = 2;
            this.lblm1.Text = "분모";
            // 
            // lblplus
            // 
            this.lblplus.AutoSize = true;
            this.lblplus.Location = new System.Drawing.Point(360, 79);
            this.lblplus.Name = "lblplus";
            this.lblplus.Size = new System.Drawing.Size(11, 12);
            this.lblplus.TabIndex = 3;
            this.lblplus.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "분수 2";
            // 
            // lblj2
            // 
            this.lblj2.AutoSize = true;
            this.lblj2.Location = new System.Drawing.Point(494, 59);
            this.lblj2.Name = "lblj2";
            this.lblj2.Size = new System.Drawing.Size(29, 12);
            this.lblj2.TabIndex = 5;
            this.lblj2.Text = "분자";
            // 
            // lblm2
            // 
            this.lblm2.AutoSize = true;
            this.lblm2.Location = new System.Drawing.Point(494, 106);
            this.lblm2.Name = "lblm2";
            this.lblm2.Size = new System.Drawing.Size(29, 12);
            this.lblm2.TabIndex = 6;
            this.lblm2.Text = "분모";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(190, 193);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(29, 12);
            this.lblres.TabIndex = 7;
            this.lblres.Text = "결과";
            // 
            // lblrj
            // 
            this.lblrj.AutoSize = true;
            this.lblrj.Location = new System.Drawing.Point(273, 193);
            this.lblrj.Name = "lblrj";
            this.lblrj.Size = new System.Drawing.Size(29, 12);
            this.lblrj.TabIndex = 8;
            this.lblrj.Text = "분자";
            // 
            // lblrm
            // 
            this.lblrm.AutoSize = true;
            this.lblrm.Location = new System.Drawing.Point(273, 236);
            this.lblrm.Name = "lblrm";
            this.lblrm.Size = new System.Drawing.Size(29, 12);
            this.lblrm.TabIndex = 9;
            this.lblrm.Text = "분모";
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(98, 203);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(37, 23);
            this.btnres.TabIndex = 10;
            this.btnres.Text = "=";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // txtj1
            // 
            this.txtj1.Location = new System.Drawing.Point(192, 56);
            this.txtj1.Name = "txtj1";
            this.txtj1.Size = new System.Drawing.Size(100, 21);
            this.txtj1.TabIndex = 11;
            // 
            // txtm1
            // 
            this.txtm1.Location = new System.Drawing.Point(192, 103);
            this.txtm1.Name = "txtm1";
            this.txtm1.Size = new System.Drawing.Size(100, 21);
            this.txtm1.TabIndex = 12;
            // 
            // txtj2
            // 
            this.txtj2.Location = new System.Drawing.Point(542, 56);
            this.txtj2.Name = "txtj2";
            this.txtj2.Size = new System.Drawing.Size(100, 21);
            this.txtj2.TabIndex = 13;
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(542, 103);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(100, 21);
            this.txtm2.TabIndex = 14;
            // 
            // txtrj
            // 
            this.txtrj.Location = new System.Drawing.Point(323, 190);
            this.txtrj.Name = "txtrj";
            this.txtrj.Size = new System.Drawing.Size(100, 21);
            this.txtrj.TabIndex = 15;
            // 
            // txtrm
            // 
            this.txtrm.Location = new System.Drawing.Point(323, 233);
            this.txtrm.Name = "txtrm";
            this.txtrm.Size = new System.Drawing.Size(100, 21);
            this.txtrm.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 313);
            this.Controls.Add(this.txtrm);
            this.Controls.Add(this.txtrj);
            this.Controls.Add(this.txtm2);
            this.Controls.Add(this.txtj2);
            this.Controls.Add(this.txtm1);
            this.Controls.Add(this.txtj1);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.lblrm);
            this.Controls.Add(this.lblrj);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblm2);
            this.Controls.Add(this.lblj2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblplus);
            this.Controls.Add(this.lblm1);
            this.Controls.Add(this.lblj1);
            this.Controls.Add(this.lblfrac1);
            this.Name = "Form1";
            this.Text = "분수 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrac1;
        private System.Windows.Forms.Label lblj1;
        private System.Windows.Forms.Label lblm1;
        private System.Windows.Forms.Label lblplus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblj2;
        private System.Windows.Forms.Label lblm2;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblrj;
        private System.Windows.Forms.Label lblrm;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.TextBox txtj1;
        private System.Windows.Forms.TextBox txtm1;
        private System.Windows.Forms.TextBox txtj2;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.TextBox txtrj;
        private System.Windows.Forms.TextBox txtrm;
    }
}

