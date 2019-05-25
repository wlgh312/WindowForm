namespace Project2
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
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblz = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtz = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btnx = new System.Windows.Forms.Button();
            this.btny = new System.Windows.Forms.Button();
            this.btnz = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.lblresx = new System.Windows.Forms.Label();
            this.lblresy = new System.Windows.Forms.Label();
            this.lblresz = new System.Windows.Forms.Label();
            this.lblresc = new System.Windows.Forms.Label();
            this.txtresc = new System.Windows.Forms.TextBox();
            this.txtresz = new System.Windows.Forms.TextBox();
            this.txtresy = new System.Windows.Forms.TextBox();
            this.txtresx = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnto = new System.Windows.Forms.Button();
            this.btnby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "좌표 생성 및 변경";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(39, 99);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(31, 18);
            this.lblx.TabIndex = 1;
            this.lblx.Text = "X :";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(39, 163);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(31, 18);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "Y :";
            // 
            // lblz
            // 
            this.lblz.AutoSize = true;
            this.lblz.Location = new System.Drawing.Point(39, 226);
            this.lblz.Name = "lblz";
            this.lblz.Size = new System.Drawing.Size(31, 18);
            this.lblz.TabIndex = 3;
            this.lblz.Text = "Z :";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(36, 289);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(51, 18);
            this.lblc.TabIndex = 4;
            this.lblc.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "현재 좌표 정보";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(137, 96);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(154, 28);
            this.txtx.TabIndex = 6;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(137, 160);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(154, 28);
            this.txty.TabIndex = 7;
            // 
            // txtz
            // 
            this.txtz.Location = new System.Drawing.Point(137, 223);
            this.txtz.Name = "txtz";
            this.txtz.Size = new System.Drawing.Size(154, 28);
            this.txtz.TabIndex = 8;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(137, 286);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(154, 28);
            this.txtc.TabIndex = 9;
            // 
            // btnx
            // 
            this.btnx.Location = new System.Drawing.Point(328, 94);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(75, 30);
            this.btnx.TabIndex = 10;
            this.btnx.Text = ">>";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btny
            // 
            this.btny.Location = new System.Drawing.Point(328, 160);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(75, 30);
            this.btny.TabIndex = 11;
            this.btny.Text = ">>";
            this.btny.UseVisualStyleBackColor = true;
            this.btny.Click += new System.EventHandler(this.btny_Click);
            // 
            // btnz
            // 
            this.btnz.Location = new System.Drawing.Point(328, 221);
            this.btnz.Name = "btnz";
            this.btnz.Size = new System.Drawing.Size(75, 30);
            this.btnz.TabIndex = 12;
            this.btnz.Text = ">>";
            this.btnz.UseVisualStyleBackColor = true;
            this.btnz.Click += new System.EventHandler(this.btnz_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(328, 286);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 30);
            this.btnc.TabIndex = 13;
            this.btnc.Text = ">>";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // lblresx
            // 
            this.lblresx.AutoSize = true;
            this.lblresx.Location = new System.Drawing.Point(432, 99);
            this.lblresx.Name = "lblresx";
            this.lblresx.Size = new System.Drawing.Size(31, 18);
            this.lblresx.TabIndex = 14;
            this.lblresx.Text = "X :";
            // 
            // lblresy
            // 
            this.lblresy.AutoSize = true;
            this.lblresy.Location = new System.Drawing.Point(432, 163);
            this.lblresy.Name = "lblresy";
            this.lblresy.Size = new System.Drawing.Size(31, 18);
            this.lblresy.TabIndex = 15;
            this.lblresy.Text = "Y :";
            // 
            // lblresz
            // 
            this.lblresz.AutoSize = true;
            this.lblresz.Location = new System.Drawing.Point(432, 226);
            this.lblresz.Name = "lblresz";
            this.lblresz.Size = new System.Drawing.Size(31, 18);
            this.lblresz.TabIndex = 16;
            this.lblresz.Text = "Z :";
            // 
            // lblresc
            // 
            this.lblresc.AutoSize = true;
            this.lblresc.Location = new System.Drawing.Point(432, 292);
            this.lblresc.Name = "lblresc";
            this.lblresc.Size = new System.Drawing.Size(51, 18);
            this.lblresc.TabIndex = 17;
            this.lblresc.Text = "Color";
            // 
            // txtresc
            // 
            this.txtresc.Location = new System.Drawing.Point(503, 284);
            this.txtresc.Name = "txtresc";
            this.txtresc.Size = new System.Drawing.Size(154, 28);
            this.txtresc.TabIndex = 21;
            // 
            // txtresz
            // 
            this.txtresz.Location = new System.Drawing.Point(503, 221);
            this.txtresz.Name = "txtresz";
            this.txtresz.Size = new System.Drawing.Size(154, 28);
            this.txtresz.TabIndex = 20;
            // 
            // txtresy
            // 
            this.txtresy.Location = new System.Drawing.Point(503, 158);
            this.txtresy.Name = "txtresy";
            this.txtresy.Size = new System.Drawing.Size(154, 28);
            this.txtresy.TabIndex = 19;
            // 
            // txtresx
            // 
            this.txtresx.Location = new System.Drawing.Point(503, 94);
            this.txtresx.Name = "txtresx";
            this.txtresx.Size = new System.Drawing.Size(154, 28);
            this.txtresx.TabIndex = 18;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(59, 346);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(114, 36);
            this.btnnew.TabIndex = 22;
            this.btnnew.Text = "객체 생성";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnto
            // 
            this.btnto.Location = new System.Drawing.Point(213, 346);
            this.btnto.Name = "btnto";
            this.btnto.Size = new System.Drawing.Size(114, 36);
            this.btnto.TabIndex = 23;
            this.btnto.Text = "변경";
            this.btnto.UseVisualStyleBackColor = true;
            this.btnto.Click += new System.EventHandler(this.btnto_Click);
            // 
            // btnby
            // 
            this.btnby.Location = new System.Drawing.Point(372, 346);
            this.btnby.Name = "btnby";
            this.btnby.Size = new System.Drawing.Size(114, 36);
            this.btnby.TabIndex = 24;
            this.btnby.Text = "이동";
            this.btnby.UseVisualStyleBackColor = true;
            this.btnby.Click += new System.EventHandler(this.btnby_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 424);
            this.Controls.Add(this.btnby);
            this.Controls.Add(this.btnto);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtresc);
            this.Controls.Add(this.txtresz);
            this.Controls.Add(this.txtresy);
            this.Controls.Add(this.txtresx);
            this.Controls.Add(this.lblresc);
            this.Controls.Add(this.lblresz);
            this.Controls.Add(this.lblresy);
            this.Controls.Add(this.lblresx);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnz);
            this.Controls.Add(this.btny);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtz);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblz);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "좌표이동";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtz;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Button btnz;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Label lblresx;
        private System.Windows.Forms.Label lblresz;
        private System.Windows.Forms.Label lblresc;
        private System.Windows.Forms.TextBox txtresc;
        private System.Windows.Forms.TextBox txtresz;
        private System.Windows.Forms.TextBox txtresy;
        private System.Windows.Forms.TextBox txtresx;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnto;
        private System.Windows.Forms.Button btnby;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblresy;
    }
}

