/*
20175125 김지호
2018-04-01
윈도우프로그래밍 5주차 과제
프로그램 내용 : 책의 정보를 저장하고 출력하는 프로그램
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

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)//객체생성 버튼을 눌렀을 때 발생하는 이벤트 설정
        {
            string title=txttitle.Text;//책 제목 입력받기
            string author=txtaut.Text;//저자 입력받기
            int page=Convert.ToInt32(txtpage.Text);//쪽수를 입력받은 후 정수형으로 변환 후 page에 저장
            string ISBN=txtnum.Text;//국제표준도서번호 입력받기
            string publisher=txtpub.Text;//출판사 입력받기
            Book b = new Book(title, author, page, ISBN, publisher);//책 객체 선언 및 생성
            txtinf.Text=b.ToString();//메서드 호출하여 객체 b의 책 정보 출력
        }
    }
}
