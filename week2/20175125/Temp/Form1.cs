/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 섭씨 온도를 입력 받아 화씨온도로 변경, 출력하는 프로그램(명시적 형변환 사용)
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

namespace Temp//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int cel = Convert.ToInt32(txtc.Text);//섭씨온도를 나타내는 정수형 변수에 txtc로 입력받은 문자열을 정수로 변환 후 저장
            double fah = cel*(double)9/5+32;//cel에 저장된 섭씨온도로 화씨온도를 계산하여 실수형 변수인 fah에 저장
            //명시적 형변환을 사용하여 정수형으로 이뤄진 식을 계산
            txtf.Text = Convert.ToString(fah);//txtf텍스트박스에 fah에 저장된 화씨온도 출력
        }
    }
}
