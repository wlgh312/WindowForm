/*
 20175125 김지호
 2019-04-07
 윈도우프로그래밍 week6 과제
 프로그램 내용 : 책 정보를 저장하고 가격 할인 후 품절여부 확인하여 정보를 출력하는 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWindowApp
{

    class EBook : Book, Sale//Book클래스와 Sale인터페이스 상속
    {
        private int price;//책 가격
        bool outOfStock = false;//책 품절여부 false로 초기화
        public EBook(string title, string author, int page, string ISBN, string publisher, int price) : base(title, author, page, ISBN, publisher)//상위클래스 생성자를 통해서 생성자 초기화
        {
            this.price = price;//가격 필드값을 매개변수로 초기화
        }
        public int Price//가격 프로퍼티
        {
            get { return price; }//get접근자로 가격 반환
            set { price = value; }//set접근자로 가격 설정
        }
        public bool OutOfStock//재고 프로퍼티
        {
            get { return outOfStock; }//get접근자로 재고여부 반환
            set { outOfStock = value; }//set접근자로 재고여부 설정
        }
        public override string ToString()//책 정보를 출력하기위한 ToString()메서드 재정의
        {
            return "책 제목 : " + title + " 저자 : " + author + " 쪽 수 : " + page + " ISBN : " + ISBN + " 출판사 : " + publisher + " 가격 : " + price;//책 정보 반환
        }
        public void DiscountPrice(int discount)//인터페이스 할인 메소드 설정
        {
            price = price - discount;//가격에서 discount값 할인
        }
        public void StockOut()//인터페이스 재고여부 메소드 설정
        {
            outOfStock = true;//재고가 없을 경우 true로 변경

        }
        public void StorageInWareHouse()//인터페이스 재고여부 메소드 설정
        {
            outOfStock = false;//재고가 있을 경우 false로 변경
        }
    }
}
