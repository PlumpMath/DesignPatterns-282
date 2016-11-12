using System;

namespace DesignPatterns.Prototype_UserExample
{
    public abstract class User : ICloneable
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Address BusinessAddress{ get; set; }
        public Address HomeAddress { get; set; }

        public abstract object Clone();

        public abstract object DeepClone();
    }
}
