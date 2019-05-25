/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 구구단 단수를 입력받아 for 문을 이용하여구구단을 출력하는 프로그램
 */

//리소스문
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForProject//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexc_Click(object sender, EventArgs e)//버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int num = Convert.ToInt32(txtfor.Text);//정수형 변수에 txtfor텍스트박스로 입력받은 문자열을 정수로 변환 후 저장
            for (int i = 1; i <= 9; i++)//구구단 단수만큼 반복
            {
                txtres.Text += Convert.ToString(num+"*"+i + "=" + (num * i));//txtres텍스트박스에 구구단 출력
                //줄바꿈은 Environment.NewLine으로 실행
                txtres.Text += Environment.NewLine;
            }
        }
    }
}
