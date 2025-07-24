using AldawaaPOS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldawaaPOS.ViewModels
{
    class LoginVM:ViewModelBase
    {

        private string GetCalculatorNumber(string number)
        {
            string Qty = "";

            //if (Qty == "0")
            //{
            //    Qty = string.Empty;
            //    Qty = Qty + number;
            //    if (Qty == ".")
            //    {
            //        Qty = "0.";
            //    }
            //}
            //else
            //{
            //    Qty = Qty + number;
            //}

            return Qty;
        }

        private void Calculator1()
        {
            GetCalculatorNumber("1");
        }

        private void Calculator2()
        {
            GetCalculatorNumber("2");
        }

        private void Calculator3()
        {
            GetCalculatorNumber("3");
        }

        private void Calculator4()
        {
            GetCalculatorNumber("4");
        }

        private void Calculator5()
        {
            GetCalculatorNumber("5");
        }

        private void Calculator6()
        {
            GetCalculatorNumber("6");
        }

        private void Calculator7()
        {
            GetCalculatorNumber("7");
        }

        private void Calculator8()
        {
            GetCalculatorNumber("8");
        }

        private void Calculator9()
        {
            GetCalculatorNumber("9");
        }

        private void Calculator0()
        {
            GetCalculatorNumber("0");
        }

        private void CalculatorClear()
        {
            //Qty = "0";
        }

        private void CalculatorPoint()
        {
            //if (!Qty.Contains("."))
            //{
            //    GetCalculatorNumber(".");
            //}
        }

    }
}
