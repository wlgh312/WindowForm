/*
 20175125 김지호
 2019/3/14
 윈도우프로그래밍 week3
 프로그램 내용 : 두 정수를 비교해서 비교 결과를 출력하는 프로그램
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

namespace numint//이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnint_Click(object sender, EventArgs e)//btnint버튼 클릭 시 발생하는 이벤트 설정
        {
            int num1 = Convert.ToInt32(txtint1.Text);//txtint1에 입력한 문자열을 정수로 변환 후 num1변수에 저장
            int num2 = Convert.ToInt32(txtint2.Text);//txtint2에 입력한 문자열을 정수로 변환 후 num2변수에 저장
            if (num1 == num2)//입력받은 두 수가 같으면
            {
                txtres.Text = Convert.ToString(num1 + "=" + num2);//결과창에 두 수와 =출력
            }

            else if (num1 != num2)//입력받은 두 수가 다르면
            {
                int max = num1 > num2 ? num1 : num2;//num1과 num2를 비교해서 true면 num1을 max에 저장
                if (num1 == max)//만약 max에 저장된 값과 num1이 같으면
                {
                    txtres.Text = Convert.ToString(num1 + ">" + num2);//결과창에 num1이 더 크다고 출력
                }
                else if (num2 == max)//만약 max에 저장된 값과 num2가 같으면
                {
                    txtres.Text = Convert.ToString(num1 + "<" + num2);//결과창에 num2가 더 크다고 출력
                }

            }
        }

    }
}
