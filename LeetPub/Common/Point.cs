using System;
using System.Collections.Generic;
using System.Text;

namespace LC.Common
{
    public class Point
    {
        public int x;
        public int y;
        public Point() { x = 0; y = 0; }
        public Point(int a, int b) { x = a; y = b; }
        public override string ToString() {
            return x +","+ y;
        }
    }
}
