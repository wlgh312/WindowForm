namespace Project3
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblaut = new System.Windows.Forms.Label();
            this.lblpage = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblpub = new System.Windows.Forms.Label();
            this.lblinf = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtaut = new System.Windows.Forms.TextBox();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtpub = new System.Windows.Forms.TextBox();
            this.txtinf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(47, 43);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(68, 18);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "책 제목";
            // 
            // lblaut
            // 
            this.lblaut.AutoSize = true;
            this.lblaut.Location = new System.Drawing.Point(47, 91);
            this.lblaut.Name = "lblaut";
            this.lblaut.Size = new System.Drawing.Size(44, 18);
            this.lblaut.TabIndex = 1;
            this.lblaut.Text = "저자";
            // 
            // lblpage
            // 
            this.lblpage.AutoSize = true;
            this.lblpage.Location = new System.Drawing.Point(47, 143);
            this.lblpage.Name = "lblpage";
            this.lblpage.Size = new System.Drawing.Size(50, 18);
            this.lblpage.TabIndex = 2;
            this.lblpage.Text = "쪽 수";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(47, 191);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(158, 18);
            this.lblnum.TabIndex = 3;
            this.lblnum.Text = "국제 표준도서번호";
            // 
            // lblpub
            // 
            this.lblpub.AutoSize = true;
            this.lblpub.Location = new System.Drawing.Point(47, 238);
            this.lblpub.Name = "lblpub";
            this.lblpub.Size = new System.Drawing.Size(62, 18);
            this.lblpub.TabIndex = 4;
            this.lblpub.Text = "출판사";
            // 
            // lblinf
            // 
            this.lblinf.AutoSize = true;
            this.lblinf.Location = new System.Drawing.Point(47, 357);
            this.lblinf.Name = "lblinf";
            this.lblinf.Size = new System.Drawing.Size(68, 18);
            this.lblinf.TabIndex = 5;
            this.lblinf.Text = "책 정보";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(68, 284);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(150, 45);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "객체 생성";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(159, 40);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(263, 28);
            this.txttitle.TabIndex = 7;
            // 
            // txtaut
            // 
            this.txtaut.Location = new System.Drawing.Point(159, 88);
            this.txtaut.Name = "txtaut";
            this.txtaut.Size = new System.Drawing.Size(263, 28);
            this.txtaut.TabIndex = 8;
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(159, 140);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(263, 28);
            this.txtpage.TabIndex = 9;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(211, 188);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(211, 28);
            this.txtnum.TabIndex = 10;
            // 
            // txtpub
            // 
            this.txtpub.Location = new System.Drawing.Point(159, 235);
            this.txtpub.Name = "txtpub";
            this.txtpub.Size = new System.Drawing.Size(263, 28);
            this.txtpub.TabIndex = 11;
            // 
            // txtinf
            // 
            this.txtinf.Location = new System.Drawing.Point(132, 354);
            this.txtinf.Name = "txtinf";
            this.txtinf.Size = new System.Drawing.Size(391, 28);
            this.txtinf.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 417);
            this.Controls.Add(this.txtinf);
            this.Controls.Add(this.txtpub);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.txtaut);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblinf);
            this.Controls.Add(this.lblpub);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblpage);
            this.Controls.Add(this.lblaut);
            this.Controls.Add(this.lbltitle);
            this.Name = "Form1";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblaut;
        private System.Windows.Forms.Label lblpage;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblpub;
        private System.Windows.Forms.Label lblinf;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtaut;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtpub;
        private System.Windows.Forms.TextBox txtinf;
    }
}

