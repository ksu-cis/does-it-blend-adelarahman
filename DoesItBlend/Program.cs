using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> items = new List<IBlendable>();

            items.Add(new Strawberry());
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());

            string result = "";
            foreach(IBlendable item in items) {
                result += item.Blend();
            }                           
            
            Console.Write();

            //Strawberry strawberry = new Strawberry();
            //Console.Write(strawberry.Blend());
        }
    }
}
