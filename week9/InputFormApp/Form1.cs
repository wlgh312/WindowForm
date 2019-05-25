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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ReceivedForm df;//정보 출력 폼 객체 선언
        private void btnsend_Click(object sender, EventArgs e)//send버튼을 눌렀을 때 발생하는 이벤트 전달
        {
            string name = txtname.Text;//텍스트창에서 name을 입력받아 변수 name에 저장
            int age = Convert.ToInt32(txtage.Text);//age를 입력받아 정수로 변환 후 변수 age에 저장
            string gender="";//성별을 저장할 문자열 변수 초기화
            int year = Convert.ToInt32(txtyear.Text);//년도를 입력받아 정수로 변환 후 변수 year에 저장
            int month = Convert.ToInt32(txtmonth.Text);//월을 입력받아 정수로 변환 후 변수 month에 저장
            int day = Convert.ToInt32(txtday.Text);//날짜를 입력받아 정수로 변환 후 변수 day에 저장
            string favorite="";//favorite을 저장할 문자열 변수 초기화
            
            
            if (rbtnman.Checked == true)//man라디오버튼이 체크되어있으면
            {
                gender = "man";//성별 변수에 man저장
            }
            else if (rbtnwoman.Checked == true)//woman라디오버튼이 체크되어있으면
            {
                gender = "woman";//성별 변수에 woman저장
            }

            if (cboxfish.Checked == true)//fishing체크박스가 체크되어있으면
            {
                favorite += "fishing"+Environment.NewLine;//favorite변수에 fishing문자열 추가 저장
            }
            if (cboxgame.Checked == true)//gaming체크박스가 체크되어있으면
            {
                favorite += "gaming"+Environment.NewLine;//favorite변수에 gaming문자열 추가 저장
            }
            if (cboxsing.Checked == true)//singing체크박스가 체크되어있으면
            {
                favorite += "singing"+Environment.NewLine;//favorite변수에 singing문자열 추가 저장
            }
            Contact c = new Contact(name, age, gender, year, month, day, favorite);//저장 객체 선언 및 생성
            df = new ReceivedForm(c);//정보를 출력할 폼의 객체 및 생성
            df.Show();//출력할 폼 보여주기
        }
    }
}
