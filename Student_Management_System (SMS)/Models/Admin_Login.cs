//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Management_System__SMS_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Admin_Login
    {
        [DisplayName("ADMIN ID")]
        public int admin_ID { get; set; }
        [DisplayName("PASSWORD")]
        public string password { get; set; }
        public string LoginErrorMassage1 { get; set; }
    }
}
