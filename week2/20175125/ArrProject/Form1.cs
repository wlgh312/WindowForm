/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 1차원 배열을 선언 및 초기화하고 배열의 내용을 출력하는 프로그램
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

namespace ArrProject//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//디자이너와 관련된 생성자 메서드
        }

        private void btnexc_Click(object sender, EventArgs e)//버튼을 클릭했을 때 발생하는 이벤트 설정
        {
            int[] arr = new int[]{ 1, 3, 4, 5, 6, 7, 8, 2, 0 };//1차원 배열 선언 및 초기화
            for(int i=0; i<arr.Length; i++)//배열 크기만큼 반복
            {
                txtarr.Text += Convert.ToString(arr[i]);//txtarr 텍스트박스에서 배열원소들을 연결해서 출력
                if (i < 8)//배열의 마지막이 아닌 나머지일때
                    txtarr.Text += ", ";//원소들 사이에 쉼표 출력
            }//반복문 종료
            
        }
    }
}
