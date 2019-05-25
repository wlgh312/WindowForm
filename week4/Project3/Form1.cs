/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 연락처 객체를 생성하고 출력하는 프로그램
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

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contact c;//연락처 객체 선언
        private void btnnew_Click(object sender, EventArgs e)//객체생성 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            string name = txtname.Text;//이름 입력받기
            int age = Convert.ToInt32(txtage.Text);//나이를 입력받아 정수로 변환하여 저장
            string company = txtcomp.Text;//회사 입력받기
            string phone = txtphone.Text;//핸드폰 입력받기
            string call = txtcall.Text;//전화 입력받기
            string mail = txtmail.Text;//메일 입력받기

            c = new Contact(name, age, company, phone, call, mail);//연락처 객체 생성
        }

        private void btnok_Click(object sender, EventArgs e)//출력 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            txtres.Text = c.ToString();//메서드를 호출하여 객체 c에 들어있는 연락처 내용 출력
        }
    }
}
