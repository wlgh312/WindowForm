/*
20175125 김지호
2018-04-01
윈도우프로그래밍 5주차 과제
프로그램 내용 : 상속 클래스를 사용하여 x,y,z좌표와 색깔을 생성하고 좌표변경, 이동하는 프로그램
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

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Colorable3DPoint c;//객체선언
        private void btnnew_Click(object sender, EventArgs e)//객체 생성 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x=Convert.ToInt32(txtx.Text);//x텍스트박스로 입력받은 문자열을 정수로 변환 후 x에 저장
            int y = Convert.ToInt32(txty.Text);//y텍스트박스로 입력받은 문자열을 정수로 변환 후 y에 저장
            int z = Convert.ToInt32(txtz.Text);//z텍스트박스로 입력받은 문자열을 정수로 변환 후 z에 저장
            string color = txtc.Text;//color텍스트박스로 입력받은 문자열 color에 저장
            c = new Colorable3DPoint(x, y, z, color);//입력받은 값들을 매개변수로 받아 객체생성
            txtresx.Text = Convert.ToString(x);//x좌표를 문자열로 변환후 출력
            txtresy.Text = Convert.ToString(y);//y좌표를 문자열로 변환후 출력
            txtresz.Text = Convert.ToString(z);//z좌표를 문자열로 변환후 출력
            txtresc.Text = color;//color출력
        }

        private void btnto_Click(object sender, EventArgs e)//변경버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x좌표 입력받기
            int y = Convert.ToInt32(txty.Text);//y좌표 입력받기
            int z = Convert.ToInt32(txtz.Text);//z좌표 입력받기
            c.MoveTo(x, y, z);//c객체에 저장되어 있던 좌표를 메서드를 호출하여 매개변수로 받은 x,y,z좌표로 변경
            txtresx.Text = Convert.ToString(x);//변경된 x좌표 출력
            txtresy.Text = Convert.ToString(y);//변경된 y좌표 출력
            txtresz.Text = Convert.ToString(z);//변경된 z좌표 출력
        }

        private void btnby_Click(object sender, EventArgs e)//이동버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x좌표 입력받기
            int y = Convert.ToInt32(txty.Text);//y좌표 입력받기
            int z = Convert.ToInt32(txtz.Text);//z좌표 입력받기
            c.MoveBy(x, y, z);//c객체에 저장되어 있던 좌표를 메서드를 호출하여 매개변수로 받은 x,y,z좌표만큼 이동
            txtresx.Text = Convert.ToString(c.GetX());//접근자호출해서 객체c의 x좌표 출력
            txtresy.Text = Convert.ToString(c.GetY());//접근자호출해서 객체c의 y좌표 출력
            txtresz.Text = Convert.ToString(c.GetZ());//접근자호출해서 객체c의 z좌표 출력
        }

        private void btnx_Click(object sender, EventArgs e)//첫번째 >>버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtx.Text);//x좌표 입력받기
            c.SetX(x);//설정자호출해서 객체 c의 x좌표 재설정
            txtresx.Text = Convert.ToString(x);//x좌표를 문자열로 변환하여 출력
        }

        private void btny_Click(object sender, EventArgs e)//두번째 >>버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int y = Convert.ToInt32(txty.Text);//y좌표 입력받기
            c.SetY(y);//설정자호출해서 객체 c의 y좌표 재설정
            txtresy.Text = Convert.ToString(y);//y좌표를 문자열로 변환하여 출력
        }

        private void btnz_Click(object sender, EventArgs e)//세번째 >>버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int z = Convert.ToInt32(txtz.Text);//z좌표 입력받기
            c.SetZ(z);//설정자호출해서 객체 c의 z좌표 재설정
            txtresz.Text = Convert.ToString(z);//z좌표를 문자열로 변환하여 출력
        }

        private void btnc_Click(object sender, EventArgs e)//네번째 >>버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            string color = txtc.Text;//color 입력받기
            c.SetColor(color);//설정자호출해서 객체 c의 color 재설정
            txtresc.Text = color;//color 출력
        }
    }
}
