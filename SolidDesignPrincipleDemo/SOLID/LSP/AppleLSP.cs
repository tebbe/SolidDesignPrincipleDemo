using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.LSP
{
    //Violate LSP
    public class AppleLSP
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeLSP:AppleLSP
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    /*
    In the above example, first, we create the AppleLSP class with the method GetColor. 
    Then, we create the Orange class, which inherits the AppleLSP class and overrides 
    the GetColor method of the Apple class. The point is that an Orange cannot be replaced by 
    an Apple, which results in printing the color of the apple as Orange, 
    as shown in the example above.
     */
}
