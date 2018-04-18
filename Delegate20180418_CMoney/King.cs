using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate20180418_CMoney
{
    public delegate void MathDelegate(int i, int j);

    class King
    {
        public int firstNum { get; set; }
        public int secondNum { get; set; }

        public King(int i, int j)
        {
            this.firstNum = i;
            this.secondNum = j;
        }

        public void CalcMath() // 建立委派
        {
            Math math = new Math();

            MathDelegate mathDelegate;// 有實體後要跟方法做關聯

            mathDelegate = math.Add;// MathDelegate會將被給予的兩個數傳入，不需要也不能用()
            mathDelegate += math.Minus;
            mathDelegate += math.Mutiple;// 多重委派：列印多個mathDelegate，將方法加入到櫃台(mathDelegate)裡。
            mathDelegate += math.Divide;
            mathDelegate(this.firstNum, this.secondNum);// 將被給予的兩數用delegate傳入
            // king delegate -> math.Add 國王被問1+1多少，國王(king)不會因此往後讓櫃台(delegate)問數學家(math.Add)，數學家直接回答(所以數學家不需要()，因為()內參數是國王給的)
        }
    }
}
