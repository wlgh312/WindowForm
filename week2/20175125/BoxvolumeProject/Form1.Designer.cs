namespace BoxvolumeProject
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.lblLegnth = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblheight = new System.Windows.Forms.Label();
            this.btncir = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(41, 37);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(29, 12);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "너비";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(76, 34);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 21);
            this.tbWidth.TabIndex = 1;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(76, 78);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 21);
            this.tbLength.TabIndex = 3;
            // 
            // lblLegnth
            // 
            this.lblLegnth.AutoSize = true;
            this.lblLegnth.Location = new System.Drawing.Point(41, 81);
            this.lblLegnth.Name = "lblLegnth";
            this.lblLegnth.Size = new System.Drawing.Size(29, 12);
            this.lblLegnth.TabIndex = 2;
            this.lblLegnth.Text = "길이";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(76, 126);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(100, 21);
            this.tbHeight.TabIndex = 5;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Location = new System.Drawing.Point(41, 129);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(29, 12);
            this.lblheight.TabIndex = 4;
            this.lblheight.Text = "높이";
            // 
            // btncir
            // 
            this.btncir.BackColor = System.Drawing.SystemColors.Control;
            this.btncir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncir.Location = new System.Drawing.Point(248, 126);
            this.btncir.Name = "btncir";
            this.btncir.Size = new System.Drawing.Size(75, 23);
            this.btncir.TabIndex = 6;
            this.btncir.Text = "계산하기";
            this.btncir.UseVisualStyleBackColor = false;
            this.btncir.Click += new System.EventHandler(this.btncir_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(340, 128);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 21);
            this.txtresult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 213);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btncir);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lblLegnth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lblWidth);
            this.Name = "Form1";
            this.Text = "박스부피구하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Label lblLegnth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.Button btncir;
        private System.Windows.Forms.TextBox txtresult;
    }
}

