using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 회의실배정
{
    class Program
    {
        static void Main(string[] args)
        {
            int AmountMR = Convert.ToInt32(ReadLine());     //회의실 수 할당
            int[,] MRList = new int[AmountMR, 2];       //회의실 수를 2차 배열로 지정
            MRList = AllotmentMRTime(AmountMR, MRList);     //회의 시간을 할당
            EfficiencyArrangement(MRList);         //회의실 최대 사용가능한 횟수 계산

        }
        static int [,] AllotmentMRTime(int a,int[,]vs)
        {
            for (int i = 0; i < a; i++)
            {
                vs[i, 0] = Convert.ToInt32(ReadLine());
                vs[i, 1] = Convert.ToInt32(ReadLine());
                WriteLine();
            }
            return vs;
        }

        static void EfficiencyArrangement(int [,] vs)
        {
            int standard = vs[0, 1];
            int count = 1;
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                if (standard < vs[i, 0])
                {
                    standard = vs[i, 1];
                    count++;
                }
            }
            WriteLine(count);

        }
    }
}
