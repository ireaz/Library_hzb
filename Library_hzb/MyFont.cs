using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_hzb
{
    class MyFont
    {
        public static FontFamily vazir()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("VazirFD.ttf");
            return pfc.Families[0];
        }
    }
}
