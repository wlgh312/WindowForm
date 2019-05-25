namespace Bmitest
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
            this.lblcm = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.lblpkg = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.lblfat = new System.Windows.Forms.Label();
            this.txtcm = new System.Windows.Forms.TextBox();
            this.txtkg = new System.Windows.Forms.TextBox();
            this.txtpkg = new System.Windows.Forms.TextBox();
            this.txtbmi = new System.Windows.Forms.TextBox();
            this.txtfat = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcm
            // 
            this.lblcm.AutoSize = true;
            this.lblcm.Location = new System.Drawing.Point(69, 51);
            this.lblcm.Name = "lblcm";
            this.lblcm.Size = new System.Drawing.Size(17, 12);
            this.lblcm.TabIndex = 0;
            this.lblcm.Text = "키";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(69, 93);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(41, 12);
            this.lblkg.TabIndex = 1;
            this.lblkg.Text = "몸무게";
            // 
            // lblpkg
            // 
            this.lblpkg.AutoSize = true;
            this.lblpkg.Location = new System.Drawing.Point(69, 201);
            this.lblpkg.Name = "lblpkg";
            this.lblpkg.Size = new System.Drawing.Size(53, 12);
            this.lblpkg.TabIndex = 2;
            this.lblpkg.Text = "표준체중";
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(69, 249);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(85, 12);
            this.lblbmi.TabIndex = 3;
            this.lblbmi.Text = "비만지수(BMI)";
            // 
            // lblfat
            // 
            this.lblfat.AutoSize = true;
            this.lblfat.Location = new System.Drawing.Point(69, 297);
            this.lblfat.Name = "lblfat";
            this.lblfat.Size = new System.Drawing.Size(41, 12);
            this.lblfat.TabIndex = 4;
            this.lblfat.Text = "비만도";
            // 
            // txtcm
            // 
            this.txtcm.Location = new System.Drawing.Point(131, 48);
            this.txtcm.Name = "txtcm";
            this.txtcm.Size = new System.Drawing.Size(139, 21);
            this.txtcm.TabIndex = 5;
            // 
            // txtkg
            // 
            this.txtkg.Location = new System.Drawing.Point(131, 90);
            this.txtkg.Name = "txtkg";
            this.txtkg.Size = new System.Drawing.Size(139, 21);
            this.txtkg.TabIndex = 6;
            // 
            // txtpkg
            // 
            this.txtpkg.Location = new System.Drawing.Point(131, 198);
            this.txtpkg.Name = "txtpkg";
            this.txtpkg.Size = new System.Drawing.Size(139, 21);
            this.txtpkg.TabIndex = 7;
            // 
            // txtbmi
            // 
            this.txtbmi.Location = new System.Drawing.Point(160, 246);
            this.txtbmi.Name = "txtbmi";
            this.txtbmi.Size = new System.Drawing.Size(110, 21);
            this.txtbmi.TabIndex = 8;
            // 
            // txtfat
            // 
            this.txtfat.Location = new System.Drawing.Point(131, 294);
            this.txtfat.Name = "txtfat";
            this.txtfat.Size = new System.Drawing.Size(139, 21);
            this.txtfat.TabIndex = 9;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(131, 128);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 47);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "확인";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 378);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtfat);
            this.Controls.Add(this.txtbmi);
            this.Controls.Add(this.txtpkg);
            this.Controls.Add(this.txtkg);
            this.Controls.Add(this.txtcm);
            this.Controls.Add(this.lblfat);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.lblpkg);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.lblcm);
            this.Name = "Form1";
            this.Text = "비만도 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcm;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Label lblpkg;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.Label lblfat;
        private System.Windows.Forms.TextBox txtcm;
        private System.Windows.Forms.TextBox txtkg;
        private System.Windows.Forms.TextBox txtpkg;
        private System.Windows.Forms.TextBox txtbmi;
        private System.Windows.Forms.TextBox txtfat;
        private System.Windows.Forms.Button btnok;
    }
}

