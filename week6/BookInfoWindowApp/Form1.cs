/*
 20175125 김지호
 2019-04-07
 윈도우프로그래밍 week6 과제
 프로그램 내용 : 책 정보를 저장하고 가격 할인 후 품절여부 확인하여 정보를 출력하는 프로그램
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

namespace BookInfoWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EBook b;//객체 선언
        private void btnSave_Click(object sender, EventArgs e)//저장 버튼 눌렀을 때 발생하는 이벤트 설정
        {
            string title = txtTitle.Text;//책 제목 입력
            string author = txtAuthor.Text;//책 저자 입력
            int page = Convert.ToInt32(txtPages.Text);//쪽 수 입력받아 정수형으로 변환 후 저장
            string ISBN = txtISBN.Text;//국제표준도서번호 입력
            string publisher = txtPublisher.Text;//출판사 입력
            int price = Convert.ToInt32(txtPrice.Text);//가격 입력받아 정수형으로 변환 후 저장
            b = new EBook(title, author, page, ISBN, publisher, price);//객체 생성
        }

        private void btnSale_Click(object sender, EventArgs e)//할인 버튼 눌렀을 때 발생하는 이벤트 설정
        {
            int discount = Convert.ToInt32(txtDiscount.Text);//할인 값 입력받아 정수형으로 변환 후 저장
            b.DiscountPrice(discount);//인터페이스 메소드 호출하여 가격 할인
        }

        private void btnOfs_Click(object sender, EventArgs e)//품절 버튼 눌렀을 때 발생하는 이벤트 설정
        {//프로퍼티의 get값을 받으려면 배정문의 오른쪽에서 사용
            if (false == b.OutOfStock)//재고여부가 false면
            {
                b.StockOut();//인터페이스 메소드 호출하여 재고여부 true로 변경
            }
            else//재고여부가 true면
                b.StorageInWareHouse();//인터페이스 메소드 호출하여 재고여부 false로 변경
        }

        private void btnPrint_Click(object sender, EventArgs e)//출력버튼 눌렀을 때 발생하는 이벤트 설정
        {
            txtResult.Text=b.ToString();//출력창에 ToString()메소드 호출하여 책 정보 출력
            if (b.OutOfStock == true)//재고여부가 true면
                txtResult.Text += " 품절여부 : 재고있음";//출력창에 재고있음 더하여 출력
            else//재고여부가 false면
                txtResult.Text += " 품절여부 : 재고없음";//출력창에 재고없음 더하여 출력
        }
    }
}
