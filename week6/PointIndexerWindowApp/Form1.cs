/*
 20175125 김지호
 2019-04-07
 윈도우프로그래밍 week6 과제
 프로그램 내용 : 인덱서를 이용해 10개의 좌표 객체를 저장, 이동하고 결과를 출력하는 프로그램
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

namespace PointIndexerWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void DelegateMove(int moveX, int moveY);//델리게이트 선언
        PointArray pArr = new PointArray();//인덱서 객체 선언 및 생성
        DelegateMove dto;//델리게이트 초기화
        private void btnnew_Click(object sender, EventArgs e)//객체생성 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int x = Convert.ToInt32(txtX.Text);//txtX창으로 입력받은 값을 정수형으로 변환하여 x좌표변수에 저장
            int y = Convert.ToInt32(txtY.Text);//txtY창으로 입력받은 값을 정수형으로 변환하여 y좌표변수에 저장
            Point p = new Point(x, y);//델리게이트 객체 생성, 객체를 매개변수로 받는 포인트 객체 선언 및 설정
            pArr[PointArray.count++] = p;//인덱서를 이용하여 count번째에 객체로 초기화 후 인덱스 증가
            dto += new DelegateMove(p.MoveTo);//델리게이트에 객체 p의 MoveTo메서드연결 
        }

        private void btnprint_Click(object sender, EventArgs e)//정보출력 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            for(int i=0; i<PointArray.count; i++)//인덱서의 count번째까지 반복
            {
                txtres.Text += pArr[i].ToString();//출력창에 pArr인덱서의 i번째를 메서드를 호출하여 문자열로 출력
            }
        }

        private void btnmove_Click(object sender, EventArgs e)//모두 이동 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int movex = Convert.ToInt32(txtX.Text);//이동할 x좌표값을 txtX텍스창으로 입력받아 정수형으로 변환 후 변수에 저장
            int movey = Convert.ToInt32(txtY.Text); //이동할 y좌표값을 txtY텍스창으로 입력받아 정수형으로 변환 후 변수에 저장      
            dto(movex, movey);//델리게이트호출하여 좌표이동
        }
    }
    
}
