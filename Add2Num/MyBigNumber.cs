using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2Num
{
    internal class MyBigNumber
    {
        public string num(string stn1, string stn2)
        {
            int distance = 0;
            if(stn1.Length > stn2.Length)
            {
                distance = stn1.Length - stn2.Length;
                for (int i = 0; i < distance; i++)
                {
                    stn2 = "0" + stn2;
                }
            }
            else if (stn1.Length < stn2.Length)
            {
                distance = stn2.Length - stn1.Length;
                for (int i = 0;i < distance;i++)
                {
                    stn1 = "0" + stn1;
                }
            }
            string total = "";
            int save = 0;
            while (stn1.Length != 0 && stn2.Length != 0)
            {
                int num = Convert.ToInt32(stn1.Substring(stn1.Length - 1))
                         + Convert.ToInt32(stn2.Substring(stn2.Length - 1)) + save;
                if (num >= 10)
                {
                    //save = 1;
                    total = Convert.ToString(num - 10) + total;
                    if (save != 0)
                    {
                        Console.Write(stn1.Substring(stn1.Length - 1) + "+" + stn2.Substring(stn2.Length - 1) + "+" + Convert.ToString(save) + "=");
                    }
                    else
                    {
                        Console.Write(stn1.Substring(stn1.Length - 1) + "+" + stn2.Substring(stn2.Length - 1) + "=");
                    }
                    Console.WriteLine(num);
                    Console.WriteLine("Write " + Convert.ToString(num-10) + " save 1");
                    Console.WriteLine("----------");
                    save = 1;
                }
                else
                {
                    total = Convert.ToString(num) + total;
                    if (save != 0)
                    {
                        Console.Write(stn1.Substring(stn1.Length - 1) + "+" + stn2.Substring(stn2.Length - 1) + "+" + Convert.ToString(save) + "=");
                    }
                    else 
                    {
                        Console.Write(stn1.Substring(stn1.Length - 1) + "+" + stn2.Substring(stn2.Length - 1) + "=");
                    }
                    Console.WriteLine(num);
                    Console.WriteLine("Write " + Convert.ToString(num));
                    Console.WriteLine("----------");
                    save = 0;
                }
                stn1 = stn1.Substring(0, stn1.Length - 1);
                stn2 = stn2.Substring(0, stn2.Length - 1);
            }
            if (save == 1)
            {
                total = "1" + total;
            }
            return total;
        }
    }
}
