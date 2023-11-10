using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.LSP
{
    public interface IFruit
    {
        string GetColor();
    }
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }

    /*
     First, we need a generic base Interface, i.e., IFruit, which will be the base class 
    for both Apple and Orange. Now, you can replace the IFruit variable can be replaced 
    with its subtypes, either Apple or Orage, and it will behave correctly. 
    In the code above, we created the super IFruit as an interface with the GetColor method.
    Then, the Apple and Orange classes were inherited from the Fruit class and implemented
    the GetColor method. 


    Now, run the application, and it should give the output as expected, as shown in 
    the above. Here, we follow the LSP as we can change the object with its 
    subtype without affecting the behavior.
     */
}
