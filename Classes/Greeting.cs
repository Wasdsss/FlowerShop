using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.CLasses
{
    public class Greeting
    {
        public string Welcome()
        {
            string greeting = "";
            DateTime currentTime = DateTime.Now;

            if (5 <= currentTime.Hour && currentTime.Hour < 11)
            {
                greeting = "Доброго утра,";
            }

            else if (11 <= currentTime.Hour && currentTime.Hour < 17)
            {
                greeting = "Доброго дня,";
            }

            else if (17 <= currentTime.Hour && currentTime.Hour < 23)
            {
                greeting = "Доброго вечера,";
            }

            else
            {
                greeting = "Доброй ночи,";
            }
            return greeting;
        }
    }
}
