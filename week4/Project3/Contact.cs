/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 연락처 객체를 생성하고 출력하는 프로그램
*/

//지정된 네임스페이스 사용
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Contact//클래스
    {
        string name;//문자열 이름변수
        int age;//정수형 나이변수
        string company;//문자열 회사변수
        string phone;//문자열 핸드폰 변수
        string call;//문자열 전화 변수
        string mail;//문자열 메일 변수
        public Contact(string name, int age, string company, string cellPhone, string tel, string mail)//멤버변수로 받은 연락처의 내용으로 연락처의 필드값을 초기화하는 생성자
        {
            this.name = name;//이름 초기화
            this.age = age;//나이 초기화
            this.company = company;//회사 초기화
            phone = cellPhone;//핸드폰 초기화
            call = tel;//전화 초기화
            this.mail = mail;//메일 초기화
        }
        public override string ToString()//연락처 결과를 출력하는 메서드
        {
            string s = "이름 : " + name + " 나이 : " + age + " 직장 : " + company + " 휴대폰 : " + phone + " 전화 : " + call + " 메일 : " + mail;//연락처 내용을 문자열로 저장
            return s;//연락처 내용 출력
        }
    }
}
