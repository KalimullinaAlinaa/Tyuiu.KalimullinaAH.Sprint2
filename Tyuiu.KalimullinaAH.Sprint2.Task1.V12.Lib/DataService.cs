using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KalimullinaAH.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0]= (a - 46 == b) | (c - 331 >= d); 
            res[1]= (a-50<b)&(c-100>d);
            res[2] = (a!=b)||(c>d);
            res[3]= (a - 10 < b) && (c > d);
            res[4] = (!res[3]);  ;
            res[5]= (a>b)^(c!=d);
            return res;
        }
    }
}
