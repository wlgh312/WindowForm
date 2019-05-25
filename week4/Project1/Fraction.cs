/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 분수 계산이 가능하도록 클래스를 이용하여 만든 프로그램
*/

//지정된 네임스페이스 사용
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Fraction//분수를 저장하고 계산하는 클래스
    {
        int fj, fm;  // fj1 = 분자값을 저장할 변수
        public Fraction(int fj, int fm)//매개변수로 분자,분모 필드를 초기화하는 생성자
        {
            this.fj = fj;//분자값을 매개변수로 초기화
            this.fm = fm;//분모값을 매개변수로 초기화
        }
        public void SetFj(int fj)//분자의 필드값을 변경하는 설정자
        {
            this.fj = fj;//분자 초기화
        }
        public void SetFm(int fm)//분모의 필드값을 변경하는 설정자
        {
            this.fm = fm;//분모 초기화
        }
        public int GetFj()//분자의 필드값을 읽는 접근자
        {
            return fj;//분자 반환
        }
        public int GetFm()//분모의 필드값을 읽는 접근자
        {
            return fm;//분모 반환
        }
        public Fraction Add(Fraction f2)   //  f3 = f1.Add(f2), 다른 분자 객체를 받아 분수를 계산하는 메서드
        {   //통분하여 분수 더하기
            int fm = this.fm * f2.fm;//첫번째 분수의 분모와 두번째 분수의 분모를 곱해서 fm변수에 저장
            int fj = this.fj * f2.fm + this.fm * f2.fj;//첫번째 분수의 분자*두번째 분수의 분모의 값과 첫번째 분수의 분모*두번째 분수의 분자의 값을 더해서 fj변수에 저장
            //최대공약수 찾기
            int max = fj > fm ? fj : fm;//분자가 분모보다 더 크면 분자가 최대값
            int min = fj < fm ? fj : fm;//분자보다 분모가 더 크면 분자가 최소값
            while (min != 0)//min이 0이 아니면 반복
            {
                int tmp = max % min;//임시변수에 max를 min으로 나눈 후 나머지 저장
                max = min;//max에 min저장
                min = tmp;//min에 임시변수값 저장
            }//반복문 종료
            Fraction f3 = new Fraction(fj/max,fm/max);//분자와 분모를 각각 최대공약수로 나눠 약분한 분수 객체 생성
            return f3;//계산된 분수 반환
        }
    }
}