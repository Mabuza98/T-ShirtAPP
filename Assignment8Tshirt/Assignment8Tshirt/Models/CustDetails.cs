using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace A
{
    public class CustDetails
    {
        [PrimaryKey, AutoIncrement]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string T_ShirtSize { get; set; }
        public string T_ShirtColor { get; set; }
        public string DateOfOrder { get; set; }
        public string ShippingAddress { get; set; }

    }
}
