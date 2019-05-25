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
    interface Sale//인터페이스
    {
        void DiscountPrice(int discount);//할인값을 매개변수로 받아 가격을 조정하는 인터페이스 메소드
        void StockOut();//품절여부를 true로 조정하는 인터페이스 메소드
        void StorageInWareHouse();//품절여부를 false로 조정하는 인터페이스 메소드
    }
}
