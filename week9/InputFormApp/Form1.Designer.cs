namespace InputFormApp
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnwoman = new System.Windows.Forms.RadioButton();
            this.rbtnman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxsing = new System.Windows.Forms.CheckBox();
            this.cboxgame = new System.Windows.Forms.CheckBox();
            this.cboxfish = new System.Windows.Forms.CheckBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "age";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(153, 50);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(180, 28);
            this.txtname.TabIndex = 3;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(153, 112);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(180, 28);
            this.txtage.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnwoman);
            this.groupBox1.Controls.Add(this.rbtnman);
            this.groupBox1.Location = new System.Drawing.Point(53, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(264, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gender";
            // 
            // rbtnwoman
            // 
            this.rbtnwoman.AutoSize = true;
            this.rbtnwoman.Location = new System.Drawing.Point(130, 30);
            this.rbtnwoman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnwoman.Name = "rbtnwoman";
            this.rbtnwoman.Size = new System.Drawing.Size(93, 22);
            this.rbtnwoman.TabIndex = 1;
            this.rbtnwoman.TabStop = true;
            this.rbtnwoman.Text = "woman";
            this.rbtnwoman.UseVisualStyleBackColor = true;
            // 
            // rbtnman
            // 
            this.rbtnman.AutoSize = true;
            this.rbtnman.Location = new System.Drawing.Point(21, 30);
            this.rbtnman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnman.Name = "rbtnman";
            this.rbtnman.Size = new System.Drawing.Size(68, 22);
            this.rbtnman.TabIndex = 0;
            this.rbtnman.TabStop = true;
            this.rbtnman.Text = "man";
            this.rbtnman.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "birth";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(113, 284);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(90, 28);
            this.txtyear.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "/";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(237, 284);
            this.txtmonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(37, 28);
            this.txtmonth.TabIndex = 9;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(309, 284);
            this.txtday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(37, 28);
            this.txtday.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "/";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxsing);
            this.groupBox2.Controls.Add(this.cboxgame);
            this.groupBox2.Controls.Add(this.cboxfish);
            this.groupBox2.Location = new System.Drawing.Point(53, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "favorite";
            // 
            // cboxsing
            // 
            this.cboxsing.AutoSize = true;
            this.cboxsing.Location = new System.Drawing.Point(231, 30);
            this.cboxsing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxsing.Name = "cboxsing";
            this.cboxsing.Size = new System.Drawing.Size(90, 22);
            this.cboxsing.TabIndex = 2;
            this.cboxsing.Text = "singing";
            this.cboxsing.UseVisualStyleBackColor = true;
            // 
            // cboxgame
            // 
            this.cboxgame.AutoSize = true;
            this.cboxgame.Location = new System.Drawing.Point(116, 30);
            this.cboxgame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxgame.Name = "cboxgame";
            this.cboxgame.Size = new System.Drawing.Size(92, 22);
            this.cboxgame.TabIndex = 1;
            this.cboxgame.Text = "gaming";
            this.cboxgame.UseVisualStyleBackColor = true;
            // 
            // cboxfish
            // 
            this.cboxfish.AutoSize = true;
            this.cboxfish.Location = new System.Drawing.Point(9, 30);
            this.cboxfish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxfish.Name = "cboxfish";
            this.cboxfish.Size = new System.Drawing.Size(85, 22);
            this.cboxfish.TabIndex = 0;
            this.cboxfish.Text = "fishing";
            this.cboxfish.UseVisualStyleBackColor = true;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(169, 448);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(107, 34);
            this.btnsend.TabIndex = 12;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 518);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnwoman;
        private System.Windows.Forms.RadioButton rbtnman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.CheckBox cboxsing;
        private System.Windows.Forms.CheckBox cboxgame;
        private System.Windows.Forms.CheckBox cboxfish;
    }
}

