/*
 20175125 빅데이터 김지호
 2018-03-25
 윈도우 프로그래밍 week4 과제
 프로그램 내용 : 좌표객체생성, 좌표변경, 좌표이동하여 결과를 출력하는 프로그램
*/

//지정된 네임스페이스 사용
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2//네임스페이스 선언
{
    class Point//클래스 생성
    {
        int x;//x좌표
        int y;//y좌표
        public Point(int x, int y)//매개변수 x,y값으로 멤버변수를 초기화하는 생성자
        {
            this.x = x;//클래스의 x값에 매개변수 x값 저장
            this.y = y;//클래스의 y값에 매개변수 y값 저장
        }
        public void SetX(int x)//x의 필드값을 변경하는 설정자
        {
            this.x = x;//매개변수로 x설정
        }
        public void SetY(int y)//y의 필드값을 변경하는 설정자
        {
            this.y = y;//매개변수로 y설정
        }
        public int GetX()//x좌표의 필드값을 읽는 접근자
        {
            return x;//x반환
        }
        public int GetY()//y좌표의 필드값을 읽는 접근자
        {
            return y;//y반환
        }
        public override string ToString()//좌표를 문자열로 출력하기위한 메서드 재정의
        {
            string s = "X : " + x + ", Y : " + y;
            return s;//문자열 반환
        }
        public void MoveTo(int x, int y)//필드값을 매개변수로 받은 좌표값으로 변경하는 메서드
        {
            this.x = x;//x좌표 변경
            this.y = y;//y좌표 변경
        }
        public void MoveBy(int moveX, int moveY)//필드값을 매개변수로 받은 좌표만큼 이동시키는 메서드
        {
            this.x += moveX;//x필드값을 매개변수로 받은 값만큼 더하여 저장
            this.y += moveY;//y필드값을 매개변수로 받은 값만큼 더하여 저장
        }
    }
}
