/*
 20175125 김지호
 2019/3/7
 윈도우프로그래밍 week2
 프로그램 내용 : 키보드로부터 반지름을 입력받아 공의 부피와 표면적을 계산하여 출력하는 프로그램
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

namespace Circlevolume//고유한 이름공간 선언
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnci_Click(object sender, EventArgs e)//버튼을 눌렀을 때 
        {
            int radius = Convert.ToInt32(txtr.Text);//반지름을 나타내는 변수에 텍스트박스로 입력받은 문자열을 정수형으로 바꾼후 저장한다.
            double volume = (4 / 3) * 3.14 * Math.Pow(radius,3);//부피를 나타내는 실수형 변수에 구의 부피를 계산한 후 저장
            double surface = 4 * 3.14 * radius * radius;//표면적을 나타내는 실수형 변수에 구의 표면적을 계산한 후 저장
            txtvol.Text = Convert.ToString(volume);//txtvol텍스트박스에 구의 부피 출력
            txts.Text = Convert.ToString(surface);//txts텍스트박스에 구의 표면적 출력
        }
    }
}
