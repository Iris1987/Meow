//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeowBand_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_compositiongenre
    {
        public int id_composgenre { get; set; }
        public int id_genre { get; set; }
        public int id_composition { get; set; }
    
        public virtual t_composition t_composition { get; set; }
        public virtual t_genre t_genre { get; set; }
    }
}
