/*
20175125 김지호
2018-04-01
윈도우프로그래밍 5주차 과제
프로그램 내용 : 범용 클래스를 이용한 좌표변경 프로그램
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

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point<int> p;//정수형 객체 선언
        private void btnnew_Click(object sender, EventArgs e)//객체생성 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x값 텍스트박스로 입력받은 문자열을 변환 후 정수형 변수 x에 저장
            int y = Convert.ToInt32(txty.Text);//y값 텍스트박스로 입력받은 문자열을 변환 후 정수형 변수 y에 저장
            p = new Point<int>(x, y);//x와 y값을 매개변수로 받아 객체 생성
            txtinf.Text = p.ToString();//객체정보 창에 객체 내용 출력
        }

        private void btnmove_Click(object sender, EventArgs e)//좌표변경 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            //이동할 좌표의 거리
            int x = Convert.ToInt32(txtx.Text);//x값 텍스트박스로 입력받은 문자열을 변환 후 정수형 변수 x에 저장
            int y = Convert.ToInt32(txty.Text);//y값 텍스트박스로 입력받은 문자열을 변환 후 정수형 변수 y에 저장
            p.MoveTo(x, y);//메서드를 호출하여 객체 p의 좌표를 x,y만큼 이동
            txtinf.Text = p.ToString();//객체 정보창에 이동한 좌표의 결과 출력
        }
    }
}
