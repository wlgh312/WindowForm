/*
 20175125 김지호
 2019-04-16
 윈도우프로그래밍 week7 과제
 프로그램 내용 : 윈도우 폼에서 버튼에 따라 글씨가 이동하거나 크기가 바뀌는 프로그램
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

namespace HorseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnup_Click(object sender, EventArgs e)//위 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y - 1);//라벨이 현재 위치에서 y축의 위쪽 방향으로 1이동
        }

        private void btndown_Click(object sender, EventArgs e)//아래 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X, lblHorse.Location.Y + 1);//라벨이 현재 위치에서 y축의 아래쪽 방향으로 1이동
        }

        private void btnleft_Click(object sender, EventArgs e)//왼쪽 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y);//라벨이 현재 위치에서 x축의 왼쪽 방향으로 1이동
        }

        private void btnright_Click(object sender, EventArgs e)//오른쪽 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y);//라벨이 현재 위치에서 x축의 오른쪽 방향으로 1이동
        }

        private void btnsup_Click(object sender, EventArgs e)//크게 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Font = new Font("굴림", lblHorse.Font.Size + 1);//라벨의 폰트를 굴림으로 변경하고 폰트 크기 1증가
        }

        private void btnsdown_Click(object sender, EventArgs e)//작게 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Font = new Font("굴림", lblHorse.Font.Size - 1);//라벨의 폰트를 굴림으로 변경하고 폰트 크기 1감소
        }

        private void btnone_Click(object sender, EventArgs e)//왼쪽 위 대각선에 있는 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y - 1);//라벨이 현재 위치에서 x,y축의 왼쪽, 위쪽 방향으로 1이동
        }

        private void btntwo_Click(object sender, EventArgs e)//오른쪽 위 대각선에 있는 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y - 1);//라벨이 현재 위치에서 x,y축의 오른쪽, 위쪽 방향으로 1이동
        }

        private void btnthree_Click(object sender, EventArgs e)//왼쪽 아래 대각선에 있는 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X - 1, lblHorse.Location.Y + 1);//라벨이 현재 위치에서 x,y축의 왼쪽, 아래쪽 방향으로 1이동
        }

        private void btnfour_Click(object sender, EventArgs e)//오른쪽 아래 대각선에 있는 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            lblHorse.Location = new Point(lblHorse.Location.X + 1, lblHorse.Location.Y + 1);//라벨이 현재 위치에서 x,y축의 오른쪽, 아래쪽 방향으로 1이동
        }
    }
}
