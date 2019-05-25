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
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblcall = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtcall = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(62, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "이름";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(62, 83);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(44, 18);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "나이";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(62, 126);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(44, 18);
            this.lblcomp.TabIndex = 2;
            this.lblcomp.Text = "직장";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(62, 169);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(62, 18);
            this.lblphone.TabIndex = 3;
            this.lblphone.Text = "휴대폰";
            // 
            // lblcall
            // 
            this.lblcall.AutoSize = true;
            this.lblcall.Location = new System.Drawing.Point(62, 212);
            this.lblcall.Name = "lblcall";
            this.lblcall.Size = new System.Drawing.Size(44, 18);
            this.lblcall.TabIndex = 4;
            this.lblcall.Text = "전화";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(62, 258);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(44, 18);
            this.lblmail.TabIndex = 5;
            this.lblmail.Text = "메일";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(152, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(139, 28);
            this.txtname.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(152, 80);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(96, 28);
            this.txtage.TabIndex = 7;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(152, 123);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(269, 28);
            this.txtcomp.TabIndex = 8;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(152, 166);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(224, 28);
            this.txtphone.TabIndex = 9;
            // 
            // txtcall
            // 
            this.txtcall.Location = new System.Drawing.Point(152, 209);
            this.txtcall.Name = "txtcall";
            this.txtcall.Size = new System.Drawing.Size(224, 28);
            this.txtcall.TabIndex = 10;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(152, 255);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(269, 28);
            this.txtmail.TabIndex = 11;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(65, 371);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(625, 28);
            this.txtres.TabIndex = 12;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(65, 306);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(95, 39);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "출력";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(511, 42);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(179, 33);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "객체생성";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtcall);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblcall);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "연락처";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblcall;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtcall;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnnew;
    }
}

