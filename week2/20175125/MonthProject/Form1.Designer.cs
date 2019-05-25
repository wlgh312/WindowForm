namespace MonthProject
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
            this.txtmon = new System.Windows.Forms.TextBox();
            this.lblmon = new System.Windows.Forms.Label();
            this.btnres = new System.Windows.Forms.Button();
            this.lblday = new System.Windows.Forms.Label();
            this.txtday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmon
            // 
            this.txtmon.Location = new System.Drawing.Point(105, 51);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 21);
            this.txtmon.TabIndex = 0;
            // 
            // lblmon
            // 
            this.lblmon.AutoSize = true;
            this.lblmon.Location = new System.Drawing.Point(38, 54);
            this.lblmon.Name = "lblmon";
            this.lblmon.Size = new System.Drawing.Size(17, 12);
            this.lblmon.TabIndex = 1;
            this.lblmon.Text = "월";
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(105, 94);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(75, 23);
            this.btnres.TabIndex = 2;
            this.btnres.Text = "Excute";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(38, 153);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(17, 12);
            this.lblday.TabIndex = 4;
            this.lblday.Text = "일";
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(105, 150);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(178, 21);
            this.txtday.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 273);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.lblmon);
            this.Controls.Add(this.txtmon);
            this.Name = "Form1";
            this.Text = "월";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.Label lblmon;
        private System.Windows.Forms.Button btnres;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.TextBox txtday;
    }
}

