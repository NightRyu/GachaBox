using System;

namespace Gacha.Items
{
    public class Item
    {
        /// <summary>
        /// 物品Id
        /// </summary>
        public uint itemId;

        /// <summary>
        /// 物品名称
        /// </summary>
        public string itemName;

        /// <summary>
        /// 物品稀有度
        /// </summary>
        public string itemRare;

        /// <summary>
        /// 该物品是否为当期Up
        /// </summary>
        public bool beingPickedUP;

        public Item() {
            itemId = 0;
            itemName = "Illegal";
            itemRare = "-";
            beingPickedUP = false;
        }

        public Item(uint id, string name, string rare, bool isUp) {
            this.itemId = id;
            this.itemName = name;
            this.itemRare = rare;
            this.beingPickedUP = isUp;
        }

    }
}
