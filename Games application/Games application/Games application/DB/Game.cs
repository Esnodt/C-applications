//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Games_application.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public int ID { get; set; }
        public byte[] GameImg { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public int AddParamID { get; set; }
        public int SpecificID { get; set; }
    
        public virtual AddParameters AddParameters { get; set; }
        public virtual Specifications Specifications { get; set; }
    }
}