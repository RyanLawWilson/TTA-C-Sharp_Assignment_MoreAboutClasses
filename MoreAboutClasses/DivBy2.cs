using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAboutClasses
{
    public class DivBy2
    {
        public void Divide(int num)
        {
            Fancy.Write(num / 2 + "\n\n", afterPause: 1200);
        }

        public void Divide(int num, out int divisions)
        {
            divisions = 0;
            for (; num / 2 >= 1; )
            {
                num /= 2;
                divisions++;
            }
        }
    }
}
