﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetod
{
    public class Musteri //:object ->Framework tümnesleri object den türetilmiştir
    {

        public int musteriId { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }




        public override string ToString()
        {
            return isim +"--" + soyisim;
        }


    }
}
