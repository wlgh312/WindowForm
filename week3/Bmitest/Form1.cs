/*
 20175125 김지호
 2019/3/14
 윈도우프로그래밍 week3
 프로그램 내용 : 비만도를 계산하는 프로그램
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

namespace Bmitest//이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)//btnok클릭 시 발생하는 이벤트 설정
        {
            int cm = Convert.ToInt32(txtcm.Text);//txtcm텍스트박스에서 입력받은 키 문자열을 정수로 변환 후 cm에 저장
            int kg = Convert.ToInt32(txtkg.Text);//txtkg텍스트박스에서 입력받은 몸무게 문자열을 정수로 변환 후 kg에 저장

            double pkg = (cm - 100) * 0.9;//표준체중 계산 후 실수형 변수인 pkg에 저장
            double bmi = ((kg - pkg) / pkg )* 100;//비만지수 계산 후 실수형 변수인 bmi에 저장

            txtpkg.Text = Convert.ToString(pkg);//표준체중을 문자열로 변환 후 txtpkg에 출력
            txtbmi.Text = Convert.ToString(bmi);//비만지수를 문자열로 변환 후 txtbmi에 출력

            if (bmi < 20)//만약 비만지수가 20미만이면
            {
                txtfat.Text = Convert.ToString("정상");//결과창에 정상출력
            }
            else if(bmi>=20 && bmi < 30)//만약 비만지수가 20이상 30미만이면
            {
                txtfat.Text = Convert.ToString("경도비만");//결과창에 경도비만 출력
            }
            else if (bmi >= 30 && bmi < 50)//만약 비만지수가 30이상 50미만이면
            {
                txtfat.Text = Convert.ToString("중도비만");//결과창에 중도비만 출력
            }
            else if (bmi >= 50)//만약 비만지수가 50이상이면
            {
                txtfat.Text = Convert.ToString("고도비만");//결과창에 고도비만 출력
            }
        }
    }
}
