namespace Circlevolume
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
            this.lblr = new System.Windows.Forms.Label();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnci = new System.Windows.Forms.Button();
            this.lblvol = new System.Windows.Forms.Label();
            this.txtvol = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.lbls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(54, 54);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(41, 12);
            this.lblr.TabIndex = 0;
            this.lblr.Text = "반지름";
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(147, 51);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 21);
            this.txtr.TabIndex = 1;
            // 
            // btnci
            // 
            this.btnci.Location = new System.Drawing.Point(172, 95);
            this.btnci.Name = "btnci";
            this.btnci.Size = new System.Drawing.Size(75, 23);
            this.btnci.TabIndex = 2;
            this.btnci.Text = "계산하기";
            this.btnci.UseVisualStyleBackColor = true;
            this.btnci.Click += new System.EventHandler(this.btnci_Click);
            // 
            // lblvol
            // 
            this.lblvol.AutoSize = true;
            this.lblvol.Location = new System.Drawing.Point(54, 144);
            this.lblvol.Name = "lblvol";
            this.lblvol.Size = new System.Drawing.Size(57, 12);
            this.lblvol.TabIndex = 3;
            this.lblvol.Text = "공의 부피";
            // 
            // txtvol
            // 
            this.txtvol.Location = new System.Drawing.Point(147, 141);
            this.txtvol.Name = "txtvol";
            this.txtvol.Size = new System.Drawing.Size(100, 21);
            this.txtvol.TabIndex = 4;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(147, 179);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 21);
            this.txts.TabIndex = 6;
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(54, 182);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(69, 12);
            this.lbls.TabIndex = 5;
            this.lbls.Text = "공의 표면적";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 282);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.lbls);
            this.Controls.Add(this.txtvol);
            this.Controls.Add(this.lblvol);
            this.Controls.Add(this.btnci);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.lblr);
            this.Name = "Form1";
            this.Text = "공의 부피 계산하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnci;
        private System.Windows.Forms.Label lblvol;
        private System.Windows.Forms.TextBox txtvol;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label lbls;
    }
}

