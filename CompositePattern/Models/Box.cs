using CompositePattern.Base;
using System;

namespace CompositePattern.Models
{
    public class Box : ContainerBase
    {
        public string Number { get; }
        public string Company { get; set; }


        public Box(string company)
        {
            Number = Guid.NewGuid().ToString();
            Company = company;
            Name = Company + Number;
        }
    }
}
