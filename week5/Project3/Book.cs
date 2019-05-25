/*
20175125 김지호
2018-04-01
윈도우프로그래밍 5주차 과제
프로그램 내용 : 책의 정보를 저장하고 출력하는 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Book
    {
        string title;//책 제목
        string author;//저자
        int page;//쪽 수
        string ISBN;//국제표준도서번호
        string publisher;//출판사

        public Book(string title, string author, int page, string ISBN, string publisher)//생성자
        {
            this.title = title;//책 제목필드값을 매개변수값으로 초기화
            this.author = author;//저자필드값을 매개변수값으로 초기화
            this.page = page;//쪽 수필드값을 매개변수값으로 초기화
            this.ISBN = ISBN;//국제표준도서번호필드값을 매개변수값으로 초기화
            this.publisher = publisher;//출판사필드값을 매개변수값으로 초기화
        }
        public void SetTitle(string title)//설정자
        {
            this.title = title;//책 제목 설정
        }
        public string GetTitle()//접근자
        {
            return title;//책 제목 반환
        }
        public override string ToString()//책 정보를 출력하는 메서드 재정의
        {
            //책 정보 문자열로 반환
            return "제목 : " + title + ", 저자 : " + author + ", 쪽 수 : " + page + ", 국제표준도서번호 : " + ISBN + ", 출판사 : " + publisher;
        }
    }
}
