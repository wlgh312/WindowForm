/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 달을 입력받아 해당 달의 요일수를 출력하는 프로그램(switch문 이용)
 */

//리소스문
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthProject//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)//버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int month = Convert.ToInt32(txtmon.Text);//달을 나타내는 정수형 변수에 txtmon텍스트박스로 입력받은 문자열을 정수로 변환 후 저장
            switch (month)//month의 값에 따른 조건문
            {
                case 1://1월일때
                case 3://3월일때
                case 5://5월일때
                case 7://7월일때
                case 8://8월일때
                case 10://10월일때
                case 12://12월일때
                    txtday.Text = Convert.ToString("31");//txtday텍스트박스에 31출력
                    break;//조건문 종료
                case 2://2월일때
                    txtday.Text = Convert.ToString("28");//txtday텍스트박스에 28출력
                    break;//조건문 종료
                case 4://4월일때
                case 6://6월일때
                case 9://9월일때
                case 11://11월일때
                    txtday.Text = Convert.ToString("30");//txtday텍스트박스에 30출력
                    break;//조건문 종료
                default://조건이 모두 충족되지 않을때
                    txtday.Text = Convert.ToString("Error!");//txtday텍스트박스에 Error!출력
                    break;//조건문 종료
            }
        }
    }
}
