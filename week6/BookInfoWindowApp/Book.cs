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
    class Book//책 정보를 저장하는 클래스
    {
        public string title;//책 제목
        public string author;//책 저자
        public int page;//쪽 수
        public string ISBN;//국제표준도서번호
        public string publisher;//출판사
        public Book(string title, string author, int page, string ISBN, string publisher)//생성자
        {
            this.title = title;//책 제목 필드값을 매개변수로 초기화
            this.author = author;//저자 필드값을 매개변수로 초기화
            this.page = page;//쪽 수 필드값을 매개변수로 초기화
            this.ISBN = ISBN;//국제표준도서번호 필드값을 매개변수로 초기화
            this.publisher = publisher;//출판사 필드값을 매개변수로 초기화
        }
        public string Title//책 제목 프로퍼티
        {
            get//get접근자로 책 제목 반환
            {
                return title;//제목 반환
            }
            set//set접근자로 책 제목 설정
            {
                title = value;//제목 초기화
            }
        }
        public override string ToString()//책 정보를 출력하기 위한 ToString()메서드 재정의
        {
            return "책 제목 : " + title + " 저자 : " + author + " 쪽 수 : " + page + " ISBN : " + ISBN + " 출판사 : " + publisher;//책 정보 반환
        }
    }
}
