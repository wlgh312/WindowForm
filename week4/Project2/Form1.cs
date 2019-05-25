/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 좌표객체생성, 좌표변경, 좌표이동하여 결과를 출력하는 프로그램
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

namespace Project2//네임스페이스 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point p;//객체 선언
        private void btnnew_Click(object sender, EventArgs e)//객체생성 버튼은 클릭했을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x좌표 입력받기
            int y = Convert.ToInt32(txty.Text);//y좌표 입력받기

            p = new Point(x, y);//좌표객체 생성
            txtres.Text = Convert.ToString(p.ToString());//결과창에 객체생성 결과 출력
        }

        private void btnxyz_Click(object sender, EventArgs e)//좌표변경 버튼을 클릭했을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//변경할 x좌표 입력받기
            int y = Convert.ToInt32(txty.Text);//변경할 y좌표 입력받기

            p.MoveTo(x, y);//매개변수로 받은 좌표로 변경
            txtres.Text = Convert.ToString(p.ToString());//변경한 좌표 결과 출력
        }

        private void btnmove_Click(object sender, EventArgs e)//이동 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x좌표가 이동할 크기 입력받기
            int y = Convert.ToInt32(txty.Text);//y좌표가 이동할 크기 입력받기

            p.MoveBy(x, y);//매개변수로 받은 만큼 좌표 이동
            txtres.Text = Convert.ToString(p.ToString());//이동한 좌표 결과 출력
        }
    }
}
