using System;

namespace DesignPatterns.Prototype_UserExample
{
    public class Admin : User
    {
        public override object Clone()
        {
            return (User)this.MemberwiseClone();
        }

        public override object DeepClone()
        {
            var admin = (Admin)this.MemberwiseClone();

            admin.HomeAddress = new Address
            {
                Address1 = this.HomeAddress.Address1,
                Address2 = this.HomeAddress.Address2,
                City = this.HomeAddress.City,
                State = this.HomeAddress.State,
                Zip = this.HomeAddress.Zip
            };

            admin.BusinessAddress = new Address
            {
                Address1 = this.BusinessAddress.Address1,
                Address2 = this.BusinessAddress.Address2,
                City = this.BusinessAddress.City,
                State = this.BusinessAddress.State,
                Zip = this.BusinessAddress.Zip
            };

            //admin.Name = this.Name;
            //admin.Username = this.Username;
            //admin.Password = this.Password;

            return admin;
        }
    }
}
