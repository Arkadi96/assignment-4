using System;
using System.Collections.Generic;
using System.Text;

namespace Implement__Mobile__hierarchy
{
    class NokiaX6 : Nokia
    {
        private string brand_name, mobile_name, mobile_color;
        private int moble_price;

        public NokiaX6() : base()
        {
            printInfo();
        }

        public override void mobileBrandName()
        {
            brand_name = "Nokia ";
        }

        public override void mobileColor()
        {
            mobile_color = "White ";
        }

        public override void mobileName()
        {
            mobile_name = "X6 ";
        }

        public override void price()
        {
            moble_price = 120;
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