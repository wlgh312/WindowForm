/*
 20175125 김지호
 2019/3/14
 윈도우프로그래밍 week3
 프로그램 내용 : 포인터 주소를 이용 swap메소드를 만들고 입력받은 두 정수의 위치를 바꾸는 프로그램
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

namespace Swaptest//이름공간 선언하고 사용
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btns_Click(object sender, EventArgs e)//btns버튼을 클릭했을 때 일어나는 이벤트 설정
        {
            int val1 = Convert.ToInt32(text1.Text);//text1텍스트박스에서 입력받은 문자열을 정수로 변환하여 변수에 저장
            int val2 = Convert.ToInt32(text2.Text);//text2텍스트박스에서 입력받은 문자열을 정수로 변환하여 변수에 저장
            unsafe//포인터연산을 가능하게하는 코드
            {
                Swap(&val1, &val2);//각 변수의 주소를 매개변수로 넘겨 swap메소드 호출
            }//val1과 val2 위치 바꿈
            text1.Text = Convert.ToString(val1);//val1에 저장된 정수를 문자열로 변환하여 text1텍스트박스에 출력
            text2.Text = Convert.ToString(val2);//val2에 저장된 정수를 문자열로 변환하여 text2텍스트박스에 출력
        }
        unsafe void Swap(int* v1, int* v2)//포인터형 매개변수를 가지는 메소드 선언 및 정의(unsafe코드 이용)
        {
            int tmp;//정수형 임시변수 선언
            tmp = *v2;//임시변수에 v2에 저장되어 있는 값 저장
            *v2 = *v1;//v2에 v1에 저장되어 있는 값 저장
            *v1 = tmp;//v1에 임시변수에 저장되어있던 값 저장
        }
    }
}
