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
   
    class PointArray
    {
        Point[] p = new Point[10];//크기가 10인 객체 배열
        public static int count = 0;//인덱서의 인덱스 초기화
        public Point this[int count]//인덱서
        {
            get { return p[count]; }//get접근자로 인덱서의 count번째 객체 반환
            set { p[count] = value; }//set접근자로 인덱서의 count번째 객체 초기화
        }
    }
}
