//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectDekerfsteve
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vragen
    {
        public int Id { get; set; }
        public string naam { get; set; }
        public string voornaam { get; set; }
        public string adres { get; set; }
        public string gemeente { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}