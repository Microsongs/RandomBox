﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootBox_RandomBox_
{
    public class LootItem
    {
        // 이름, 사진, 확률
        string name;
        Image itemImage;
        decimal probability;
        string imgFilePath;

        public LootItem(string name, Image itemImage, decimal probability, string imgFilePath)
        {
            this.name = name;
            this.itemImage = itemImage;
            this.probability = probability;
            this.imgFilePath = imgFilePath;
        }
        public string ImgFIlePath
        {
            get { return imgFilePath; }
            set { imgFilePath = value; }
        }
        public LootItem(string name, decimal probability)
        {
            this.name = name;
            this.probability = probability;
            this.imgFilePath = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Image ItemImage
        {
            get { return itemImage; }
            set { itemImage = value; }
        }
        public decimal Probability
        {
            get { return probability; }
            set { probability = value; }
        }
    }
}
