using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM
{
    public class Calculation
    {
        private int a, b;
        public Calculation(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int execute(string phepToan)
        {
            int kq = 0;
            switch(phepToan)
            {
                case "+":
                    kq = this.a + this.b;
                    break;
                case "-":
                    kq = this.a - this.b;
                    break;
                case "*":
                    kq = this.a * this.b;
                    break;
                case "/":
                    if (b == 0)
                        new DivideByZeroException("Loi chia 0");
                    kq = this.a / this.b;
                    break;
            }
            return kq;
        }
    }
}
