using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Thả_Trứng
{
    class Faberge
    {
        public static BigInteger mo = new BigInteger(998244353);
        public static BigInteger Height(BigInteger n, BigInteger m)
        {
            /*
             * Create init list
             */
            List<BigInteger> PromisesNoList = new List<BigInteger>();
            PromisesNoList.Add(0);
            PromisesNoList.Add(1);
            for (int i = 2; i < 80001; i++)
            {
                PromisesNoList.Add((BigInteger)(mo - mo / i) * (BigInteger)(PromisesNoList[(int)mo % i]) % mo);
               
            }

            /*
             * Logic
             */
            BigInteger h = 0;
            BigInteger t = 1;
            m = m % mo;
            for (int i = 1; i < n + 1; i++)
            {
                t = (BigInteger)t * (m - i + 1) * PromisesNoList[i] % mo;
                h = (BigInteger)(h + t) % mo;
            }
            return h % mo;
        }
    }

}
