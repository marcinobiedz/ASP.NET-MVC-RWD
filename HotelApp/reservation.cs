//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation
    {
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public int user_id { get; set; }
        public int room_id { get; set; }
        public int days { get; set; }
        public int id { get; set; }
    
        public virtual user user { get; set; }
        public virtual room room { get; set; }
    }
}
