using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatDemo
{
    class DelegatDemoClass
    {
        public delegate void TestDelegat();
        private TestDelegat testDelegat;

        public delegate void TestDelegat2(int i);
        private TestDelegat2 testDelegat2;
        public DelegatDemoClass()
        {
            testDelegat = MojaTestnaMetodaDelegata;
            testDelegat();
            testDelegat += MojaTestnaMetoda2Delegata;
            testDelegat();
            testDelegat2 += MojaTestnaMetoda3Delegata;
            testDelegat2(3);
            testDelegat -= MojaTestnaMetoda2Delegata;
            testDelegat();
            testDelegat += delegate () { Console.WriteLine("Anoninma funkcija"); };
            testDelegat += () => { Console.WriteLine("Lambda"); };
            testDelegat();
        }

        private void MojaTestnaMetodaDelegata()
        {
            Console.WriteLine("Metoda 1");
        }

        private void MojaTestnaMetoda2Delegata()
        {
            Console.WriteLine("Metoda 2");
        }

        private void MojaTestnaMetoda3Delegata(int i)
        {
            Console.WriteLine(i);
        }


    }
}
