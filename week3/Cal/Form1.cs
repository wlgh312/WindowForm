/*
 20175125 김지호
 2019/3/14
 윈도우프로그래밍 week3
 프로그램 내용 : 분수 계산을 하는 프로그램(분모가 다를 경우 통분과 약분 수행)
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

namespace Cal//이름공간 선언 및 사용
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)//btnres버튼 클릭 시 발생하는 이벤트 설정
        {
            int numj1 = Convert.ToInt32(txtj1.Text);//txtj1텍스트박스로 입력받은 문자열을 정수로 변환 후 numj1변수에 저장
            int numm1 = Convert.ToInt32(txtm1.Text);//txtm1텍스트박스로 입력받은 문자열을 정수로 변환 후 numm1변수에 저장
            int numj2 = Convert.ToInt32(txtj2.Text);//txtj2텍스트박스로 입력받은 문자열을 정수로 변환 후 numj2변수에 저장
            int numm2 = Convert.ToInt32(txtm2.Text);//txtm2텍스트박스로 입력받은 문자열을 정수로 변환 후 numm2변수에 저장

            if (numm1 == numm2)//두 분수의 분모가 같으면
            {
                int resj = numj1 + numj2;//정수형 변수에 두 분수의 분자를 더해서 저장
                Flac(resj, numm1);//두 분수를 더한 값의 분자와 분모를 매개변수로 하는 함수를 호출하여 약분

            }
            else//두 분수의 분모가 다르면
            {
                //통분
                int testm = numm1 * numm2;//정수형 변수에 두 분수의 분모를 곱해서 저장
                int testj1 = numj1 * numm2;//정수형 변수에 첫번째 분수의 분자를 두번째 분자의 분모와 곱해서 저장
                int testj2 = numj2 * numm1;//정수형 변수에 두번째 분수의 분자를 첫번째 분자의 분모와 곱해서 저장
                int resj = testj1 + testj2;//계산한 두 분수의 분자를 더해서 정수형 변수에 저장
                Flac(resj, testm);//두 분수를 더한 값의 분자와 분모를 매개변수로 하는 함수를 호출하여 약분

            }
        }
        //약분
        public void Flac(int a, int b)//정수형 변수를 매개변수로 받는 메소드 선언 및 정의
        {
            int max = a > b ? a : b;//a와 b를 비교해서 a가 더 크면 max에 저장
            int min = a < b ? a : b;//a와 b를 비교해서 a가 더 작으면 min에 저장
            while (min != 0)//min이 0이 아니면 반복
            {
                int tmp = max % min;//임시변수에 max를 min으로 나눈 후 나머지 저장
                max = min;//max에 min저장
                min = tmp;//min에 임시변수값 저장
            }//반복문 종료
            txtresj.Text = Convert.ToString(a / max);//분자를 최대공약수로 나눈 값을 문자열로 변환하여 txtresj에 출력
            txtresm.Text = Convert.ToString(b / max);//분모를 최대공약수로 나눈 값을 문자열로 변환하여 txtresm에 출력
        }
    }
}
