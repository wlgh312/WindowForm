/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 키보드로부터 길이, 너비, 높이를 입력받아 부피를 계산하여 출력하는 프로그램
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

namespace BoxvolumeProject//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//디자이너와 관련된 생성자 메서드
        }

        private void btncir_Click(object sender, EventArgs e)//버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            int width = Convert.ToInt32(tbWidth.Text);//정수형 변수 width에 tbWidth텍스트박스에 입력받는 정수 저장
            //텍스트박스는 문자열만 입력받으므로 Convert.ToInt32()로 정수형으로 변경해야한다.
            int length = Convert.ToInt32(tbLength.Text);//정수형 변수 length에 tbLength텍스트박스에 입력받는 정수 저장
            int height = Convert.ToInt32(tbHeight.Text);//정수형 변수 height에 tbHeight텍스트박스에 입력받는 정수 저장
            int result;//결과를 저장할 정수형 변수

            result = width * length * height;//변수 result에 부피를 계산하여 저장
            txtresult.Text = Convert.ToString(result);//txtresult텍스트박스에서 결과를 나타내는 변수 result출력
            
        }
    }
}
