﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = "D:/" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".png";
            //var qr = QrCodeUtil.Encode("Hello World!");
            //qr.Save(path);
            //Console.WriteLine(QrCodeUtil.Decode(qr));

            //path = "D:/" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".png";
            //QrCodeUtil.Create("中国智造，惠及全球！", path);
            //Console.WriteLine(QrCodeUtil.Decode(path));

            QrCodeUtil.ResourceEnum();
            QrCodeUtil.SaveResource();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
