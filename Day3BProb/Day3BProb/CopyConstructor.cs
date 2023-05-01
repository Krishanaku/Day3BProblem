using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    public class CopyConstructor
    {
        public int numFirst;
        public int numSecond;
        //Simple Constrcutor...........
        public CopyConstructor( int num, int sec) 
        {
            this.numFirst = num;
            this.numSecond = sec;

        }
        //Copy Constructor.......................
        public CopyConstructor(CopyConstructor copyCon)
        {
            numFirst=copyCon.numFirst;
            numSecond=copyCon.numSecond;
        }
    }
}
