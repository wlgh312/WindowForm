using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Colorable3DPoint : Point<int>
    {
        int z;
        string color;
        public Colorable3DPoint(int x, int y, int z, string color) : base(x, y)
        {
            this.z = z;
            this.color = color;
        }
        public void SetZ(int z)
        {
            this.z = z;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public int GetZ()
        {
            return z;
        }
        public string GetColor()
        {
            return color;
        }
        public void MoveTo(int x, int y, int z)
        {
            base.MoveTo(x, y);
            this.z = z;
        }
        public void MoveBy(int moveX, int moveY, int moveZ)
        {
            base.MoveBy(moveX, moveY);
            z += moveZ;
        }
        public override string ToString()
        {
            return base.ToString()+", Z : " + z;
        }
    }
}
