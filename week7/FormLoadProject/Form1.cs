/*
 20175125 김지호
 2019-04-16
 윈도우프로그래밍 week7 과제
 프로그램 내용 : 윈도우 폼이 열려 있을 때 키보드 또는 마우스 상태를 출력하는 프로그램
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

namespace FormLoadProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)//윈도우 폼위에서 커서가 움직일 때 발생하는 이벤트 설정
        {
            lblOut.Text = "마우스위치 : x = " + e.X + ", y = " + e.Y;//윈도우 폼에서의 커서위치를 라벨에 출력
        }

        private void Form1_Load(object sender, EventArgs e)//윈도우 폼이 열릴 때 발생하는 이벤트 설정
        {
            string msg = "Form Size : Width = " + this.Size.Width + ", Height = " + this.Size.Height;//폼의 크기를 나타내는 문자열
            MessageBox.Show(msg, "FormLoad Event");//메세지 박스에서 폼의 크기 출력
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)//마우스 클릭시 발생하는 이벤트 설정
        {
            MessageBox.Show("버튼 : " + e.Button.ToString(), "MouseClick Event");//메세지 박스에서 클릭된 마우스 버튼 출력
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)//키보드 클릭시 발생하는 이벤트 설정
        {
            MessageBox.Show("KeyChar : " + e.KeyChar, "KeyPress Event");//메세지 박스에서 눌린 키보드값 출력
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//키보드의 특수키가 눌렸을 때 발생하는 이벤트 설정
        {
            MessageBox.Show("KeyCode : " + e.KeyCode, "KeyDown Event");//메세지 박스에서 눌린 키보드의 특수키 출력
        }
    }
}
