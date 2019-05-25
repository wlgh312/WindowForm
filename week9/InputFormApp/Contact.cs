/*
 20175125 빅데이터 김지호
 2019-04-29
 윈도우프로그래밍 9주차 과제
 프로그램 내용 : 정보를 입력받아 다른 폼에 출력하는 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFormApp
{
    public class Contact//입력받을 정보를 저장할 클래스
    {
        public string name;//이름
        public int age;//나이
        public string gender;//성별
        public int year;//년도
        public int month;//월
        public int day;//일
        public string favorite;//취미
        public Contact(string name, int age, string gender, int year, int month, int day, string favorite)//생성자
        {
            this.name = name;//이름설정
            this.age = age;//나이설정
            this.gender = gender;//성별설정
            this.year = year;//년도설정
            this.month = month;//월설정
            this.day = day;//일설정
            this.favorite = favorite;//취미설정
        }
    }
    
}
