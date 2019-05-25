namespace Temp
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblc = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtf = new System.Windows.Forms.TextBox();
            this.lblf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(67, 75);
            this.lblc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(44, 18);
            this.lblc.TabIndex = 1;
            this.lblc.Text = "섭씨";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(139, 70);
            this.txtc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(141, 28);
            this.txtc.TabIndex = 2;
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(139, 216);
            this.txtf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(141, 28);
            this.txtf.TabIndex = 4;
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Location = new System.Drawing.Point(67, 220);
            this.lblf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(44, 18);
            this.lblf.TabIndex = 3;
            this.lblf.Text = "화씨";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 392);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.lblf);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.Label lblf;
    }
}

