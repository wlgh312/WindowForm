namespace HorseProject
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
            this.btnup = new System.Windows.Forms.Button();
            this.lblHorse = new System.Windows.Forms.Label();
            this.btndown = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnsup = new System.Windows.Forms.Button();
            this.btnsdown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(183, 239);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(131, 38);
            this.btnup.TabIndex = 0;
            this.btnup.Text = "위";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Location = new System.Drawing.Point(195, 112);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(104, 18);
            this.lblHorse.TabIndex = 1;
            this.lblHorse.Text = "움직이는 말";
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(183, 322);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(131, 38);
            this.btndown.TabIndex = 2;
            this.btndown.Text = "아래";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(320, 281);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(131, 38);
            this.btnright.TabIndex = 3;
            this.btnright.Text = "오른쪽";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(46, 281);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(131, 38);
            this.btnleft.TabIndex = 4;
            this.btnleft.Text = "왼쪽";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btntwo
            // 
            this.btntwo.Location = new System.Drawing.Point(320, 239);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(46, 38);
            this.btntwo.TabIndex = 5;
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnfour
            // 
            this.btnfour.Location = new System.Drawing.Point(320, 322);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(46, 38);
            this.btnfour.TabIndex = 6;
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnone
            // 
            this.btnone.Location = new System.Drawing.Point(130, 239);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(47, 38);
            this.btnone.TabIndex = 7;
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnthree
            // 
            this.btnthree.Location = new System.Drawing.Point(130, 322);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(47, 38);
            this.btnthree.TabIndex = 8;
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnsup
            // 
            this.btnsup.Location = new System.Drawing.Point(487, 30);
            this.btnsup.Name = "btnsup";
            this.btnsup.Size = new System.Drawing.Size(86, 38);
            this.btnsup.TabIndex = 9;
            this.btnsup.Text = "크게";
            this.btnsup.UseVisualStyleBackColor = true;
            this.btnsup.Click += new System.EventHandler(this.btnsup_Click);
            // 
            // btnsdown
            // 
            this.btnsdown.Location = new System.Drawing.Point(487, 74);
            this.btnsdown.Name = "btnsdown";
            this.btnsdown.Size = new System.Drawing.Size(86, 38);
            this.btnsdown.TabIndex = 10;
            this.btnsdown.Text = "작게";
            this.btnsdown.UseVisualStyleBackColor = true;
            this.btnsdown.Click += new System.EventHandler(this.btnsdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 389);
            this.Controls.Add(this.btnsdown);
            this.Controls.Add(this.btnsup);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.btnup);
            this.Name = "Form1";
            this.Text = "위치 폰트크기 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btnsup;
        private System.Windows.Forms.Button btnsdown;
    }
}

