using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Thả_Trứng;
/*
* Create by: Promises No
* Date: 06/09/2019
*/
public class Program
{
    
    public static void Main()
    {


        Faberge.Height((BigInteger)1, (BigInteger)1);
        Console.WriteLine("ket qua : {0}", Faberge.Height((BigInteger)2, (BigInteger)14) );
        

        Console.ReadKey();
    }
    
}
