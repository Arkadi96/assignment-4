using System;
using System.Collections.Generic;
using System.Text;

namespace Implement__Mobile__hierarchy
{
    class RedmiNote9S : Xiaomi
    {
        private string brand_name, mobile_name, mobile_color;
        private int moble_price;
        
        public RedmiNote9S():base()
        {
            printInfo();
        }

        public override void mobileBrandName()
        {
            brand_name = "Redmi ";
        }

        public override void mobileColor()
        {
            mobile_color = "black ";
        }

        public override void mobileName()
        {
            mobile_name = "Note 9S ";
        }

        public override void price()
        {
            moble_price = 100;
        }

        public override void printInfo()
        {
            mobileBrandName();
            mobileName();
            mobileColor();
            price();
            Console.WriteLine("Mobile details: {0} {1} ,{2} Color, Price {3} $",brand_name,mobile_name,mobile_color,moble_price);
        }
    }
}
