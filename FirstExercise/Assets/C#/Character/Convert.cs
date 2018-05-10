using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.C_.Character
{
    class Convert
    {
        public int cash(int i) {
            if (i.Equals(1)) {
                return 20;
            }
            Double sq = Math.Sqrt(cash(i - 1));
            int ans =(int)(cash(i - 1) + 20 * sq);
            return ans;
        }
    }
}
