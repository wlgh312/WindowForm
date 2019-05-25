namespace ArrProject
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
            this.txtarr = new System.Windows.Forms.TextBox();
            this.btnexc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtarr
            // 
            this.txtarr.Location = new System.Drawing.Point(69, 111);
            this.txtarr.Name = "txtarr";
            this.txtarr.Size = new System.Drawing.Size(319, 21);
            this.txtarr.TabIndex = 0;
            // 
            // btnexc
            // 
            this.btnexc.Location = new System.Drawing.Point(179, 59);
            this.btnexc.Name = "btnexc";
            this.btnexc.Size = new System.Drawing.Size(75, 23);
            this.btnexc.TabIndex = 1;
            this.btnexc.Text = "Excute";
            this.btnexc.UseVisualStyleBackColor = true;
            this.btnexc.Click += new System.EventHandler(this.btnexc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 189);
            this.Controls.Add(this.btnexc);
            this.Controls.Add(this.txtarr);
            this.Name = "Form1";
            this.Text = "배열 출력";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtarr;
        private System.Windows.Forms.Button btnexc;
    }
}

