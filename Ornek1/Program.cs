using System;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string deger = Console.ReadLine();
                string bilmemneVal = "";
                string asdVal = "";

                string pascalVal = Method1(deger, out bilmemneVal, out asdVal);

                Console.WriteLine("Pascal Case :" + pascalVal);
                Console.WriteLine("bilmemne Case :" + bilmemneVal);
                Console.WriteLine("asd Case :" + asdVal);


            }

        }
        public static string Method1(string prm, out string prm2, out string prm3)
        {
            string pascalVal = prm[0].ToString().ToUpper();
            string bilmemneVal = prm[0].ToString().ToLower();
            string asdVal = prm[0].ToString().ToUpper();

            for (int i = 1; i < prm.Length; i ++)
            {
               if(i % 2 == 1)
                {
                    asdVal += prm[i].ToString().ToLower();

                }
                else
                {
                    asdVal += prm[i].ToString().ToUpper();

                }

            }


            for (int i = 1; i < prm.Length; i++)
            {
                pascalVal += prm[i].ToString().ToLower();
                bilmemneVal += prm[i].ToString().ToUpper();

            }
            prm3 = asdVal;
            prm2 = bilmemneVal;
            return pascalVal;
        }
    }
}
