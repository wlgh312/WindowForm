/*
20175125 김지호
2018-04-01
윈도우프로그래밍 5주차 과제
프로그램 내용 : 범용 클래스를 이용한 좌표변경 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Point <DataType>//범용클래스
    {
        private DataType x;//자료형이 정해지지않은 변수
        private DataType y;
        public Point(DataType x, DataType y)//x, y를 매개변수로 받는 생성자
        {
            this.x = x;//필드값 x에 매개변수 x저장
            this.y = y;//필드값 y에 매개변수 y저장
        }
        public void SetX(DataType x)//x를 매개변수로 받는 설정자
        {
            this.x = x;//x를 매개변수 x로 초기화
        }
        public void SetY(DataType y)//y를 매개변수로 받는 설정자
        {
            this.y = y;//y를 매개변수 y로 초기화
        }
        public DataType GetX()//x의 접근자
        {
            return x;//x반환
        }
        public DataType GetY()//y의 접근자
        {
            return y;//y반환
        }
        public void MoveTo(DataType x, DataType y)//좌표를 변경하는 메서드
        {
            this.x = x;//필드값 x를 매개변수 x값으로 변경
            this.y = y;//필드값 y를 매개변수 y값으로 변경
        }
        public override string ToString()//좌표정보를 문자열로 제공하기 위한 메서드 재정의
        {
            return "X : " + x + ", Y : " + y;//좌표정보 출력
        }
    }
}
