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
    using System.ComponentModel.DataAnnotations;

    public partial class User_Login
    {
        [DisplayName("USER ID")]
        public int user_ID { get; set; }
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string LoginErrorMassage { get; set; }
    }
}