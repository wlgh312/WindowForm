/*
 20175125 빅데이터 김지호
 2019-04-29
 윈도우프로그래밍 9주차 과제
 프로그램 내용 : 정보를 입력받아 윈도우 폼을 만드는 프로그램
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormApp
{
    public partial class Subform : Form
    {
        public Subform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//
        {
            Close();//폼 종료
        }
    }
}
