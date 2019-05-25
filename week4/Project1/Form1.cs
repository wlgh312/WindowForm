/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 분수 계산이 가능하도록 클래스를 이용하여 만든 프로그램
*/

//지정된 네임스페이스 사용
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)//=버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int numj1 = Convert.ToInt32(txtj1.Text);//txtj1텍스트박스로 입력받은 문자열을 정수로 변환 후 numj1변수에 저장
            int numm1 = Convert.ToInt32(txtm1.Text);//txtm1텍스트박스로 입력받은 문자열을 정수로 변환 후 numm1변수에 저장
            int numj2 = Convert.ToInt32(txtj2.Text);//txtj2텍스트박스로 입력받은 문자열을 정수로 변환 후 numj2변수에 저장
            int numm2 = Convert.ToInt32(txtm2.Text);//txtm2텍스트박스로 입력받은 문자열을 정수로 변환 후 numm2변수에 저장

            Fraction f1 = new Fraction(numj1, numm1);//첫 번째 분자와 분모를 받아 분수 객체 생성
            Fraction f2 = new Fraction(numj2, numm2);//두번째 분자와 분모를 받아 다른 분수 객체 생성
            Fraction f3 = f1.Add(f2);//메서드 호출하여 두 분수를 더해 새로운 분수 객체 생성
            txtrj.Text = f3.GetFj() + "";//계산된 분수의 분자 출력
            txtrm.Text = f3.GetFm() + "";//계산된 분수의 분모 출력
        }
    }
}
