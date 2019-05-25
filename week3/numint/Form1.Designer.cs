namespace numint
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
            this.btnint = new System.Windows.Forms.Button();
            this.lblint1 = new System.Windows.Forms.Label();
            this.lblint2 = new System.Windows.Forms.Label();
            this.txtint1 = new System.Windows.Forms.TextBox();
            this.txtint2 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnint
            // 
            this.btnint.Location = new System.Drawing.Point(150, 198);
            this.btnint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(107, 34);
            this.btnint.TabIndex = 0;
            this.btnint.Text = "비교하기";
            this.btnint.UseVisualStyleBackColor = true;
            this.btnint.Click += new System.EventHandler(this.btnint_Click);
            // 
            // lblint1
            // 
            this.lblint1.AutoSize = true;
            this.lblint1.Location = new System.Drawing.Point(86, 80);
            this.lblint1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblint1.Name = "lblint1";
            this.lblint1.Size = new System.Drawing.Size(86, 18);
            this.lblint1.TabIndex = 1;
            this.lblint1.Text = "정수 입력";
            // 
            // lblint2
            // 
            this.lblint2.AutoSize = true;
            this.lblint2.Location = new System.Drawing.Point(86, 132);
            this.lblint2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblint2.Name = "lblint2";
            this.lblint2.Size = new System.Drawing.Size(86, 18);
            this.lblint2.TabIndex = 2;
            this.lblint2.Text = "정수 입력";
            // 
            // txtint1
            // 
            this.txtint1.Location = new System.Drawing.Point(176, 75);
            this.txtint1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtint1.Name = "txtint1";
            this.txtint1.Size = new System.Drawing.Size(141, 28);
            this.txtint1.TabIndex = 3;
            // 
            // txtint2
            // 
            this.txtint2.Location = new System.Drawing.Point(176, 128);
            this.txtint2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtint2.Name = "txtint2";
            this.txtint2.Size = new System.Drawing.Size(141, 28);
            this.txtint2.TabIndex = 4;
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(131, 274);
            this.txtres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(141, 28);
            this.txtres.TabIndex = 5;
            this.txtres.Click += new System.EventHandler(this.btnint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 423);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtint2);
            this.Controls.Add(this.txtint1);
            this.Controls.Add(this.lblint2);
            this.Controls.Add(this.lblint1);
            this.Controls.Add(this.btnint);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "크기 비교";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnint;
        private System.Windows.Forms.Label lblint1;
        private System.Windows.Forms.Label lblint2;
        private System.Windows.Forms.TextBox txtint1;
        private System.Windows.Forms.TextBox txtint2;
        private System.Windows.Forms.TextBox txtres;
    }
}

