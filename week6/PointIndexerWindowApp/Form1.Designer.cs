namespace PointIndexerWindowApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnmove = new System.Windows.Forms.Button();
            this.txtres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "X값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "X값";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(113, 30);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(165, 28);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(113, 85);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(165, 28);
            this.txtY.TabIndex = 3;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(49, 141);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(103, 34);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "객체생성";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(49, 197);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(103, 30);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "정보출력";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnmove
            // 
            this.btnmove.Location = new System.Drawing.Point(161, 197);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(102, 30);
            this.btnmove.TabIndex = 6;
            this.btnmove.Text = "모두 이동";
            this.btnmove.UseVisualStyleBackColor = true;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(100, 243);
            this.txtres.Multiline = true;
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(321, 235);
            this.txtres.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 504);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.btnmove);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.TextBox txtres;
    }
}

