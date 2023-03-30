using System;
using System.Collections.Generic;
using System.Text;
using Gacha.Items;

namespace Gacha.Win {
    class GachaCore {
        public int gachaCount = 100;//用于记录保底次数
        public int SSR = 20;
        public int SR = 50;
        Random rare = new Random();

        /*//单次抽卡结果，返回一个Items实例(未实现)
        public Item TakeGacha() {
            Item item = new Item();
            int gachaResult = rare.Next(0, 1000);
            gachaCount++;

            return item;
        }*/

        public string TakeGacha() {
            int gachaResult = rare.Next(1, 1000);

            string rareLevel = "Not a rare level!";
            if (gachaResult >= 0 && gachaResult < SSR) {
                gachaCount = 100;
                rareLevel = "SSR";
            }
            else if (gachaResult >= SSR && gachaResult <= SSR + SR) {
                rareLevel = "SR";
            }
            else {
                rareLevel = "R";
            }
            gachaCount--;

            return rareLevel;
        }

        public string TakeGacha(string guarant) {

            string rareLevel = "Not a rare level!";
            rareLevel = guarant;
            /*以后再写调用到Item的代码块吧*/
            return rareLevel;
        }
    }
}
