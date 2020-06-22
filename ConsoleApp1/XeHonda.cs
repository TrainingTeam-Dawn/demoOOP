using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class XeHonda : Car
    {
        public XeHonda() {
            this.setBanhXe(2);
        }

        public void setBanhXe(int banhXe) {
            base.setBanhXe(banhXe);
        }



    }
}
