using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool HasFeathers { get; set; }
        public string WarmBlooded { get; set; }
        public bool HasHollowBones { get; set; }
        //they have hollow bones, thats how they can fly light weight.
        public bool HasBeak { get; set; }



    }
}
