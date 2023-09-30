using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetPub
{
    public class PascalTriangle2_119
    {
        public IList<int> GetRow(int rowIndex)
        {
            //    1 
            //   1 1
            //  1 2 1
            // 1 3 3 1
            //1 4 6 4 1
            var row0 = new List<int> { 1 };
            var rowCur = new List<int> { 1, 1 };
            if (rowIndex == 0) return row0;
            if (rowIndex == 1) return rowCur;

            List<int> rowNext=new List<int>() ;
            for (int x = 2; x <= rowIndex; x++)
            {
                rowNext = new List<int>();
                for (int y = 0; y < rowCur.Count + 1; y++)
                {
                    if (y == 0 || y == rowCur.Count)
                        rowNext.Add(1);
                    else
                    {
                        rowNext.Add(rowCur[y] + rowCur[y - 1]);
                    }
                }
                rowCur = rowNext;
            }
            return rowNext.ToArray();
        }

    }
}
