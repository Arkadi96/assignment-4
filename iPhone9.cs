using System;
using System.Collections.Generic;
using System.Text;

namespace Implement__Mobile__hierarchy
{
    class iPhone9 : Apple
    {
        private string brand_name, mobile_name, mobile_color;
        private int moble_price;

        public iPhone9() : base()
        {
            printInfo();
        }

        public override void mobileBrandName()
        {
            brand_name = "Apple ";
        }

        public override void mobileColor()
        {
            mobile_color = "gray ";
        }

        public override void mobileName()
        {
            mobile_name = "iPhone 9 ";
        }

        public override void price()
        {
            moble_price = 500;
        }

        public override void printInfo()
        {
            mobileBrandName();
            mobileName();
            mobileColor();
            price();
            Console.WriteLine("Mobile details: {0} {1} ,{2} Color, Price {3} $", brand_name, mobile_name, mobile_color, moble_price);
        }
    }
}
