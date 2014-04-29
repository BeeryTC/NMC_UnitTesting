using System;
using System.Collections.Generic;

namespace Friends.Models
{
    public partial class Friend
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public Nullable<int> Zip { get; set; }
        public byte[] Photo { get; set; }
        public string ID { get; set; }
    }
}
