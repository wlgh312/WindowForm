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
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblinf = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnmove = new System.Windows.Forms.Button();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtinf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(45, 41);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(37, 18);
            this.lblx.TabIndex = 0;
            this.lblx.Text = "X값";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(45, 103);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(37, 18);
            this.lbly.TabIndex = 1;
            this.lbly.Text = "Y값";
            // 
            // lblinf
            // 
            this.lblinf.AutoSize = true;
            this.lblinf.Location = new System.Drawing.Point(45, 228);
            this.lblinf.Name = "lblinf";
            this.lblinf.Size = new System.Drawing.Size(80, 18);
            this.lblinf.TabIndex = 2;
            this.lblinf.Text = "객체정보";
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(59, 154);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(95, 35);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "객체생성";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnmove
            // 
            this.btnmove.Location = new System.Drawing.Point(176, 154);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(95, 35);
            this.btnmove.TabIndex = 4;
            this.btnmove.Text = "좌표변경";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(176, 38);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(173, 28);
            this.txtx.TabIndex = 5;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(176, 100);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(173, 28);
            this.txty.TabIndex = 6;
            // 
            // txtinf
            // 
            this.txtinf.Location = new System.Drawing.Point(138, 225);
            this.txtinf.Name = "txtinf";
            this.txtinf.Size = new System.Drawing.Size(342, 28);
            this.txtinf.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 307);
            this.Controls.Add(this.txtinf);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.lblinf);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Name = "Form1";
            this.Text = "Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblinf;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtinf;
    }
}

