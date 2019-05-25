namespace IntErrorProject
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
            this.lblint1 = new System.Windows.Forms.Label();
            this.lblint2 = new System.Windows.Forms.Label();
            this.txtint1 = new System.Windows.Forms.TextBox();
            this.txtint2 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.btnres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblint1
            // 
            this.lblint1.AutoSize = true;
            this.lblint1.Location = new System.Drawing.Point(74, 66);
            this.lblint1.Name = "lblint1";
            this.lblint1.Size = new System.Drawing.Size(86, 18);
            this.lblint1.TabIndex = 0;
            this.lblint1.Text = "정수 입력";
            // 
            // lblint2
            // 
            this.lblint2.AutoSize = true;
            this.lblint2.Location = new System.Drawing.Point(74, 135);
            this.lblint2.Name = "lblint2";
            this.lblint2.Size = new System.Drawing.Size(86, 18);
            this.lblint2.TabIndex = 1;
            this.lblint2.Text = "정수 입력";
            // 
            // txtint1
            // 
            this.txtint1.Location = new System.Drawing.Point(169, 63);
            this.txtint1.Name = "txtint1";
            this.txtint1.Size = new System.Drawing.Size(141, 28);
            this.txtint1.TabIndex = 2;
            // 
            // txtint2
            // 
            this.txtint2.Location = new System.Drawing.Point(169, 132);
            this.txtint2.Name = "txtint2";
            this.txtint2.Size = new System.Drawing.Size(141, 28);
            this.txtint2.TabIndex = 3;
            // 
            // txtres
            // 
            this.txtres.BackColor = System.Drawing.SystemColors.Control;
            this.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres.ForeColor = System.Drawing.Color.Black;
            this.txtres.Location = new System.Drawing.Point(127, 264);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(141, 21);
            this.txtres.TabIndex = 4;
            this.txtres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnres
            // 
            this.btnres.Location = new System.Drawing.Point(144, 196);
            this.btnres.Name = "btnres";
            this.btnres.Size = new System.Drawing.Size(105, 42);
            this.btnres.TabIndex = 5;
            this.btnres.Text = "비교하기";
            this.btnres.UseVisualStyleBackColor = true;
            this.btnres.Click += new System.EventHandler(this.btnres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 393);
            this.Controls.Add(this.btnres);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtint2);
            this.Controls.Add(this.txtint1);
            this.Controls.Add(this.lblint2);
            this.Controls.Add(this.lblint1);
            this.Name = "Form1";
            this.Text = "크기 비교";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblint1;
        private System.Windows.Forms.Label lblint2;
        private System.Windows.Forms.TextBox txtint1;
        private System.Windows.Forms.TextBox txtint2;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Button btnres;
    }
}

