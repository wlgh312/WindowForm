/*
 20175125 김지호
 2019-04-16
 윈도우프로그래밍 week7 과제
 프로그램 내용 : 텍스트 박스에 내용이 있으면 종료여부를 확인하는 메세지 창을 출력 후 종료하는 프로그램
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

namespace MemoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnexit_Click(object sender ,EventArgs e)//종료 버튼을 눌렀을 때 발생하는 이벤트 설정
        {

            Close();//Close메서드 호출하여 윈도우 폼 종료
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//윈도우 폼이 종료되기전에 발생하는 이벤트 설정
        {
            if (DialogResult.No == MessageBox.Show("텍스트 박스에 내용이 있습니다. 종료하시겠습니까?", "알림", MessageBoxButtons.YesNo))//텍스트 박스에 내용이 있으면 종료 여부 확인하는 메세지 박스 띄움
            {
                e.Cancel = true;//예를 선택하면 종료
            }
        }
    }
}
