namespace ForProject
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
            this.btnexc = new System.Windows.Forms.Button();
            this.lblfor = new System.Windows.Forms.Label();
            this.txtfor = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexc
            // 
            this.btnexc.Location = new System.Drawing.Point(96, 72);
            this.btnexc.Name = "btnexc";
            this.btnexc.Size = new System.Drawing.Size(75, 23);
            this.btnexc.TabIndex = 0;
            this.btnexc.Text = "Excute";
            this.btnexc.UseVisualStyleBackColor = true;
            this.btnexc.Click += new System.EventHandler(this.btnexc_Click);
            // 
            // lblfor
            // 
            this.lblfor.AutoSize = true;
            this.lblfor.Location = new System.Drawing.Point(35, 35);
            this.lblfor.Name = "lblfor";
            this.lblfor.Size = new System.Drawing.Size(17, 12);
            this.lblfor.TabIndex = 1;
            this.lblfor.Text = "단";
            // 
            // txtfor
            // 
            this.txtfor.Location = new System.Drawing.Point(71, 32);
            this.txtfor.Name = "txtfor";
            this.txtfor.Size = new System.Drawing.Size(100, 21);
            this.txtfor.TabIndex = 2;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(71, 122);
            this.txtres.Multiline = true;
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(143, 168);
            this.txtres.TabIndex = 3;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(35, 125);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(29, 12);
            this.lblres.TabIndex = 4;
            this.lblres.Text = "출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 327);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtfor);
            this.Controls.Add(this.lblfor);
            this.Controls.Add(this.btnexc);
            this.Name = "Form1";
            this.Text = "구구단 출력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexc;
        private System.Windows.Forms.Label lblfor;
        private System.Windows.Forms.TextBox txtfor;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label lblres;
    }
}

