/*
 20175125 빅데이터 김지호
 2019-04-29
 윈도우프로그래밍 9주차 과제
 프로그램 내용 : 정보를 입력받아 윈도우 폼을 만드는 프로그램
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

namespace WindowFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnform_Click(object sender, EventArgs e)//Create Form버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            Subform s = new Subform();//서브폼 객체 선언 및 생성
            int x = Convert.ToInt32(txtx.Text);//폼의 위치 중 x값 입력받아 정수로 변환 후 변수x에 저장
            int y = Convert.ToInt32(txty.Text);//폼의 위치 중 y값 입력받아 정수로 변환 후 변수y에 저장
            int width = Convert.ToInt32(txtwidth.Text);//폼의 넓이 입력받아 정수로 변환 후 변수 width에 저장
            int height = Convert.ToInt32(txtheight.Text);//폼의 높이 입력받아 정수로 변환 후 변수 height에 저장
            double opacity = Convert.ToDouble(txtop.Text);//폼의 투명도를 입력방다 실수로 변환 후 변수 opacity에 저장
            s.Text = txttitle.Text;//폼의 제목을 입력받아 설정
            s.SetDesktopLocation(x, y);//폼의 위치설정
            s.SetDesktopBounds(x, y, width, height);//폼의 크기 설정
            if (rbtnnone.Checked==true)//none라디오 버튼이 클릭되었으면
            {
                s.FormBorderStyle=FormBorderStyle.None;//폼의 테두리 스타일을 none으로 설정
            }
            else if (rbtnsingle.Checked == true)//fixedsingle버튼이 클릭되었으면
            {
                s.FormBorderStyle = FormBorderStyle.FixedSingle;//폼의 테두리 스타일을 fixedsingle로 설정
            }
            else if (rbtntool.Checked == true)//fixedtoolwindow버튼이 클릭되었으면
            {
                s.FormBorderStyle = FormBorderStyle.FixedToolWindow;//폼의 테두리 스타일을 fixedtoolwindow로 설정
            }
            s.Opacity = opacity;//폼의 투명도 설정
            s.Show();//폼 보이기
           
        }

        
    }
}
