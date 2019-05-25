/*
 20175125 김지호
 2019-04-07
 윈도우프로그래밍 week6 과제
 프로그램 내용 : 인덱서를 이용해 10개의 좌표 객체를 저장, 이동하고 결과를 출력하는 프로그램
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointIndexerWindowApp
{
    
    class Point
    {
        int x;//x좌표 변수
        int y;//y좌표 변수
        public Point(int x, int y)//생성자
        {
            this.x = x;//x좌표 필드값을 매개변수로 초기화
            this.y = y;//y좌표 필드값을 매개변수로 초기화
        }
        public Point()//생성자 재정의
        {
            x = 0;//x좌표 필드값을 0으로 초기화
            y = 0;//y좌표 필드값을 0으로 초기화
        }
        int X//x좌표 프로퍼티
        {
            get { return x; }//get접근자로 x좌표 반환
            set { x = value; }//set접근자로 x좌표 초기화
        }
        int Y//y좌표 프로퍼티
        {
            get { return y; }//get접근자로 y좌표 반환
            set { y = value; }////set접근자로 y좌표 초기화
        }
        public void MoveTo(int x, int y)//좌표변경 메소드
        {
            this.x = x;//x좌표 필드값을 매개변수로 초기화
            this.y = y;//y좌표 필드값을 매개변수로 초기화
        }
        public void MoveBy(int moveX, int moveY)//좌표이동 메소드
        {
            x += moveX;//x좌표를 매개변수로 받은 moveX좌표만큼 이동
            y += moveY;//y좌표를 매개변수로 받은 moveY좌표만큼 이동
        }
        public string ToString()//문자열 출력 메소드
        {
            return "x좌표 : " + x + " y좌표 : " + y+"\r\n";//좌표 문자열 반환
        }
        public static Point operator +(Point p1, Point p2)//두 객체의 좌표를 더하는 연산자 재정의
        {
            Point p = new Point(0, 0);//객체 선언 및 생성
            p.x = p1.x + p2.x;//객체 p의 x좌표에 매개변수의 두 객체의 x좌표를 더해서 저장
            p.y = p1.y + p2.y;//객체 p의 y좌표에 매개변수의 두 객체의 y좌표를 더해서 저장
            return p;//객체 반환
        }
        public static Point operator -(Point p1, Point p2)//두 객체의 좌표를 빼는 연산자 재정의
        {
            Point p = new Point(0, 0);//객체 선언 및 생성
            p.x = p1.x - p2.x;//객체 p의 x좌표에 매개변수의 두 객체의 x좌표끼리 빼서 저장
            p.y = p1.y - p2.y;//객체 p의 x좌표에 매개변수의 두 객체의 x좌표끼리 빼서 저장
            return p;//객체 반환
        }
    }
}
