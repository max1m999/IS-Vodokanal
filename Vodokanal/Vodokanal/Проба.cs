//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vodokanal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Проба
    {
        public int Id_пробы { get; set; }
        public int Качеcтво_воды___ { get; set; }
        public int Id_лабораториии { get; set; }
        public int Id_участка { get; set; }
        public System.DateTime Дата_отбора { get; set; }
    
        public virtual Лаборатория Лаборатория { get; set; }
        public virtual Участок Участок { get; set; }
    }
}
