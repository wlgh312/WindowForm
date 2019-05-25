/*
 20175125 김지호
 2019-04-16
 윈도우프로그래밍 week7 과제
 프로그램 내용 : 두 정수를 입력받아 비교하여 결과를 출력하는 프로그램, 예외 발생 시 메세지박스 띄우기
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

namespace IntErrorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnres_Click(object sender, EventArgs e)//비교하기 버튼 눌렀을 때 발생하는 이벤트 설정
        {
            try {//예외검사
                int a = Convert.ToInt32(txtint1.Text);//첫번째 정수 입력받아 정수형으로 변환
                int b = Convert.ToInt32(txtint2.Text);//두번째 정수 입력받아 정수형으로 변환

                if (a > b)//a가 b보다 크면
                {
                    txtres.Text = Convert.ToString(a + ">" + b);//결과창에 두 정수 사이에 > 출력
                }
                else if (a < b)//a가 b보다 작으면
                {
                    txtres.Text = Convert.ToString(a + "<" + b);//결과창에 두 정수 사이에 < 출력
                }
                else if (a == b)//a와 b가 같으면
                {
                    txtres.Text = Convert.ToString(a + "=" + b);//결과창에 두 정수 사이에 = 출력
                }
            }catch(FormatException ee)//입력받은 데이터가 잘못된 경우 예외처리
            {
                MessageBox.Show("잘못 입력했습니다.","Error",MessageBoxButtons.OK);//error메세지박스 띄우기
            }
        }
    }
}
