/*
 20175125 빅데이터 김지호
 2019-04-29
 윈도우프로그래밍 9주차 과제
 프로그램 내용 : 정보를 입력받아 다른 폼에 출력하는 프로그램
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

namespace InputFormApp
{
    public partial class ReceivedForm : Form
    {
        public ReceivedForm(Contact c)//자식폼의 생성자, 매개변수로 저장객체 전달받기
        {
            InitializeComponent();
            txtn.Text = c.name;//텍스트박스에 저장객체 중 이름 출력
            txta.Text = Convert.ToString(c.age);//텍스트박스에 저장객체 중 나이를 문자열로 변환한 후 출력
            txtg.Text = c.gender;//텍스트박스에 저장객체 중 성별 출력
            txty.Text = Convert.ToString(c.year);//텍스트박스에 저장객체 중 년도를 문자열로 변환한 후 출력
            txtm.Text = Convert.ToString(c.month);//텍스트박스에 저장객체 중 달을 문자열로 변환한 후 출력
            txtd.Text = Convert.ToString(c.day);//텍스트박스에 저장객체 중 날짜를 문자열로 변환한 후 출력
            txtf.Text = c.favorite;//텍스트박스에 저장객체 중 취미 출력
        }

        private void btnclose_Click(object sender, EventArgs e)//close버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            Close();//폼 종료
        }
    }
}
