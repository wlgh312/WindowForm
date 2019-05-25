/*
 20175125 김지호
 2019/3/14
 윈도우프로그래밍 week3
 프로그램 내용 : 두 정수의 계산까지만 수행 가능한 계산기 프로그램
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

namespace Calcul//이름공간 선언 및 사용
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pre;//첫번째 정수 변수
        int after;//두번째 정수 변수
        int cal;//연산을 구분 할 정수 변수

        private void btn7_Click(object sender, EventArgs e)//7을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "7";//결과창에 7을 추가 출력
        }

        private void btn8_Click(object sender, EventArgs e)//8을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "8";//결과창에 8을 추가 출력
        }

        private void btn9_Click(object sender, EventArgs e)//9를 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "9";//결과창에 9를 추가 출력
        }

        private void btn6_Click(object sender, EventArgs e)//6을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "6";//결과창에 6을 추가 출력
        }

        private void btn4_Click(object sender, EventArgs e)//4를 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "4";//결과창에 4를 추가 출력
        }

        private void btn5_Click(object sender, EventArgs e)//5를 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "5";//결과창에 5를 추가 출력
        }

        private void btn3_Click(object sender, EventArgs e)//3을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "3";//결과창에 3을 추가 출력
        }

        private void btn2_Click(object sender, EventArgs e)//2를 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "2";//결과창에 2를 추가 출력
        }

        private void btn1_Click(object sender, EventArgs e)//1을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "1";//결과창에 1을 추가 출력
        }

        private void btn0_Click(object sender, EventArgs e)//0을 눌렀을 때 발생하는 이벤트 설정
        {
            Calcul();//새로운 정수를 입력하는지 확인하는 함수호출
            txtres.Text += "0";//결과창에 0을 추가 출력
        }

        private void btndot_Click(object sender, EventArgs e)//.을 눌렀을 때 발생하는 이벤트 설정
        {
            if (txtres.Text.Contains("."))//만약 결과창에 .이 포함되어있다면
                return;
            else//결과창에 .이 없다면
                txtres.Text += ".";//결과창에 .을 추가 출력
        }

        private void btndiv_Click(object sender, EventArgs e)//"/"를 눌렀을 때 발생하는 이벤트 설정
        {
            pre = Convert.ToInt32(txtres.Text);//결과창에 입력되어있는 문자열을 정수로 변환하여 pre에 저장
            txtres.Text = "/";//결과창에 /출력
            cal = 1;//cal에 나누기를 의미하는 1저장
        }

        private void btnsub_Click(object sender, EventArgs e)//-를 눌렀을 때 발생하는 이벤트 설정
        {
            pre = Convert.ToInt32(txtres.Text);//결과창에 입력되어있는 문자열을 정수로 변환하여 pre에 저장
            txtres.Text = "-";//결과창에 -출력
            cal = 3;//cal에 빼기를 의미하는 3저장
        }

        private void btnmul_Click(object sender, EventArgs e)//*를 눌렀을 때 발생하는 이벤트 설정
        {
            pre = Convert.ToInt32(txtres.Text);//결과창에 입력되어있는 문자열을 정수로 변환하여 pre에 저장
            txtres.Text = "*";//결과창에 *출력
            cal = 2;//cal에 곱하기를 의미하는 2저장
        }

        private void btnsum_Click(object sender, EventArgs e)//+를 눌렀을 때 발생하는 이벤트 설정
        {
            pre = Convert.ToInt32(txtres.Text);//결과창에 입력되어있는 문자열을 정수로 변환하여 pre에 저장
            txtres.Text = "+";//결과창에 +출력
            cal = 4;//cal에 더하기를 의미하는 4저장
        }

        private void btnce_Click(object sender, EventArgs e)//CE를 눌렀을 때 발생하는 이벤트 설정
        {
            txtres.Text = Convert.ToString(pre);//먼저 입력했던 정수인 pre를 문자열로 변환하여 결과창에 출력
            if (cal == 1)//만약 cal이 1이면
            {
                txtres.Text += "/";//결과창에 / 추가 출력
            }
            else if (cal == 2)//만약 cal이 2이면
            {
                txtres.Text += "*";//결과창에 * 추가 출력
            }
            else if (cal == 3)//만약 cal이 3이면
            {
                txtres.Text += "-";//결과창에 - 추가 출력
            }
            else if (cal == 4)//만약 cal이 4이면
            {
                txtres.Text += "+";//결과창에 + 추가 출력
            }
        }

        private void btnc_Click(object sender, EventArgs e)//C를 눌렀을 때 발생하는 이벤트 설정
        {
            txtres.Text = Convert.ToString("");//결과창의 모든 내용 삭제
            pre = 0;//첫번째 정수 삭제
            after = 0;//두번째 정수 삭제
            cal = 0;//연산자 삭제
        }

        private void btnres_Click(object sender, EventArgs e)//=을 눌렀을 때 발생하는 이벤트 설정
        {
            after = Convert.ToInt32(txtres.Text);//결과창에 입력된 문자열을 정수로 변환하여 after에 저장
            if (cal == 1)//만약 cal이 1이면
            {
                txtres.Text = Convert.ToString((double)pre/(double)after);//pre를 after로 나눈 값을 문자열로 변환하여 출력
                //나머지까지 보이기위해 형변환 필요
            }
            else if (cal == 2)//만약 cal이 2이면
            {
                txtres.Text = Convert.ToString(pre * after);//pre와 after를 곱한 값을 문자열로 변환하여 출력
            }
            else if (cal == 3)//만약 cal이 3이면
            {
                txtres.Text = Convert.ToString(pre - after);//pre에서 after를 뺀 값을 문자열로 변환하여 출력
            }
            else if (cal == 4)//만약 cal이 4이면
            {
                txtres.Text = Convert.ToString(pre + after);//pre와 after를 더한 값을 문자열로 변환하여 출력
            }
        }

      
        public void Calcul()//두번째 정수를 입력받기 위해 결과창의 내용을 지우는 메서드
        {
            if (txtres.Text.Contains("/")){//만약 결과창이 /를 포함하고 있다면
                txtres.Text = Convert.ToString("");//결과창 내용 삭제
            }
            else if (txtres.Text.Contains("*"))//만약 결과창이 *를 포함하고 있다면
            {
                txtres.Text = Convert.ToString("");//결과창 내용 삭제
            }
            else if (txtres.Text.Contains("-"))//만약 결과창이 -를 포함하고 있다면
            {
                txtres.Text = Convert.ToString("");//결과창 내용 삭제
            }
            else if (txtres.Text.Contains("+"))//만약 결과창이 +를 포함하고 있다면
            {
                txtres.Text = Convert.ToString("");//결과창 내용 삭제
            }
            //숫자가 0부터 시작하면 0을 지우고 숫자입력
            else if (txtres.Text=="0")//만약 결과창 내용이 0뿐이라면
            {
                txtres.Text = Convert.ToString("");//결과창 내용 삭제
            }
        }
    }
}
