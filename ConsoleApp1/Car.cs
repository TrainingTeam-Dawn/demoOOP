using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        private int banhxe;
        private String mausac;
        private String dongco;

  
            
        //Contructor HAM DUNG
        public Car() {
            this.banhxe = 4;
            this.mausac = "Do";
            this.dongco = "1";
        }

        //
        public int getBanhXe() {
            return this.banhxe;
        }

        public void setBanhXe(int banhxe) {
            if (banhxe > 2) { 
            this.banhxe = banhxe;}
        }







    }
}
